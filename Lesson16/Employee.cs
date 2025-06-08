namespace DotNetExamples.Lesson16;

public class Employee
{
    public string name;
    public double id;
    public decimal salary;
    
    protected Employee(string name, double id, decimal salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Id
    {
        get => id;
        set => id = value;
    }

    public decimal Salary
    {
        get => salary;
        set => salary = value;
    }

    public virtual decimal CalculateAnnualSalary()
    {
        return salary * 12;
    }
}