﻿using Neptuno2022EF.Datos.Interfaces;
using Neptuno2022EF.Entidades.Dtos.Venta;
using Neptuno2022EF.Entidades.Entidades;
using Neptuno2022EF.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Neptuno2022EF.Datos.Repositorios
{
    public class RepositorioVentas : IRepositorioVentas
    {
        private readonly NeptunoDbContext _context;

        public RepositorioVentas(NeptunoDbContext context)
        {
            _context = context;
        }

        public void Agregar(Venta venta)
        {
            _context.Ventas.Add(venta);
        }

        public List<VentaListDto> Filtrar(Func<Venta, bool> predicado)
        {
            throw new NotImplementedException();
        }

        public Venta GetVentaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<VentaListDto> GetVentas()
        {
            return _context.Ventas
                .Include(v=>v.Cliente)
                .OrderBy(v=>v.FechaVenta)
                .Select(v=>new VentaListDto
                {
                    VentaId=v.VentaId,
                    FechaVenta=v.FechaVenta,
                    Cliente=v.Cliente.Nombre,
                    Total=v.Total,
                    Estado=v.Estado.ToString()
                }).ToList();
        }

        public void SalePaid(int saleId)
        {
            try
            {
                Venta sale = _context.Ventas.FirstOrDefault(s => s.VentaId == saleId);
                sale.Estado = Estado.Paga;
                _context.Entry(sale).State = EntityState.Modified;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
