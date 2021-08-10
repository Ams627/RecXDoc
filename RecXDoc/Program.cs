using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace RecXDoc
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var arr = Enumerable.Range(1, 10);
                var e = new XElement("a");
                var marker = e;
                for (int i = 0; i < arr.Count(); i++)
                {
                    var newElement = new XElement("a", new XAttribute("f", "g"));
                    marker.Add(newElement);
                    marker = newElement;
                }
                Console.WriteLine();

            }
            catch (Exception ex)
            {
                var fullname = System.Reflection.Assembly.GetEntryAssembly().Location;
                var progname = Path.GetFileNameWithoutExtension(fullname);
                Console.Error.WriteLine($"{progname} Error: {ex.Message}");
            }

        }
    }
}
