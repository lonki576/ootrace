using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication27
{
    public class a
    {
        public void s1()
        {
            Console.WriteLine("a::s1");
            v1();


        }

        protected void v1()
        {
            Console.WriteLine("a::v1");
            s3();

        }

        public void s2()
        {
            Console.WriteLine("a::s2");
            s1();
        }

        private void s3()
        {
            Console.WriteLine("a::s3");


        }
    }
}