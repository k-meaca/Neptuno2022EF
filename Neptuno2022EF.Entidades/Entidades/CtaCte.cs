using NuevaAppComercial2022.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neptuno2022EF.Entidades.Dtos.Current_Account;
using System.Collections;

namespace Neptuno2022EF.Entidades.Entidades
{
    public class CtaCte : ICloneable
    {
        public int CtaCteId { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public string Movimiento { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
        public decimal Saldo { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public byte[] RowVersion { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public CurrentAccountDtoList ToDto()
        {
            return new CurrentAccountDtoList()
            {
                ClientId = ClienteId,
                ClientFullName = Cliente.Nombre,
                Balance = Saldo
            };
        }

    }
}
