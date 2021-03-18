using System;
using System.Collections.Generic;
using System.Text;

namespace JengLib
{
    public class Computer
    {
        private string brand;
        private string model;
        private string processor;
        private string ram;
        private string harddrive;
        public Computer(string brand, string model, string processor, string ram, string harddrive)
        {
            this.brand = brand;
            this.model = model;
            this.processor = processor;
            this.ram = ram;
            this.harddrive = harddrive;
        }
        public string Brand
        {
            get
            {
                return this.brand;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
        }
        public string Ram
        {
            get
            {
                return this.ram;
            }
        }
        public string Harddrive
        {
            get
            {
                return this.harddrive;
            }
        }
        public class Desktop : Computer
        {
            private string bluray;
            public Desktop(string brand, string model, string processor,
            string ram, string harddrive, string bluray) : base(brand, model, processor,
            ram, harddrive)
            {
                this.bluray = bluray;
                
            }
            public string Bluray
            {
                get
                {
                    return this.bluray;
                }
            }
        }
        public class Laptop : Computer
        {
            private string battery;
            public Laptop(string brand, string model, string processor,
            string ram, string harddrive, string battery) : base(brand, model, processor,
            ram, harddrive)
            {
                this.battery = battery;
            }
            public string Battery
            {
                get
                {
                    return this.battery;
                }
            }
        }
    }
}
