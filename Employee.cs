using System;
public class Employee
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, string surname, decimal salary)
    {
        Name = name;
        Surname = surname;
        Salary = salary;
    }
}