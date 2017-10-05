using System;
using Nancy;
using Nancy.Hosting.Self;

namespace Nancy_Sample
{
    class Program
    {
        private readonly NancyHost _nancy;

        public Program()
        {
            var uri = new Uri("http://localhost:7880");
            var hostConfigs = new HostConfiguration { UrlReservations = { CreateAutomatically = true } };
            _nancy = new NancyHost(uri, new DefaultNancyBootstrapper(), hostConfigs);
        }

        private void Start()
        {
            _nancy.Start();
            Console.WriteLine($"Started listenig address {"http://localhost:7880"}");
            Console.ReadKey();
            _nancy.Stop();
        }

        static void Main(string[] args)
        {
            var p = new Program();
            p.Start();
        }
    }
}
