namespace DotNetExamples.Lesson16;

public class FullTimeEmployee : Employee
{
    public decimal Bonus { get; set; }
    
    public FullTimeEmployee(string name, double id, decimal salary, int bonus) : base(name, id, salary)
    {
        Bonus = bonus;
    }
    
    public override decimal CalculateAnnualSalary()
    {
        return (salary * 12) + Bonus;
    }
}