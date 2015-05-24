namespace MobilePhoneDevice
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class GSM
    {
        //Fields
        private string mobileModel;
        private string mobileManufacturer;
        private decimal mobilePrice;
        private string mobileOwner;
        private static GSM iPhone4s = new GSM("IPhone4S", "Apple"); //task 6
        private List<Call> callHistory;


        //Constructors
        public GSM(string mobileModel, string mobileManufacturer)
        {
            this.mobileModel = mobileModel;
            this.mobileManufacturer = mobileManufacturer;
        }
        public GSM(string mobileModel, string mobileManufacturer, decimal mobilePrice)
            : this (mobileModel, mobileManufacturer)
        {
            this.mobilePrice = mobilePrice;
        }
        public GSM(string mobileModel, string mobileManufacturer, decimal mobilePrice, string mobileOwner)
            : this(mobileModel, mobileManufacturer, mobilePrice)
        {
            this.mobileOwner = "";
        }


        //Methods
        public override string ToString()//ToString() method - overrided
        {
            return base.ToString();
        }
        public static void PrintIPhone4SInfo()
        {

            Console.WriteLine("---------Mobile Phone Device---------");
            Console.WriteLine("Mobile Model: {0}", GSM.IPhone4S.MobileModel);
            Console.WriteLine("Mobile Manufacturer: {0}", GSM.IPhone4S.MobileManufacturer);
        }


        //Properties - task 5
        public string MobileModel
        {
            get { return this.mobileModel; }
            set 
            {
                if (value.Length >= 3)
                {
                    this.mobileModel = value;
                }
                else
                {
                    throw new FormatException("Invalid mobile model name. It must be at least 3 symbols long.");
                }
            }
        }
        public string MobileManufacturer
        {
            get { return this.mobileManufacturer; }
            set
            {
                if (value.Length >= 3)
                {
                    this.mobileManufacturer = mobileManufacturer;
                }
                else 
                {
                    throw new FormatException("Invalid mobile manufacturer name. It must be at least 3 symbols long.");
                }
            }
        }
        public decimal MobilePrice
        {
            get { return this.mobilePrice; }
            set 
            {
                if (value > 0)
                {
                    this.mobilePrice = value;
                }
                else
                {
                    throw new FormatException("Invalid mobile price.");
                }
            }
        }
        public string MobileOwner
        {
            get { return this.mobileOwner; }
            set
            {
                if (value.Length > 4)
                {
                    this.mobileOwner = value;
                }
                else
                {
                    throw new FormatException("Invalid mobile owner name.");
                }
            }
        }
        public static GSM IPhone4S //Static property for IPhone4S - task 6
        {
            get { return iPhone4s; }
        }

        //Property for Call.cs
        public List<Call> CallHistory
        {

            get { return callHistory; }

            set { callHistory = value; }

        }


        //Methods for Task 10
        public void AddCall(Call newCall)
        {
            this.CallHistory = new List<Call>();
            this.CallHistory.Add(newCall);
        }
        public void DeleteCall(Call myCall)
        {
            this.CallHistory.Remove(myCall);
        }
        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }
        public string PrintCallHistory()
        {
            StringBuilder resultString = new StringBuilder();

            if (this.callHistory == null || this.callHistory.Count == 0)
            {
                return "Empty Call History.";
            }


            resultString.Append("Call History:\n");

            foreach (Call call in this.callHistory)
            {
                resultString.Append(call.ToString()).Append("\n");
            }

            return resultString.ToString();
        }
        public decimal GetCallValue(decimal price)
        {
            decimal totalCallPrice = 0.0M;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalCallPrice += (this.callHistory[i].Duration / 60.0M) * price;
            }

            return totalCallPrice;
        }

        public decimal CalculateTotalPriceOfCalls(decimal pricePerMin)
        {
            decimal price = 0.0m;

            foreach (var call in CallHistory)
            {
                price = price + call.Duration * pricePerMin / 60;
            }
            return price;
        }
    }
}
