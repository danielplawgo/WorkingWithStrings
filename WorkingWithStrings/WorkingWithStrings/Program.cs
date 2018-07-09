using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var applicationName = ConfigurationManager.AppSettings[SettingsNames.ApplicationName];

            var message = string.Format(ApplicationResources.HelloMessage, applicationName);

            Console.WriteLine(message);
        }
    }
}
