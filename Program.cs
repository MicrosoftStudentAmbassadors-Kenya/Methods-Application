using System;

namespace Methods
{
    class Program
    {

        class Rectangle
        {
            public double length;
            public double width;
            public double GetArea()
            {

                return length * width;
            }
            public void Display()
            {
                Console.WriteLine("Length: {0}", length);
                Console.WriteLine("Width: {0}", width);
                Console.WriteLine("Area: {0}", GetArea());
            }
        }//end class Rectangle      class ExecuteRectangle
        
     static void Main(string[] args)
        {

            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
        /*  public int a;
          public int b;
          public int result;
          public int FindMax(int a, int b)
          {
              if (a> b)
              result=a;
              else
              result = b;
              return result;

          }
          static void Main(string[] args)
          {
              int a = 234;
              int b = 456;
              int ret;
              //FindMax();
              Program n = new Program();
              ret = n.FindMax(a, b);
              Console.WriteLine($" the Max Value is {ret}");
          }*/
      /* static void Main(string [] args)
        {
            GetMultiplication();
        }
       
        public double GetMultiplication(  double x,double y)
        {
          

            double w= 345;
            double p= 567;
            return y* x;
        }*/
    }

 }

        
    
