using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neptuno2022EF.Datos.Interfaces;
using Neptuno2022EF.Entidades.Dtos.Current_Account;
using Neptuno2022EF.Entidades.Entidades;
using System.Data.Entity;

namespace Neptuno2022EF.Datos.Repositorios
{
    public class CurrentAccountRepository : ICurrentAccountRepository
    {

        //----------PROPERTIES----------//

        private NeptunoDbContext _context;

        //----------CONSTRUCTOR----------//

        public CurrentAccountRepository(NeptunoDbContext context)
        {
            _context = context;
        }

        //----------METHODS----------//

        //----PRIVATE----//
        private bool DebtPaid(CtaCte currentAccount, List<CtaCte> accounts)
        {
            int accountId = currentAccount.CtaCteId;
            string numberOfMovement = currentAccount.Movimiento.Split(' ').Last();

            var numberOfDebts = accounts.FindAll(acc => acc.Movimiento.Contains(numberOfMovement));

            return numberOfDebts.Count() > 1;                        
        }


        //----PUBLIC----//

        public void AddPayments(CurrentAccountDtoList clientAccount,List<CurrentAccountPaymentDtoList> movements)
        {
            try
            {
                foreach(CurrentAccountPaymentDtoList movement in movements)
                {
                    CtaCte account = new CtaCte()
                    {
                        ClienteId = clientAccount.ClientId,
                        Haber = movement.Debt,
                        FechaMovimiento = DateTime.Now,
                        Debe = 0m,
                        Movimiento = $"PAGO EFECTIVO {movement.Movement.Split(' ').LastOrDefault()}"
                    };

                    _context.CtasCtes.Add(account);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void AddSale(Venta sale)
        {
            try
            {
                CtaCte currentAccount = new CtaCte()
                {
                    ClienteId = sale.ClienteId,
                    Debe = sale.Total,
                    FechaMovimiento = sale.FechaVenta,
                    Haber = 0,
                    Movimiento = $"FACT {sale.VentaId}"
                };

                _context.CtasCtes.Add(currentAccount);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<CurrentAccountDtoList> GetCurrentsAccounts()
        {
            var accountsList = _context.CtasCtes.ToList();
            var clientsList = _context.Clientes.ToList();

            var result = from cta in accountsList
                         join cte in clientsList
                         on cta.ClienteId equals cte.Id
                         group cta by cta.ClienteId into groupedAccounts
                         orderby groupedAccounts.Key
                         let account = groupedAccounts.FirstOrDefault(c => c.ClienteId == groupedAccounts.Key)
                         select new CurrentAccountDtoList()
                         {
                             ClientId = groupedAccounts.Key,
                             ClientFullName = account.Cliente.Nombre,
                             Balance = groupedAccounts.Sum(c => c.Debe - c.Haber) * (-1)
                         };
                
            return result.ToList();
        }

        public List<CurrentAccountPaymentDtoList> GetDebtsFromClient(int clientId)
        {

            var accounts = _context.CtasCtes.ToList();

            var result = from account in accounts
                         where account.ClienteId == clientId && !DebtPaid(account, accounts)
                         select new CurrentAccountPaymentDtoList()
                         {
                             AccoundId = account.CtaCteId,
                             DateOfMovement = account.FechaMovimiento,
                             Movement = account.Movimiento,
                             Debt = account.Debe
                         };

            return result.ToList();
        }

        public List<CurrentAccountDetailsDtoList> GetClientsAccountMovements(int clientId)
        {
            try
            {
                var accountDetails = _context.CtasCtes.Where(c => c.ClienteId == clientId)
                                                      .OrderBy(c => c.FechaMovimiento)
                                                      .Select(c => new CurrentAccountDetailsDtoList()
                                                      {
                                                          Date = c.FechaMovimiento,
                                                          Movement = c.Movimiento,
                                                          Debt = c.Debe,
                                                          Credit = c.Haber
                                                      })
                                                      .ToList();

                return accountDetails;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
