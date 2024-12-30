using DesingPattern.ChainOfResponsibility.DAL;
using DesingPattern.ChainOfResponsibility.Models;

namespace DesingPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class ManagerAssistant : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 150000)
            {
                
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı: Ömer Davarcı";
                customerProcess.Description = "Müşterinin çekmek istediği tutar ödenmiştir.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı: Ömer Davarcı";
                customerProcess.Description = "Talep edilen tutar Müdür Yardımcısının günlük limitinden fazla olduğu için işlem şube müdürüne yönlendirildi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
