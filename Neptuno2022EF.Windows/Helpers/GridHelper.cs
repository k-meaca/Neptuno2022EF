using Neptuno2022EF.Entidades.Dtos.Ciudad;
using Neptuno2022EF.Entidades.Dtos.Cliente;
using Neptuno2022EF.Entidades.Dtos.DetalleVenta;
using Neptuno2022EF.Entidades.Dtos.Producto;
using Neptuno2022EF.Entidades.Dtos.Proveedor;
using Neptuno2022EF.Entidades.Dtos.Venta;
using Neptuno2022EF.Entidades.Dtos.Current_Account;
using Neptuno2022EF.Entidades.Dtos.SupplierProducts;
using Neptuno2022EF.Entidades.Entidades;
using Neptuno2022EF.Windows.Classes;
using System;
using System.Windows.Forms;

namespace Neptuno2022EF.Windows.Helpers
{
    public static class GridHelper
    {
        public static void LimpiarGrilla(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

        }
        public static DataGridViewRow ConstruirFila(DataGridView dataGrid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(dataGrid);
            return r;
        }

        public static void AgregarFila(DataGridView dataGrid, DataGridViewRow r)
        {
            dataGrid.Rows.Add(r);
        }

        public static void SetearFila(DataGridViewRow r, Object obj)
        {
            switch (obj)
            {
                case Pais p:
                    r.Cells[0].Value = p.NombrePais;

                    break;
                case Categoria c:
                    r.Cells[0].Value = c.NombreCategoria;
                    r.Cells[1].Value = c.Descripcion;

                    break;
                case CiudadListDto ciudadDto:
                    r.Cells[0].Value = ciudadDto.NombrePais;
                    r.Cells[1].Value = ciudadDto.NombreCiudad;

                    break;
                case ClienteListDto clienteDto:
                    r.Cells[0].Value = clienteDto.NombreCliente;
                    r.Cells[1].Value = clienteDto.Pais;
                    r.Cells[2].Value = clienteDto.Ciudad;
                    break;
                case ProveedorListDto proveedorDto:
                    r.Cells[0].Value = proveedorDto.NombreProveedor;
                    r.Cells[1].Value = proveedorDto.Pais;
                    r.Cells[2].Value = proveedorDto.Ciudad;
                    break;
                case VentaListDto ventaDto:
                    r.Cells[0].Value = ventaDto.VentaId;
                    r.Cells[1].Value = ventaDto.FechaVenta.ToShortDateString();
                    r.Cells[2].Value = ventaDto.Cliente;
                    r.Cells[3].Value = ventaDto.Total;
                    r.Cells[4].Value = ventaDto.Estado;
                    break;

                case ProductoListDto producto:
                    r.Cells[0].Value = producto.NombreProducto;
                    r.Cells[1].Value = producto.Categoria;
                    r.Cells[2].Value = producto.PrecioUnitario;
                    r.Cells[3].Value = producto.UnidadesDisponibles;
                    r.Cells[4].Value = producto.Suspendido;
                    
                    break;
                case ItemCarrito detalle:
                    r.Cells[0].Value = detalle.Descripcion;
                    r.Cells[1].Value = detalle.Cantidad;
                    r.Cells[2].Value = detalle.Precio;
                    r.Cells[3].Value = detalle.Subtotal;
                    
                    break;
                case DetalleVentaListDto detalle:
                    r.Cells[0].Value = detalle.Producto;
                    r.Cells[1].Value = detalle.Cantidad;
                    r.Cells[2].Value = detalle.PrecioUnitario;
                    r.Cells[3].Value = detalle.Subtotal;
                    
                    break;
                case CurrentAccountDtoList account:
                    r.Cells[0].Value = account.ClientFullName;
                    r.Cells[1].Value = account.Balance;

                    break;
                case SupplierProductsDtoList supplierProducts:
                    r.Cells[0].Value = supplierProducts.Supplier;
                    r.Cells[1].Value = supplierProducts.TotalProducts;

                    break;
                case CurrentAccountPaymentDtoList debt:
                    r.Cells[0].Value = debt.DateOfMovement.ToString();
                    r.Cells[1].Value = debt.Movement;
                    r.Cells[2].Value = debt.Debt.ToString("C");

                    break;
                case CurrentAccountDetailsDtoList movement:
                    r.Cells[0].Value = movement.Date.ToString();
                    r.Cells[1].Value = movement.Movement;
                    r.Cells[2].Value = movement.Debt.ToString("C");
                    r.Cells[3].Value = movement.Credit.ToString("C");

                    break;
            }

            r.Tag = obj;

        }

        public static void BorrarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Remove(r);
        }

    }
}
