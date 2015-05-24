namespace MobilePhoneDevice
{
    using System;
    public class GSMCallHistoryTest
    {
        public static void TestGSMCallHistory()
        {
            GSM myGSM = new GSM("NOKIA Lumia 820", "Finland", 400);
            Call firstCall = new Call(new DateTime(2013, 01, 31, 22, 43, 22), "0879865424", 120);
            Call secondCall = new Call(new DateTime(2013, 01, 31, 22, 43, 22), "088569863", 320);
            myGSM.AddCall(firstCall);
            myGSM.AddCall(secondCall);
            Console.WriteLine(myGSM.PrintCallHistory());
            Console.WriteLine("Total call price: " + String.Format("{0:c2}", myGSM.GetCallValue(0.37M)));
            long longestCallDuration = 0;

            Call longestCall = null;

            //Get the longest Call
            foreach (Call call in myGSM.CallHistory)
            {
                if (call.Duration > longestCallDuration)
                {
                    longestCallDuration = call.Duration;

                    longestCall = call;
                }
            }

            //Remove the longest Call
            myGSM.DeleteCall(longestCall);

            Console.WriteLine("Total Price after removing the longest Call: " +
                String.Format("{0:c2}", myGSM.GetCallValue(0.37M)));

            Console.WriteLine("\nClearing Call History.");
            myGSM.ClearCallHistory();

            Console.WriteLine("\nAfter clearing the history, call history is:");
            Console.WriteLine(myGSM.PrintCallHistory());
        }
    }
}
