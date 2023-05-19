using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neptuno2022EF.Servicios.Interfaces;
using Neptuno2022EF.Entidades.Dtos.Current_Account;
using Neptuno2022EF.Datos.Interfaces;
using System.Transactions;
using Neptuno2022EF.Datos;

namespace Neptuno2022EF.Servicios.Servicios
{
    public class CurrentAccountService : ICurrentAccountServices
    {
        //----------PROPERTIES----------//
        private ICurrentAccountRepository _repoAccounts;
        private IServiciosVentas _repoSales;
        private IUnitOfWork _unitOfWork;

        //----------CONSTRUCTOR------------//

        public CurrentAccountService(ICurrentAccountRepository repoAccounts,
                                     IServiciosVentas repoSales,
                                     IUnitOfWork unitOfWork) {
            
            _repoAccounts = repoAccounts;
            _repoSales = repoSales;
            _unitOfWork = unitOfWork;
        }

        //----------METHODS----------//

        public List<CurrentAccountDtoList> GetCurrentsAccounts()
        {
            return _repoAccounts.GetCurrentsAccounts();
        }

        public List<CurrentAccountPaymentDtoList> GetDebtsFromClient(int _clientId)
        {
            return _repoAccounts.GetDebtsFromClient(_clientId);
        }

        public void PayDebts(CurrentAccountDtoList clientAccount,List<CurrentAccountPaymentDtoList> movements)
        {
            try
            {
                using(var transaction = new TransactionScope())
                {
                    _repoAccounts.AddPayments(clientAccount,movements);
                    _unitOfWork.SaveChanges();

                    foreach(CurrentAccountPaymentDtoList movement in movements)
                    {
                        int saleId = Convert.ToInt32(movement.Movement.Split(' ').LastOrDefault());

                        _repoSales.SalePaid(saleId);
                    }

                    _unitOfWork.SaveChanges();
                    transaction.Complete();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<CurrentAccountDetailsDtoList> GetClientsAccountMovements(int lientId)
        {
            return _repoAccounts.GetClientsAccountMovements(lientId);
        }
    }
}
