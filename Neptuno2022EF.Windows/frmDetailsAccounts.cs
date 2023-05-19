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
    public partial class frmDetailsAccounts : Form
    {
        //----------PROPERTIES----------//

        private ICurrentAccountServices _service;
        private List<CurrentAccountDetailsDtoList> _list;

        private CurrentAccountDtoList _clientAccount;

        //----------CONSTRUCTOR----------//
        public frmDetailsAccounts(CurrentAccountDtoList clientAccount, ICurrentAccountServices service)
        {
            InitializeComponent();
            _service = service;
            _clientAccount = clientAccount;

            lblClientFullName.Text = _clientAccount.ClientFullName;
        }

        //----------METHODS----------//

        private void FillData()
        {
            GridHelper.LimpiarGrilla(dgvData);
            foreach (CurrentAccountDetailsDtoList movement in _list)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvData);
                GridHelper.SetearFila(r, movement);
                GridHelper.AgregarFila(dgvData, r);
            }

            lblAmount.Text = _list.Sum(acc => acc.Credit - acc.Debt).ToString("C");
        }

        private void ShowData()
        {
            try
            {
                _list = _service.GetClientsAccountMovements(_clientAccount.ClientId);
                FillData();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        //----------EVENTS----------//
        private void frmDetailsAccounts_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
