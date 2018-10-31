﻿using System;
using System.Linq;
using System.Threading;
using WireMock.Server;

namespace WireMock.Net.StandAlone.NETCoreApp
{
    class Program
    {
        private static int sleepTime = 30000;
        private static FluentMockServer server;

        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length ; i++)
            {
                Console.WriteLine($"{i} [{args[i]}]");
            }

            Console.WriteLine("----------");
            args = args.SelectMany(a => a.Split(' ')).ToArray();

            for (int i = 0; i < args.Length ; i++)
            {
                Console.WriteLine($"{i} [{args[i]}]");
            }

            server = StandAloneApp.Start(args);

            Console.WriteLine($"{DateTime.UtcNow} Press Ctrl+C to shut down");

            System.Console.CancelKeyPress += (s,e) =>
            {
                Stop("CancelKeyPress");
            };

            System.Runtime.Loader.AssemblyLoadContext.Default.Unloading += ctx =>
            {
                Stop("AssemblyLoadContext.Default.Unloading");
            };

            while(true)
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