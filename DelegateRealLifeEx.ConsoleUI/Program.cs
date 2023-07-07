using DelegateRealLifeEx.Domain;
using DelegateRealLifeEx.Module1;
using DelegateRealLifeEx.Module2;

namespace DelegateRealLifeEx.ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Employee emp1 = new Employee("Ahmet Bircan", 7500, new DateTime(2022, 12, 3));
			Employee emp2 = new Employee("Özlem Kalender", 5500, new DateTime(2013, 12, 3));
			Employee emp3 = new Employee("Mevlüt Tuna", 2500, new DateTime(2014, 12, 3));
			Employee emp4 = new Employee("Ali Yazıcı", 4500, new DateTime(2022, 1, 3));
			Employee emp5 = new Employee("Pelin Özak", 7500, new DateTime(2012, 12, 3));

			Employee[] empArr = { emp1, emp2, emp3, emp4,emp5 };


			Console.WriteLine("İnsan Kaynakları Modülüne Göre Promosyon Hak Edenler");
			//Employee.PromoteEmployee(HumanResource.WorkingDayPromote, emp1, emp2, emp3, emp4, emp5);
			Employee.PromoteEmployee(HumanResource.WorkingDayPromote, empArr);


			Console.WriteLine("Sosyal Güvenlik Modülüne Göre Promosyon Hak Edenler");
			Employee.PromoteEmployee(SocialSecurityAgency.MinSalaryPromote, emp1, emp2, emp3, emp4, emp5);
		}

		

		

	}
}