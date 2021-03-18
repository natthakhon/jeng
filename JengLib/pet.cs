using System;
using System.Collections.Generic;
using System.Text;

namespace JengLib
{
    public class pet
    {
        private int legs_number;
        private string kind;
        public pet(string kind, int legs_number)
        {
            Kind = kind;
            Legs_number = legs_number;
        }
        public string Kind
        {
            get
            {
                return this.kind;
            }
            set
            {
                if(value != "")
                {
                    kind = value;
                }
                else
                {
                    throw new Exception("The value is empty.");
                }
            }
        }
        public int Legs_number
        {
            get
            {
                return this.legs_number;
            }
            set
            {
                if (value >= 0)
                {
                    legs_number = value;
                }
                else
                {
                    throw new Exception("The value is negative.");
                }
            }
        }
        public string start_running()
        {
            return "Pet is running";
        }
        public string stop_running()
        {
            return "Pet stopped";
        }
    }
}
