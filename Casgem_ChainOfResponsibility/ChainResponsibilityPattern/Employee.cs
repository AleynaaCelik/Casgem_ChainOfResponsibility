using Casgem_ChainOfResponsibility.Models;

namespace Casgem_ChainOfResponsibility.ChainResponsibilityPattern
{
    public abstract class Employee
    {
        //abstract varsa miras da var 
        protected Employee NextApprover; //Onaylayıcı 
        public void SetNextApprover (Employee Supervisor)
        {
            this.NextApprover = Supervisor;
        }
        public abstract void ProcessRequest(CustomerViewModel req);
    }
}
