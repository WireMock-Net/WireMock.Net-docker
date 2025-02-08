using System;
using System.Threading;
using WireMock.Server;
using WireMock.Settings;

namespace StandAlone.NETCoreApp;

class Program
{
    private const int SleepTime = 30000;

    private static WireMockServer _server;

    static void Main(string[] args)
    {
        if (!WireMockServerSettingsParser.TryParseArguments(args, Environment.GetEnvironmentVariables(), out var settings))
        {
            Console.Error.WriteLine("Commandline arguments are invalid. WireMock.Net cannot start.");
            Environment.Exit(0);
        }

        _server = WireMockServer.Start(settings);

        Console.Out.WriteLine($"{DateTime.UtcNow} Press Ctrl+C to shut down");

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
            Console.Out.WriteLine($"{DateTime.UtcNow} WireMock.Net server running");
            Thread.Sleep(SleepTime);
        }
    }

    private static void Stop(string why)
    {
        Console.Out.WriteLine($"{DateTime.UtcNow} WireMock.Net server stopping because '{why}'");
        _server.Stop();
        Console.Out.WriteLine($"{DateTime.UtcNow} WireMock.Net server stopped");
    }
}