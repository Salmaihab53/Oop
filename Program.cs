// See https://aka.ms/new-console-template for more information
using System;

using System;

public class Employee
{
    private string firstName;
    private string lastName;
    private string[] skills;
    private string position;
    private decimal salary;
    private DateTime hireDate;
    private string phoneNumber;
    private string email;

    public Employee()
    {
        firstName = "John";
        lastName = "Doe";
        skills = new string[] { "Unknown" };
        position = "Unknown";
        salary = 0;
        hireDate = DateTime.Now;
        phoneNumber = "Unknown";
        email = "Unknown";
    }

    public Employee(string firstName, string lastName, string[] skills, string position, decimal salary, DateTime hireDate, string phoneNumber, string email)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.skills = skills;
        this.position = position;
        this.salary = salary;
        this.hireDate = hireDate;
        this.phoneNumber = phoneNumber;
        this.email = email;
    }

    public Employee(string firstName, string lastName, string[] skills, string position, decimal salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.skills = skills;
        this.position = position;
        this.salary = salary;
        this.hireDate = DateTime.Now;
        this.phoneNumber = "Unknown";
        this.email = "Unknown";
    }

    public Employee(string firstName, string lastName, string position, decimal salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.skills = new string[] { "Unknown" };
        this.position = position;
        this.salary = salary;
        this.hireDate = DateTime.Now;
        this.phoneNumber = "Unknown";
        this.email = "Unknown";
    }

    public Employee(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.skills = new string[] { "Unknown" };
        this.position = "Unknown";
        this.salary = 0;
        this.hireDate = DateTime.Now;
        this.phoneNumber = "Unknown";
        this.email = "Unknown";
    }

    public void UpdateSkills(string[] newSkills)
    {
        skills = newSkills;
    }

    public string GetFullName()
    {
        return firstName + " " + lastName;
    }

    public decimal GetSalary()
    {
        return salary;
    }

    public void SetSalary(decimal newSalary)
    {
        salary = newSalary;
    }

    public DateTime GetHireDate()
    {
        return hireDate;
    }

    public string[] GetSkills()
    {
        return skills;
    }

    public void SetSkills(string[] newSkills)
    {
        skills = newSkills;
    }
}
























