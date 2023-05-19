using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Neptuno2022EF.Entidades.Entidades;

namespace Neptuno2022EF.Datos.EntityTypeConfigurations
{
    public class CurrentAccountEntityTypeConfiguration : EntityTypeConfiguration<CtaCte>
    {
        public CurrentAccountEntityTypeConfiguration()
        {
            ToTable("CtasCtes");
            HasKey(c => c.CtaCteId);
            Property(c => c.FechaMovimiento).HasColumnType("datetime");
            Property(c => c.RowVersion).IsRowVersion().IsConcurrencyToken();
        }
    }
}
