namespace Task5To7_GenericClass
{
    using System;
    using System;
    public class Task5To7
    {
        static void Main()
        {
            try
            {
                //CREATING A NEW LIST
                GenericList<int> intList = new GenericList<int>(20);

                //OVERFILLING HIS CAPACITY
                int maxCapacity = intList.Capacity;
                for (int i = 1; i < maxCapacity * 2; i++)
                {
                    intList.Add(i);
                }

                //ACCESSING ELEMENT BY INDEX
                Console.WriteLine(intList[9]);

                //REMOVING FROM INDEX
                intList.RemoveAtIndex(9);

                //INSERTING NEW ELEMENT
                intList.InsertAtPosition(9, 100);

                Console.WriteLine(intList.FindByValue(100));

                //FIND MIN AND MAX
                Console.WriteLine(intList.Min());
                Console.WriteLine(intList.Max());

                //USING OVERRIDDEN METHOD TOSTRING()
                Console.WriteLine(intList.ToString());

                //CLEARING LIST
                intList.Clear();

                //PRINTING TOSTRING()
                Console.WriteLine(intList.ToString());






            }
            catch (Exception e)
            {

                Console.WriteLine("Error!" + e.Message);
            }

        }
    }
}
