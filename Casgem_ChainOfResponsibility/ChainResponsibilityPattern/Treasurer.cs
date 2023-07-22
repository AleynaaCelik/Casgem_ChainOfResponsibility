using Casgem_ChainOfResponsibility.DAL;
using Casgem_ChainOfResponsibility.Models;

namespace Casgem_ChainOfResponsibility.ChainResponsibilityPattern
{
    public class Treasurer : Employee //veznedar 
    {
        public override void ProcessRequest(CustomerViewModel req)
        {
            Context context = new Context();
            if (req.Amount < 50000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Mert Çağlı";
                customerProcess.Desciption = "Müşterinin talep ettiği tutar Veznedar tarafınddan ödendi";
                context.CustomerProcesss.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount=req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Mert Çağlı";
                customerProcess.Desciption = "Müşteri tarafından talep ettiği tutar günlük ödeme bakiyemi aştığı için Şube müdür yardımcısına yönlendirdim";
                context.CustomerProcesss.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
