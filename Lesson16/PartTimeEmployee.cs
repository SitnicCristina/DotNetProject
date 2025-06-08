namespace DotNetExamples.Lesson16;

public class PartTimeEmployee : Employee
{
    public int HourlyRate;

    public PartTimeEmployee(string name, double id, decimal salary, int hourlyRate) : base(name, id, salary)
    {
        HourlyRate = hourlyRate;
    }

    public override decimal CalculateAnnualSalary()
    {
        // calculeaza pentru parttime 20 ore pe luna
        return  HourlyRate * 20 * 12 ;
    }
}