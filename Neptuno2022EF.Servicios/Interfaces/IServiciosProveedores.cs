﻿using Neptuno2022EF.Entidades.Dtos.Proveedor;
using Neptuno2022EF.Entidades.Dtos.SupplierProducts;
using Neptuno2022EF.Entidades.Entidades;
using System;
using System.Collections.Generic;

namespace Neptuno2022EF.Servicios.Interfaces
{
    public interface IServiciosProveedores
    {
        void Borrar(int id);
        bool EstaRelacionado(Proveedor proveedor);
        bool Existe(Proveedor proveedor);

        bool Exist(int supplierId);

        void Guardar(Proveedor proveedor);
        Proveedor GetProveedorPorId(int id);
        List<ProveedorListDto> GetProveedores();
        List<ProveedorListDto> GetProveedores(int paisId, int ciudadId);
        List<ProveedorListDto> Filtrar(Func<Proveedor, bool> predicado);
        List<ProveedorListDto> GetSuppliersByPage(int actualPage, int elementsByPage);

        List<ProveedorListDto> GetSuppliersByPageAndCondition(Func<Proveedor,bool> filterCondition, int actualPage, int elementsByPage);

        List<SupplierProductsDtoList> GetSuppliersWithTotalProducts();
    }
}
