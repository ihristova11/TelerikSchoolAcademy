namespace MobilePhoneDevice
{
    using System;
    public class Battery
    {
        //Task 3 - Enumeration
        public enum BatteryType
        {
            LiIon, NiMH, NiCd
        }


        //Fields
        private string batteryModel;
        private int batteryHoursIdle;
        private int batteryHoursTalk;
        public BatteryType batteryType;
        

        //Constructors
        public Battery(string batteryModel)
        {
            this.batteryModel = batteryModel;
        }
        public Battery(string batteryModel, int batteryHoursIdle)
            : this(batteryModel)
        {
            this.batteryHoursIdle = batteryHoursIdle;
        }
        public Battery(string batteryModel, int batteryHoursIdle, int batteryHoursTalk)
            : this(batteryModel, batteryHoursIdle)
        {
            this.batteryHoursTalk = batteryHoursTalk;
        }
        


        //Properties
        public string BattteryModel
        {
            get { return this.batteryModel; }
            set
            {
                if(value.Length > 3)
                {
                    this.batteryModel = value;
                }
                else
                {
                    throw new FormatException("Invalid battery type.");
                }
            }
        }
        public int BatteryHoursIdle
        {
            get { return this.batteryHoursIdle; }
            set
            {
                if (value > 0)
                {
                    this.batteryHoursIdle = value;
                }
                else
                {
                    throw new Exception("Inavlid information given.");
                }
            }
        }
        public int BatteryHoursTalk
        {
            get { return this.batteryHoursTalk; }
            set
            {
                if(value < this.batteryHoursIdle)
                {
                    this.batteryHoursTalk = value;
                }
                else
                {
                    throw new Exception("Invalid information given.");
                }
            }
        }
    }
}
