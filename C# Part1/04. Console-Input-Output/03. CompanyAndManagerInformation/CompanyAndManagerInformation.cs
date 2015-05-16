using System;

class CompanyAndManagerInformation
{
    static void Main()
    {
        Console.Write("Enter company name:");
        string companyName = Console.ReadLine();
        Console.Write("Enter company address:");
        string address = Console.ReadLine();
        Console.Write("Enter company phone number:");
        long phoneNumber = long.Parse(Console.ReadLine());
        Console.Write("Enter company website:");
        string webSite = Console.ReadLine();
        Console.Write("Enter company's manager name:");
        string managerName = Console.ReadLine();
        Console.Write("Enter manager's first name:");
        string firstName = Console.ReadLine();
        Console.Write("Enter manager's last name:");
        string lastName = Console.ReadLine();
        Console.Write("Enter manager's age:");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter manager's phone number:");
        long managerPhoneNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("------------------Company information------------------");
        Console.WriteLine("Copmany name:{0}", companyName);
        Console.WriteLine("Adress:{0}", address);
        Console.WriteLine("Phone number:{0}", phoneNumber);
        Console.WriteLine("Manager name:{0}", managerName);
        Console.WriteLine("------------------Information about the manager------------------");
        Console.WriteLine("First name:{0}", firstName);
        Console.WriteLine("Last name:{0}", lastName);
        Console.WriteLine("Age:{0}", age);
        Console.WriteLine("Phone number:{0}", managerPhoneNumber);
    }
}

