using DelegateRealLifeEx.Domain;

namespace DelegateRealLifeEx.Module1
{
	public class HumanResource
	{
		public static bool WorkingDayPromote(Employee employee)
		{
			return DateTime.Now.Subtract(employee.StartDate).TotalDays >= 365;
		}
	}
}