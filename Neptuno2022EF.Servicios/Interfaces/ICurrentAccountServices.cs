using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neptuno2022EF.Entidades.Dtos.Current_Account;


namespace Neptuno2022EF.Servicios.Interfaces
{
    public interface ICurrentAccountServices
    {
        List<CurrentAccountDtoList> GetCurrentsAccounts();

        List<CurrentAccountPaymentDtoList> GetDebtsFromClient(int _clientId);

        void PayDebts(CurrentAccountDtoList clientAccount,List<CurrentAccountPaymentDtoList> movements);

        List<CurrentAccountDetailsDtoList> GetClientsAccountMovements(int clientId);
    }
}
