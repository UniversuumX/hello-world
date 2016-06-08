using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_1
{
    class Program
    {
        


        public static void Main()
        {
            DateTimeOffset dto = new DateTimeOffset(DateTime.Now);
            Console.WriteLine("{0} --> Unix Seconds: {1}", dto, dto.ToUnixTimeSeconds());

            DateTimeOffset localDateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(1465382055).DateTime.ToLocalTime();
            Console.WriteLine("{0} --> Date time: {1}", 1465382055, localDateTimeOffset);
            //dto = new DateTimeOffset(1969, 12, 31, 23, 59, 0, TimeSpan.Zero);
            //Console.WriteLine("{0} --> Unix Seconds: {1}", dto, dto.ToUnixTimeSeconds());

            //dto = new DateTimeOffset(1970, 1, 1, 0, 1, 0, TimeSpan.Zero);
            //Console.WriteLine("{0} --> Unix Seconds: {1}", dto, dto.ToUnixTimeSeconds());

            //Console.ReadLine();
        }
    }
}
