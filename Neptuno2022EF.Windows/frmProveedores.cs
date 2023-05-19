using Neptuno2022EF.Entidades.Dtos.Cliente;
using Neptuno2022EF.Entidades.Dtos.Proveedor;
using Neptuno2022EF.Entidades.Entidades;
using Neptuno2022EF.Servicios.Interfaces;
using Neptuno2022EF.Windows.Helpers;
using NuevaAppComercial2022.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neptuno2022EF.Windows
{
    public partial class frmProveedores : Form
    {

        //----------PROPERTIES----------//

        private readonly IServiciosProveedores _servicio;
        private List<ProveedorListDto> _lista;
        
        private int _firstPage = 1;
        private int _actualPage;
        private int _lastPage;
        
        private int _elementsByPage;
        private int _totalRecords;

        private Func<Proveedor, bool> _filterCondition;

        //----------CONSTRUCTOR----------//

        public frmProveedores(IServiciosProveedores servicio)
        {
            InitializeComponent();
            _servicio = servicio;

            _elementsByPage = (int)nudElementsByPage.Value;
        }
        
        //----------METHODS----------//

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            foreach (ProveedorListDto proveedor in _lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
                GridHelper.SetearFila(r, proveedor);
                GridHelper.AgregarFila(dgvDatos, r);
            }
        }


        private void RecargarGrilla()
        {
            try
            {
                //_lista = _servicio.GetProveedores();
                _lista = _servicio.GetSuppliersByPage(_actualPage, _elementsByPage);
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void ShowDataFromCondition()
        {
            try
            {
                _lista = _servicio.GetSuppliersByPageAndCondition(_filterCondition, _actualPage, _elementsByPage);
                MostrarDatosEnGrilla();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void ShowDataOnPage()
        {
            if (_filterCondition is null)
            {
                RecargarGrilla();
            }
            else
            {
                ShowDataFromCondition();
            }
        }

        private int CountAllSuppliers()
        {
            return _servicio.GetProveedores().Count();
        }

        private int CountAllSuppliersFromCondition()
        {
            return _servicio.Filtrar(_filterCondition).Count();
        }

        private void FirstPage()
        {
            _actualPage = _firstPage;

            ShowDataOnPage();

            lblPaginaActual.Text = _actualPage.ToString();
        }

        private void NextPage()
        {
            if(_actualPage < _lastPage)
            {
                _actualPage++;

                ShowDataOnPage();

                lblPaginaActual.Text = _actualPage.ToString();
            }
        }

        private void PreviousPage()
        {
            if(_actualPage > _firstPage)
            {
                _actualPage--;

                ShowDataOnPage();

                lblPaginaActual.Text = _actualPage.ToString();
            }
        }

        private void LastPage()
        {
            _actualPage = _lastPage;

            ShowDataOnPage();

            lblPaginaActual.Text = _actualPage.ToString();
        }

        private void SetPages()
        {
            _actualPage = _firstPage;

            if(_filterCondition is null)
            {
                _totalRecords = CountAllSuppliers();
            }
            else
            {
                _totalRecords = CountAllSuppliersFromCondition();
            }

            lblRegistros.Text = _totalRecords.ToString();
            lblPaginaActual.Text = _actualPage.ToString();

            _lastPage = CalculosHelper.CalcularCantidadPaginas(_totalRecords, _elementsByPage);
            lblPaginas.Text = _lastPage.ToString();
        }

        //----------EVENTS----------//

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            SetPages();
            RecargarGrilla();
        }
        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //MENU'S BUTTONS

        #region

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmProveedorAE frm = new frmProveedorAE(_servicio) { Text = "Agregar Proveedor" };
            DialogResult dr = frm.ShowDialog(this);
            RecargarGrilla();
        }
        
        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            try
            {
                var r = dgvDatos.SelectedRows[0];
                ProveedorListDto proveedorDto = (ProveedorListDto)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Confirma la baja de {proveedorDto.NombreProveedor}?",
                    "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }
                var proveedor = _servicio.GetProveedorPorId(proveedorDto.ProveedorId);
                if (proveedor == null)
                {
                    MessageBox.Show("Registro dado de baja por otro usuario", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    RecargarGrilla();
                    return;
                }
                if (!_servicio.EstaRelacionado(proveedor))
                {
                    _servicio.Borrar(proveedor.Id);
                    GridHelper.BorrarFila(dgvDatos, r);
                    MessageBox.Show("Registro borrado satisfactoriamente!!!",
                        "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Registro relacionado...Baja denegada", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }


        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            ProveedorListDto proveedorDto = (ProveedorListDto)r.Tag;
            var proveedor = _servicio.GetProveedorPorId(proveedorDto.ProveedorId);
            if (proveedor == null)
            {
                MessageBox.Show("Registro dado de baja por otro usuario");
                RecargarGrilla();
                return;

            }

            frmProveedorAE frm = new frmProveedorAE(_servicio) { Text = "Editar Proveedor" };
            frm.SetProveedor(proveedor);
            DialogResult dr = frm.ShowDialog(this);
            RecargarGrilla();
        }

        private void tsbFiltrar_Click(object sender, EventArgs e)
        {
            frmSeleccionarPaisCiudad frm = new frmSeleccionarPaisCiudad() { Text = "Seleccionar País y Ciudad" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            try
            {
                var pais = frm.GetPais();
                var ciudad = frm.GetCiudad();
                
                if (ciudad == null)
                {
                    _filterCondition = c => c.PaisId == pais.PaisId;
                }
                else
                {
                    _filterCondition = c => c.PaisId == pais.PaisId && c.CiudadId == ciudad.CiudadId;
                }
                //_lista = _servicio.GetClientes(pais.PaisId, ciudad.CiudadId);

                ShowDataFromCondition();

                SetPages();

                MostrarDatosEnGrilla();
                tsbFiltrar.BackColor = Color.Orange;
            }
            catch (Exception)
            {

                throw;
            }

        }


        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            _filterCondition = null;
            FirstPage();
            SetPages();
            tsbFiltrar.BackColor = Color.White;
        }
        private void tsbDetalles_Click(object sender, EventArgs e)
        {
            if(dgvDatos.SelectedRows.Count != 0)
            {
                try
                {
                    int supplierId = ((ProveedorListDto)dgvDatos.SelectedRows[0].Tag).ProveedorId;

                    if (_servicio.Exist(supplierId))
                    {
                        Proveedor supplier = _servicio.GetProveedorPorId(supplierId);

                        frmDetailsSupplier frm = new frmDetailsSupplier(supplier);

                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("El proveedor ha sido borrado por otro usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void tsbResumen_Click(object sender, EventArgs e)
        {
            frmProductsFromSuppliers frm = new frmProductsFromSuppliers(_servicio);

            frm.ShowDialog(this);
        }

        #endregion

        //PAGINATION
        
        #region

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            FirstPage();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            LastPage();
        }

        private void nudElementsByPage_ValueChanged(object sender, EventArgs e)
        {
            _elementsByPage = Convert.ToInt32(nudElementsByPage.Value);
            SetPages();
            FirstPage();
        }
        #endregion
    }
}
