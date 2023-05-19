using Neptuno2022EF.Entidades.Dtos.Current_Account;
using Neptuno2022EF.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2022EF.Datos.Interfaces
{
    public interface ICurrentAccountRepository
    {
        void AddPayments(CurrentAccountDtoList clientAccount,List<CurrentAccountPaymentDtoList> movements);

        void AddSale(Venta sale);

        List<CurrentAccountDtoList> GetCurrentsAccounts();

        List<CurrentAccountPaymentDtoList> GetDebtsFromClient(int _clientId);

        List<CurrentAccountDetailsDtoList> GetClientsAccountMovements(int lientId);

    }
}
