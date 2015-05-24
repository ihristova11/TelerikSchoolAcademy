namespace MobilePhoneDevice
{
    using System;
    using System.Text.RegularExpressions;
    public class Call
    {
        //Fields
        private DateTime dateAndTime;
        private string dialedPhoneNumber;
        private int duration;


        //Constructors
        public Call(DateTime dateAndTime, string dialedPhoneNumber, int Duration)
        {
            this.dateAndTime = dateAndTime;
            this.dialedPhoneNumber = dialedPhoneNumber;
            this.duration = Duration;
        }


        //Properties
        public DateTime DateAndTime
        {
            get
            {
                return new DateTime(this.dateAndTime.Ticks);
            }
            private set
            {
                if (value != null)
                {
                    this.dateAndTime = new DateTime(value.Year, value.Month, value.Day,
                        value.Hour, value.Minute, value.Second);
                }
            }
        }
        public string DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber; }
            private set
            {
                Match validationMatch = Regex.Match(value, "[^0-9 ]");

                Match emptySpacesCount = Regex.Match(value, " ");

                if (!validationMatch.Success && ((value.Length - emptySpacesCount.Groups.Count) >= 6))
                {
                    this.dialedPhoneNumber = value;
                }
                else
                {
                    this.dialedPhoneNumber = "Uknown";
                }
            }
        }
        
        public int Duration
        {
            get { return this.duration; }
        }
    }
}
