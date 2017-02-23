using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication27
{
    public class b : a
    {
        protected void s4()
        {
            Console.WriteLine("b::s4");
            v1();

        }

        public void s5()
        {
            Console.WriteLine("b::s5");
            s3();
        }

        protected void s3()
        {
            Console.WriteLine("b::s3");

        }

        public void v2()
        {
            Console.WriteLine("b::v2");
            v1();

        }

        protected void v1()
        {
            Console.WriteLine("b::v1");
            v2();
        }
    }
}