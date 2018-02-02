using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSample
{
    public enum ShippingMethod 
    {
        AirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class enum1
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            Console.WriteLine(method.ToString());

            var methodID = 3;
            Console.WriteLine((ShippingMethod)methodID);

            var a = 10;
            a++;
            var b = a;
            a++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a,b ));

            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;
            //array2[0] = 0;
            Console.WriteLine(string.Format("one: {1}, two: {0}", array1[0], array2[2]));

        }
    }
}
