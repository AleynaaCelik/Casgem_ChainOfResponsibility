using Casgem_ChainOfResponsibility.DAL;
using Casgem_ChainOfResponsibility.Models;

namespace Casgem_ChainOfResponsibility.ChainResponsibilityPattern
{
    public class Manager : Employee
    {
        public override void ProcessRequest(CustomerViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 200000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Aleyna ÇELİK";
                customerProcess.Desciption = "Müşterinin talep ettiği tutar Şube Müdürü  tarafınddan ödendi";
                context.CustomerProcesss.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Aleyna ÇELİK";
                customerProcess.Desciption = "Müşteri tarafından talep ettiği tutar günlük ödeme bakiyemi aştığı için Bölge müdürüne yönlendirdim";
                context.CustomerProcesss.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
