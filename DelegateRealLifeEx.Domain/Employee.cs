namespace DelegateRealLifeEx.Domain
{
	public class Employee
	{

        public Employee(DateTime startDate)
        {
            StartDate=startDate;
            Id=Guid.NewGuid().ToString();
        }

        public Employee(string fullname,decimal salary,DateTime startDate):this(startDate)
        {
            FullName = fullname;
            Salary=salary;
            
        }

        public string Id { get; set; }

        public string FullName { get; set; }

        public decimal Salary { get; set; }

        public DateTime StartDate { get; set; }

        public static void PromoteEmployee(EligibleToPromotion isPromoted, params Employee[] lstEmployees)
        {
            foreach (Employee emp in lstEmployees)
            {
                if (isPromoted.Invoke(emp))
                {
                    Console.WriteLine($"Employee {emp.FullName} prometed");
                }
            }

        }
    }
}