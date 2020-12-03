using System;
using System.Threading;
using WireMock.Server;
using WireMock.Settings;

namespace WireMock.Net.StandAlone.NETCoreApp
{
    class Program
    {
        private static int sleepTime = 30000;
        private static WireMockServer server;

        static void Main(string[] args)
        {
            if (WireMockServerSettingsParser.TryParseArguments(args, out var settings))
            {
                Console.WriteLine($"Commandline arguments are invalid. WireMock.Net cannot start.");
                Environment.Exit(0);
            }

            server = WireMockServer.Start(settings);

            Console.WriteLine($"{DateTime.UtcNow} Press Ctrl+C to shut down");

            Console.CancelKeyPress += (s, e) =>
            {
                Stop("CancelKeyPress");
            };

            System.Runtime.Loader.AssemblyLoadContext.Default.Unloading += ctx =>
            {
                Stop("AssemblyLoadContext.Default.Unloading");
            };

            while (true)
            {
                Console.WriteLine($"{DateTime.UtcNow} WireMock.Net server running");
                Thread.Sleep(sleepTime);
            }
        }

        private static void Stop(string why)
        {
            Console.WriteLine($"{DateTime.UtcNow} WireMock.Net server stopping because '{why}'");
            server.Stop();
            Console.WriteLine($"{DateTime.UtcNow} WireMock.Net server stopped");
        }
    }
}