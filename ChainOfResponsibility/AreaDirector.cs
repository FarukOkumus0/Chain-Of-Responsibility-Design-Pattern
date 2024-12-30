using DesingPattern.ChainOfResponsibility.DAL;
using DesingPattern.ChainOfResponsibility.Models;

namespace DesingPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 400000)
            {

                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Müdürü: Recep Sarızeybek";
                customerProcess.Description = "Müşterinin çekmek istediği tutar ödenmiştir.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Müdürü: Recep Sarızeybek";
                customerProcess.Description = "Talep edilen tutar bölge müdürlüğünün günlük limitinden fazla olduğu için işlem gerçekleştirilemedi. Günlük maksimum tutar 400000tl olup müşterinin farklı günlerde para çekme işlemini tamamlaması gerekmektedir.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                
            }
        }
    }
}
