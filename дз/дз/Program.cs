using System;

namespace animal
{
    class Appliance
    {
        private string Brand;
        protected int Power;
        public bool Ison;

        public string getBrand
        {
            get { return Brand; }
            set { Brand = value; }
        }

        public int getPower
        {
            get { return Power; }
            set { Power = value; }
            
        }

        public void TurnOff()
        {
            Ison = false;
            Console.WriteLine($"{Brand} is turned off");
            
        }

        public void TurnOn()
        {
            Ison = true;
            Console.WriteLine($"{Brand} is turned on");
        }
    }

    class Washmexanik : Appliance
    {
        public Washmexanik()
        {
            getBrand = "Lg";
            getPower = 30;
            Ison = false;
        }

        public Washmexanik(string brand, int power)
        {
            getBrand = brand;
            getPower = power;
            Ison = false;
        }
    }

    class Retifigator : Appliance
    {
        public Retifigator()
        {
            getBrand = "Samsung";
            getPower = 20;
            Ison = false;
        }

        public Retifigator(string brand, int power)
        {
            getBrand = brand;
            getPower = power;
            Ison = false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Washmexanik washmexanik = new Washmexanik();
            Washmexanik washmexanik1 = new Washmexanik("Samsung",45);
            Retifigator retifigator = new Retifigator();
            Retifigator retifigator2 = new Retifigator("Samsung", 20);
            Console.WriteLine(washmexanik.getPower);
            Console.WriteLine(washmexanik1.getPower);
            Console.WriteLine(retifigator.getPower);
            Console.WriteLine(retifigator2.getPower);
        }
    }
}