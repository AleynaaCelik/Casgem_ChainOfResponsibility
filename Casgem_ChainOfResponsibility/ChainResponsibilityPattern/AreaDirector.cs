using Casgem_ChainOfResponsibility.DAL;
using Casgem_ChainOfResponsibility.Models;

namespace Casgem_ChainOfResponsibility.ChainResponsibilityPattern
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 300000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Fatma ERCİYAS";
                customerProcess.Desciption = "Müşterinin talep ettiği tutar Bölge Müdürü  tarafınddan ödendi";
                context.CustomerProcesss.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Fatma ERCİYAS";
                customerProcess.Desciption = "Müşteri tarafından talep ettiği tutar günlük ödeme bakiyemi aştığı için işlem gerçekleştirelemedi";
                context.CustomerProcesss.Add(customerProcess);
                context.SaveChanges();
                //onaylayıcı yok işlem buurada sona eriyor
            }
        }
    }
}
