using Neptuno2022EF.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neptuno2022EF.Entidades.Dtos.SupplierProducts;
using Neptuno2022EF.Windows.Helpers;

namespace Neptuno2022EF.Windows
{
    public partial class frmProductsFromSuppliers : Form
    {
        //----------PROPERTIES----------//

        private IServiciosProveedores _service;
        private List<SupplierProductsDtoList> _list;

        //----------CONSTRUCTOR----------//

        public frmProductsFromSuppliers(IServiciosProveedores servicio)
        {
            InitializeComponent();
            _service = servicio;
        }

        //----------METHODS----------//

        private void FillData()
        {
            GridHelper.LimpiarGrilla(dgvData);
            foreach (SupplierProductsDtoList supplierProducts in _list)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvData);
                GridHelper.SetearFila(r, supplierProducts);
                GridHelper.AgregarFila(dgvData, r);
            }
        }

        private void ShowData()
        {
            try
            {
                _list = _service.GetSuppliersWithTotalProducts();
                FillData();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        //---------EVENTS----------//
        private void frmProductsFromSuppliers_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
