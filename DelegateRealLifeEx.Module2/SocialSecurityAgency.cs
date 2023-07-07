using DelegateRealLifeEx.Domain;

namespace DelegateRealLifeEx.Module2
{
	public class SocialSecurityAgency
	{
		public static bool MinSalaryPromote(Employee employee)
		{
			return employee.Salary < 3500;

			//if (employee.Salary < 3500)
			//	return true;
			//else
			//	return false;
		}
	}
}