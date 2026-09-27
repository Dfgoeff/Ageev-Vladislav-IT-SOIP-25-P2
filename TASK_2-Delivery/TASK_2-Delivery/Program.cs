using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Delivery sd = new StandardDelivery("Local delivery");
            Delivery ed = new ExpressDelivery("Fast delivery");
            Delivery id = new InternationalDelivery("Over the world");

            // я использую версию C# 7.3 а там допустим только такой синтаксис 
            
            Delivery[] services = new Delivery[] { sd, ed, id };

            for(int i  = 0; i < services.Length; i++)
            {
                services[i].CalculatePrice(20m);
            }
            for(int i =0; i < services.Length; i++)
            {
                Console.WriteLine(services[i].ToString());
            }
        }
    }

    abstract class Delivery
    {
        protected string name;
        protected decimal price;

        public string Name{
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 20) throw new ArgumentException("Name cannot be empty or more than 20 symbols.");
                else name = value;
            }
        }
        public decimal Price{
            get => price;
        }

        public abstract void CalculatePrice(decimal basePrice);

        public override string ToString()
        {
            return ($"Delivery Serive \n Name: {name} \nPrice: {price}");
        }
    }

    class StandardDelivery : Delivery
    {
        public StandardDelivery(string name)
        {
            Name = name;
        }
        public override void CalculatePrice(decimal value){
            price = value * 1.0m;
        }
    }

    class ExpressDelivery : Delivery
    {
        public ExpressDelivery(string name)
        {
            Name = name;
        }
        public override void CalculatePrice(decimal value)
        {
            price = value * 2.5m;
        }
    }

    class InternationalDelivery : Delivery
    {
        public InternationalDelivery(string name)
        {
            Name = name;
        }
        public override void CalculatePrice(decimal value)
        {
            price = value * 4.0m;
        }
    }
}
