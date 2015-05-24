namespace MobilePhoneDevice
{
    using System;
    public class GSMTest
    {
        GSM[] someGSMs = new GSM[2];
        static string[] someMobileModels = { "NOKIA", "Sony" };
        static string[] someMobileManufacturers = { "Finland", "Japan" };
        static int[] someMobilePrices = { 200, 150 };
        static string[] someMobileOwners = { "Bai Ivan", "Penka" };
     
   
        //Method
        public static void DisplayInfo()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("---------Mobile Phone Device---------");
                Console.WriteLine("Mobile Model: {0}", someMobileModels[i]);
                Console.WriteLine("Mobile Manufacturer: {0}", someMobileManufacturers[i]);
                Console.WriteLine("Mobile Price: ${0}", someMobilePrices[i]);
                Console.WriteLine("Mobile Owner: {0}", someMobileOwners[i]);
            }
        }
    }
}
