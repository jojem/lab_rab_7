using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jo_lr7_interface
{
    public interface ICalculate
    {
        void Plus(int plus);
        void Minus(int minus);
    }

    public interface IVisual
    {
        string Name { get; set; }
        void DrawObject();
    }

    public class Human: ICalculate, IVisual
    {
        private string FIO;
        private int Age;

        public Human(string FIO, int Age)
        {
            this.FIO = FIO;
            this.Age = Age;
        }

        public string Name
        {
            get
            {
                return FIO + " " + Age.ToString() + " years old";
            }

            set
            {
                FIO = value;
            }
        }
        
        public void DrawObject()
        {
            Console.WriteLine
                (   "     ____        \n" +
                    "   __|__|__      \n" +
                    "    (`-`)        \n" +
                    "o----|**|----o  \n" +
                    "     |__|    |   \n" +
                    "     //\\\\    |  \n" +
                    "    //  \\\\   |  \n" +
                    "  ***   ***     \n"
                );
            Console.WriteLine(Name);
        }

        public void Plus(int plus)
        {
            Age += plus;
        }

        public void Minus(int minus)
        {
            Age -= minus;
        }
    }

    public class Car: ICalculate, IVisual
    {
        private string Manufacturer;
        private string Model;
        private int Velocity;

        public Car(string Manufacturer, string Model, int Velocity)
        {
            this.Manufacturer = Manufacturer;
            this.Model = Model;
            this.Velocity = Velocity;
        }

        public string Name
        {
            get
            {
                return Manufacturer + " " + Model + " " + Velocity.ToString() + " km/h";
            }

            set
            {
                Model = value;
            }
        }

        public void DrawObject()
        {
            Console.WriteLine
                (
                    "        ____________              \n" +
                    "   ____/______|_____\\_______      \n" +
                    "   |)  | -    | -     \\    (\\    \n" +
                    "   |__   _____|________|_   _|    \n" +
                    "      (@)                (@)        \n"
                );
            Console.WriteLine(Name);
        }

        public void Minus(int minus)
        {
            Velocity -= minus;
        }

        public void Plus(int plus)
        {
            Velocity += plus;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Human hum = new Human("Mr. Charlie Chaplin", 33);
            hum.Plus(10);
            hum.Minus(1);
            hum.DrawObject();

            Car car = new Car("Hyunday", "Solaris", 250);
            car.Plus(30);
            car.Minus(53);
            car.DrawObject();

            Console.ReadKey();
        }
    }
}
