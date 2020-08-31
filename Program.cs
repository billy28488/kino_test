using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class parent
    {
        public virtual void method()
        {
            Console.WriteLine("This is parent method");
        }
    }
    class child : parent
    {
        public override void method()
        {
            Console.WriteLine("This child method");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            parent[] parentClasses = new parent[2];

            parentClasses[0] = new parent();
            parentClasses[1] = new child();

            foreach(parent on in parentClasses)
            {
                on.method();
            }






        }
    }
}
