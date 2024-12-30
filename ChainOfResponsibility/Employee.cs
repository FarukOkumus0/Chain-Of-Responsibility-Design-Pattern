using DesingPattern.ChainOfResponsibility.Models;

namespace DesingPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;

        public void SetNextApprover(Employee superVisor)
        {
            this.NextApprover = superVisor;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel req);
    }
}
