using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neptuno2022EF.Entidades.Dtos.Current_Account;
using Neptuno2022EF.Servicios.Interfaces;

namespace Neptuno2022EF.Windows
{
    public partial class frmPayAccount : Form
    {
        //----------PROPERTIES----------//

        private CurrentAccountDtoList _accountDto;

        private ICurrentAccountServices _service;


        //----------CONSTRUCTOR----------//
        public frmPayAccount(CurrentAccountDtoList accountDto, ICurrentAccountServices service)
        {
            InitializeComponent();
            _accountDto = accountDto;
            _service = service;

            SetValues();
        }

        //----------METHODS----------//

        private void SetValues()
        {
            lblClientFullName.Text = _accountDto.ClientFullName;
            lblClientBalance.Text = _accountDto.Balance.ToString();
            txtAmount.Text = "0";
        }

        private bool ValidateAmount()
        {
            decimal amount = Convert.ToDecimal(txtAmount.Text);

            bool validaAmount = true;

            if(amount == 0)
            {
                MessageBox.Show("We do not accept payment for $ 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                validaAmount = false;
            }
            else if(amount > _accountDto.Balance * (-1))
            {
                MessageBox.Show("The amount exceeds the total debt. We only accept the total amount as payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                validaAmount = false;

                txtAmount.Text = (_accountDto.Balance * (-1)).ToString();
            }

            return validaAmount;
        }

        //----------EVENTS----------//
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (ValidateAmount())
            {
                try
                {

                }
                catch(Exception ex)
                {

                }
            }
        }
    }
}
