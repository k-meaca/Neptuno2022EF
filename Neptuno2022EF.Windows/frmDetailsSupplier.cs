using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neptuno2022EF.Entidades.Entidades;

namespace Neptuno2022EF.Windows
{
    public partial class frmDetailsSupplier : Form
    {

        //----------PROPERTIES----------//

        private Proveedor supplier;

        //----------CONSTRUCTOR----------//

        public frmDetailsSupplier(Proveedor supplier)
        {
            InitializeComponent();
            this.supplier = supplier;
            SetDetails();
        }

        //----------METHODS----------//

        private void SetDetails()
        {
            txtFullName.Text = supplier.Nombre;
            txtCountry.Text = supplier.Pais.NombrePais;
            txtCity.Text = supplier.Ciudad.NombreCiudad;
            txtAddress.Text = supplier.Direccion;
            txtPostalCod.Text = supplier.CodPostal;
        }

        //----------EVENTS----------//
        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
