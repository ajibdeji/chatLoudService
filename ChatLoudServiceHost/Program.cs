using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLoudServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (System.ServiceModel.ServiceHost host = new
                   System.ServiceModel.ServiceHost
                   (typeof(ChatLoudService.Service1)))
            {
                host.Open();
                Console.WriteLine("Host Started, Press any key to stop...");
                Console.ReadKey();
            }

        }
    }
}
