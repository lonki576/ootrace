using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication27
{
    public class d : b
    {
        public void s7()
        {
            Console.WriteLine("d::s7");
            s3();

        }

        public void s8()
        {
            Console.WriteLine("d::s8");
            s8();

        }

        protected void v2()
        {
            Console.WriteLine("a::v2");
            v2();

        }
    }
}