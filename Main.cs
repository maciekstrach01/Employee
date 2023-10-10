using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Employee[] employees = new Employee[]
            {
                new Employee("Jan", "Kowalski", 5000m),
                new Employee("Anna", "Nowak", 5500m),
                new Employee("Piotr", "Wisniewski", 6000m),
            };

            decimal totalSalary = 0m;
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Name: {employees[i].Name} Surname: {employees[i].Surname} Salary: {employees[i].Salary}");
                totalSalary += employees[i].Salary;
            }

            decimal averageSalary = totalSalary/ employees.Length;
            Console.WriteLine($"The average salary of all employees is: {averageSalary}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error has occurred: {ex.Message}");
        }
    }
}
