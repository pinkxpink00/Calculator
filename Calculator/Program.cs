using System;

namespace Calculator
{
    interface IMathOperation
    {
        public void Plus();
        public void Minus();
        public void Del();
        public void Umn();
        public int GetResult();
    }
    class Program 
    {
        static void Main()
        {
            string defaultMessage = "Invalid data input";
            
            
            Console.WriteLine("Input first num...");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second num...");
            var num2 = Convert.ToInt32(Console.ReadLine());
            
            DomainClass calc = new DomainClass(num1,num2);

            int choise = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose mathOp");
            
            switch (choise)
            {
                case 1:
                    calc.Plus();
                    Console.WriteLine(calc.GetResult());
                    break;
                case 2:
                    calc.Minus();
                    Console.WriteLine(calc.GetResult());
                    break;
                case 3:
                    calc.Del();
                    Console.WriteLine(calc.GetResult());
                    break;
                case 4:
                    calc.Umn();
                    Console.WriteLine(calc.GetResult());
                    break;
                default:
                    Console.WriteLine(defaultMessage);
                    break;
                    
            }
        }
    }

    class DomainClass : IMathOperation
    {
        private int x { get; set; }
        private int y { get; set; }

        private int res { get; set; }

        public DomainClass(int x,int y)
        {
            
            this.x = x;
            this.y = y;
        }

        public int GetResult()
        {
            return res;
        }
        public void Plus()
        {
            res = x + y;
        }

        public void Minus()
        {
            res = x - y;
        }

        public void Del()
        {
            res = x / y;
        }

        public void Umn()
        {
            res = x * y;
        }
    }
}

