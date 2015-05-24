namespace MobilePhoneDevice
{
    using System;
    public class Display
    {
        //Fields
        private int displaySize;
        private int numberOfColors;


        //Constructors
        public Display(int displaySize)
        {
            this.displaySize = displaySize;
        }
        public Display(int displaySize, int numberOfColors)
            : this(displaySize)
        {
            this.numberOfColors = numberOfColors;
        }


        //Properties
        public int DisplaySize
        {
            get { return this.displaySize; }
            set
            {
                if (value > 0)
                {
                    this.displaySize = value;
                }
                else
                {
                    throw new Exception("Invalid information given.");
                }
            }
        }
        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if(value >= 16000)
                {
                    this.numberOfColors = value;
                }
                else
                {
                    throw new Exception("Invalid information given.");
                }
            }
        }
    }
}
