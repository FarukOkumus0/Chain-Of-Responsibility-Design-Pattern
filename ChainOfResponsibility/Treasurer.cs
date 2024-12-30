using DesingPattern.ChainOfResponsibility.DAL;
using DesingPattern.ChainOfResponsibility.Models;

namespace DesingPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Vezne Memuru: Hakan Kaçar";
                customerProcess.Description = "Müşterinin çekmek istediği tutar ödenmiştir.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Vezne Memuru: Hakan Kaçar";
                customerProcess.Description = "Talep edilen tutar vezne limitinden fazla olduğu için işlem şube müdür yardımcısına yönlendirildi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
