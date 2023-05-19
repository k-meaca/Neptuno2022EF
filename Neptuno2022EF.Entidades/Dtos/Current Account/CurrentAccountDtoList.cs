using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2022EF.Entidades.Dtos.Current_Account
{
    public class CurrentAccountDtoList
    { 
        public int ClientId { get; set; }

        public string ClientFullName { get; set; }

        public decimal Balance { get; set; }
    }
}
