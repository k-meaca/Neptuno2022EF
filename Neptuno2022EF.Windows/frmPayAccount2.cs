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
    public partial class frmPayAccount2 : Form
    {

        //----------PROPERTIES----------//

        private ICurrentAccountServices _service;
        private List<CurrentAccountPaymentDtoList> _list;
        private CurrentAccountDtoList _currentAccount;

        private List<CurrentAccountPaymentDtoList> _partialPayment;

        //----------CONSTRUCTOR----------//
        public frmPayAccount2(CurrentAccountDtoList currentAccount, ICurrentAccountServices service)
        {
            InitializeComponent();
            _currentAccount = currentAccount;
            _service = service;
            _partialPayment = new List<CurrentAccountPaymentDtoList>();
        }

        //----------METHODS----------//

        private void DeselectRow(int accountId)
        {
            bool deselectedRow = false;
            int numberOfRow = 0;

            while (!deselectedRow && numberOfRow < dgvDataDebts.Rows.Count)
            {

                DataGridViewRow row = dgvDataDebts.Rows[numberOfRow];
                
                CurrentAccountPaymentDtoList account = (CurrentAccountPaymentDtoList)row.Tag;
                
                if(account.AccoundId == accountId)
                {
                    deselectedRow = true;

                    //row.DefaultCellStyle.BackColor = Color.White;

                    row.Visible = true;
                }

                numberOfRow++;
            }
        }

        private void FillData()
        {
            GridHelper.LimpiarGrilla(dgvDataDebts);
            foreach (CurrentAccountPaymentDtoList debts in _list)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvDataDebts);
                GridHelper.SetearFila(r, debts);
                GridHelper.AgregarFila(dgvDataDebts, r);
            }
        }

        private void SetLabels()
        {
            lblClientFullName.Text = _currentAccount.ClientFullName;

            lblTotalAmmount.Text = _list.Sum(acc => acc.Debt).ToString("C");

            lblPartialAmount.Text = $"{0:C}";
        }

        private void ShowData()
        {
            try
            {
                _list = _service.GetDebtsFromClient(_currentAccount.ClientId);
                
                FillData();

                SetLabels();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidateRowSelected(DataGridViewRow row)
        {
            //return row.DefaultCellStyle.BackColor != Color.Lime;
            return row.Visible == true;
        }

        //----------EVENTS----------//
        private void frmPayAccount2_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        //----BUTTON ADD & REMOVE----//

        #region
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvDataDebts.SelectedRows.Count != 0 && ValidateRowSelected(dgvDataDebts.SelectedRows[0]))
            {
                CurrentAccountPaymentDtoList movement = (CurrentAccountPaymentDtoList)dgvDataDebts.SelectedRows[0].Tag;
                DialogResult option = MessageBox.Show($"Do you want to pay this movement: {movement.Movement}","Pay",
                                                             MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

                if(option == DialogResult.OK)
                {
                    _partialPayment.Add(movement);

                    var row = GridHelper.ConstruirFila(dgvPartialPayment);
                    GridHelper.SetearFila(row, movement);
                    GridHelper.AgregarFila(dgvPartialPayment, row);

                    MessageBox.Show("Movement Added Succesfully", "Pay", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    lblPartialAmount.Text = _partialPayment.Sum(acc => acc.Debt).ToString("C");

                    //dgvDataDebts.SelectedRows[0].DefaultCellStyle.BackColor = Color.Lime;

                    dgvDataDebts.SelectedRows[0].Visible = false;

                }
            }
            else
            {
                MessageBox.Show("You have to select a movement or there is no more movements.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvPartialPayment.SelectedRows.Count != 0)
            {
                CurrentAccountPaymentDtoList movement = (CurrentAccountPaymentDtoList)dgvPartialPayment.SelectedRows[0].Tag;
                DialogResult option = MessageBox.Show($"Do you want to remove this movement from the partial payment: {movement.Movement}",
                                                                    "Remove Payment", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (option == DialogResult.OK)
                {
                    _partialPayment.Remove(movement);

                    var row = dgvPartialPayment.SelectedRows[0];
                    GridHelper.BorrarFila(dgvPartialPayment, row);

                    MessageBox.Show("Movement Removed Succesfully", "Remove Payment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    lblPartialAmount.Text = _partialPayment.Sum(acc => acc.Debt).ToString("C");

                    DeselectRow(movement.AccoundId);
                }
            }
            else
            {
                MessageBox.Show("You have to select a movement or there is no more movements.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        //----BUTTONS TO PAY----//

        #region
        private void btnPartialPayment_Click(object sender, EventArgs e)
        {
            if (_partialPayment.Any())
            {
                try
                {
                    _service.PayDebts(_currentAccount,_partialPayment);

                    MessageBox.Show("The movements has been paid succesfully.", "Succesfull Movement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There is no movements selected to pay for", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFullPayment_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("You're going to pay all debts. Do you want to continue?", "Warning",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(option == DialogResult.Yes)
            {
                try
                {
                    _service.PayDebts(_currentAccount, _list);

                    MessageBox.Show("The movements has been paid succesfully.", "Succesfull Movement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }
}
