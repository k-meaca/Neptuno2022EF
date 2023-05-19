using Neptuno2022EF.Entidades.Dtos.Cliente;
using Neptuno2022EF.Entidades.Dtos.Proveedor;
using Neptuno2022EF.Entidades.Dtos.SupplierProducts;
using Neptuno2022EF.Entidades.Entidades;
using NuevaAppComercial2022.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2022EF.Datos.Interfaces
{
    public interface IRepositorioProveedores
    {
        void Agregar(Proveedor proveedor);
        void Borrar(int id);
        void Editar(Proveedor proveedor);
        bool EstaRelacionado(Proveedor proveedor);
        bool Existe(Proveedor proveedor);

        bool Exist(int supplierId);
        Proveedor GetProveedorPorId(int id);
        List<ProveedorListDto> GetProveedores();
        List<ProveedorListDto> GetProveedores(int paisId, int ciudadId);
        List<ProveedorListDto> Filtrar(Func<Proveedor, bool> predicado);
        List<ProveedorListDto> GetSuppliersByPage(int actualPage, int elementByPage);
        List<ProveedorListDto> GetSuppliersByPageAndCondition(Func<Proveedor,bool> filterCondition, int actualPage, int elementsByPage);

        List<SupplierProductsDtoList> GetSuppliersWithTotalProducts();
    }
}
