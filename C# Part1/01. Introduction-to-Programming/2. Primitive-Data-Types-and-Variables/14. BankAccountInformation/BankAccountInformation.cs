using System;

class BankAccountInformation
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Ivanov";
        string lastName = "Ivanov";
        double balance = 326532565.78;
        string bankName = "IIvanov";
        string iban = "BG80BNBG96611020345678";
        string bicCode = "EUFCBGSF";
        long firstCreditCardNumber = 5555555555554444;
        long secondCreditCardNumber = 5105105105105100;
        long thirdCreditCardNumber = 4111111111111111;
        Console.WriteLine("First name:" + firstName);
        Console.WriteLine("Middle name:" + middleName);
        Console.WriteLine("Last name:" + lastName);
        Console.WriteLine("Available amount of money:" + balance + "$");
        Console.WriteLine("Bank name:" + bankName);
        Console.WriteLine("IBAN:" + iban);
        Console.WriteLine("BIC code:" + bicCode);
        Console.WriteLine("First MasterCard number:" + firstCreditCardNumber);
        Console.WriteLine("Second MasterCard number:" + secondCreditCardNumber);
        Console.WriteLine("Visa number:" + thirdCreditCardNumber);
    }
}

