using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neptuno2022EF.Servicios.Interfaces;
using Neptuno2022EF.Entidades.Dtos.Current_Account;
using Neptuno2022EF.Windows.Helpers;

namespace Neptuno2022EF.Windows
{
    public partial class frmCurrentsAccounts : Form
    {

        //----------PROPERTIES----------//

        private ICurrentAccountServices _service;
        private List<CurrentAccountDtoList> _list;

        //----------CONSTRUCTOR----------//
        public frmCurrentsAccounts(ICurrentAccountServices service)
        {
            InitializeComponent();
            _service = service;
        }

        //----------METHODS----------//


        private void FillData(List<CurrentAccountDtoList> list)
        {
            GridHelper.LimpiarGrilla(dgvData);
            foreach (CurrentAccountDtoList account in list)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvData);
                GridHelper.SetearFila(r, account);
                GridHelper.AgregarFila(dgvData, r);
            }
        }
        private void ShowData()
        {
            try
            {
                _list = _service.GetCurrentsAccounts();
                FillData(_list);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        //----------EVENTS----------//
        private void frmCurrentsAccounts_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        //----MENU'S BUTTONS----//

        #region

        private void tsbPayAccount_Click(object sender, EventArgs e)
        {
            if(dgvData.SelectedRows.Count != 0)
            {
                CurrentAccountDtoList currentAccount = (CurrentAccountDtoList)dgvData.SelectedRows[0].Tag;

                if(currentAccount.Balance != 0)
                {
                    frmPayAccount2 frm = new frmPayAccount2(currentAccount, _service);

                    DialogResult result = frm.ShowDialog(this);

                    if(result == DialogResult.OK)
                    {
                        ShowData();
                    }
                }
                else
                {
                    MessageBox.Show("Your account has been paid in full.", "Current Account Settled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void tbsAccountDetails_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count != 0)
            {
                CurrentAccountDtoList currentAccount = (CurrentAccountDtoList)dgvData.SelectedRows[0].Tag;

                frmDetailsAccounts frm = new frmDetailsAccounts(currentAccount, _service);

                frm.ShowDialog(this);

            }
        }

        #endregion
        private void tbsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                ShowData();
            }
            else
            {
                string searchedName = txtSearch.Text.ToLower();

                var list = _list.FindAll(c => 
                    {
                        var clientsName = c.ClientFullName.ToLower();
                        
                        return clientsName.StartsWith(searchedName);
                    }
                );

                FillData(list);
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
        }
    }
}
