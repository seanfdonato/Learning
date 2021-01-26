using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var context = new masterContext();
            var baseconfig = context.BaseConfigs.Where(x => x.Id == 1)
                .Include(args=> args.MailConfigs)
                .Include(args => args.WebServiceConfigs)
                .FirstOrDefault();
        }
    }
}
