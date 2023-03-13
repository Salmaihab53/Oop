// See https://aka.ms/new-console-template for more information
using System;

using System;

public class Employee
{
    // Attributes
    public string firstName;
    public string LastName;
    public int age;
    public string jobTitle;
    public double salary;
    public bool isFullTime;
    public string department;
    public string email;

    // Constructors
    public Employee(string firstName, string lastName, int age, string jobTitle, double salary, bool isFullTime, string department, string email)
    {
        this.firstName = firstName;
        this.LastName = lastName;
        this.age = age;
        this.jobTitle = jobTitle;
        this.salary = salary;
        this.isFullTime = isFullTime;
        this.department = department;
        this.email = email;
    }

    public Employee(string firstName, string lastName, int age, string jobTitle, double salary, bool isFullTime)
        : this(firstName, lastName, age, jobTitle, salary, isFullTime, "", "")
    {
    }

    public Employee(string firstName, string lastName, int age, string jobTitle, double salary)
        : this(firstName, lastName, age, jobTitle, salary, true, "", "")
    {
    }

    public Employee(string firstName, string lastName, int age, string jobTitle)
        : this(firstName, lastName, age, jobTitle, 0, true, "", "")
    {
    }

    public Employee(string firstName, string lastName, int age)
        : this(firstName, lastName, age, "", 0, true, "", "")
    {
    }

    // Methods
    public string GetFullName()
    {
        return this.firstName + " " + this.LastName;
    }

    public double GetAnnualSalary()
    {
        return this.salary * 12;
    }

    public void IncreaseSalary(double percent)
    {
        this.salary *= (1 + percent / 100);
    }

    public void ChangeJobTitle(string newJobTitle)
    {
        this.jobTitle = newJobTitle;
    }

    public void ChangeDepartment(string newDepartment)
    {
        this.department = newDepartment;
    }

    public void PrintEmployeeInfo()
    {
        Console.WriteLine("Employee Name: " + GetFullName());
        Console.WriteLine("Age: " + this.age);
        Console.WriteLine("Job Title: " + this.jobTitle);
        Console.WriteLine("Salary: " + this.salary);
        Console.WriteLine("Is Full Time: " + this.isFullTime);
        Console.WriteLine("Department: " + this.department);
        Console.WriteLine("Email: " + this.email);
    }
}























