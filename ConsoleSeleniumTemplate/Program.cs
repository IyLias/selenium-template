using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSeleniumTemplate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Crawler crawler = new Crawler();
            crawler.doWork();
        }
    }
}
