using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2022EF.Entidades.Dtos.Current_Account
{
    public class CurrentAccountDetailsDtoList
    {
        public DateTime Date { get; set; }

        public string Movement { get; set; }
    
        public decimal Debt { get; set; }

        public decimal Credit { get; set; }
    }
}
