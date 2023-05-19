using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neptuno2022EF.Entidades.Enums;
using NuevaAppComercial2022.Entidades.Entidades;
using Neptuno2022EF.Entidades.Dtos.Venta;

namespace Neptuno2022EF.Entidades.Entidades
{
    public class Venta
    {
        public int VentaId { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }
        public Estado Estado { get; set; }
        public byte[] RowVersion { get; set; }
        public List<DetalleVenta> Detalles { get; set; }

        public Venta()
        {
            Detalles = new List<DetalleVenta>();
        }
        //public decimal GetTotal() => Detalles.Sum(d => d.Cantidad * d.PrecioUnitario);
        public Cliente Cliente { get; set; }

        public VentaListDto ToDto()
        {
            return new VentaListDto()
            {
                VentaId = VentaId,
                Cliente = Cliente.Nombre,
                Estado = Estado.ToString(),
                Total = this.Total,
                FechaVenta = this.FechaVenta
            };
        }
    }
}
