using System;
using Microsoft.AspNetCore.Authentication;
using NLog;

class Program
{
    static void Main()
    {
        // Configure NLog
        var config = new NLog.Config.LoggingConfiguration();

        var logfile = new NLog.Targets.FileTarget("logfile1") { FileName = "logfile1.txt" };
        var logconsole = new NLog.Targets.ConsoleTarget("logconsole");

        config.AddRule(LogLevel.Debug, LogLevel.Fatal, logconsole); // for console output
        config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);   // for file output

        LogManager.Configuration = config;

        AuthenticationService authenticationService = new AuthenticationService();

        // Show a welcome message
        Console.WriteLine("Welcome to the Authentication System!");
        ShowMenu(authenticationService);
    }

    static void ShowMenu(AuthenticationService authService)
    {
        bool isAuthenticated = false;

        while (!isAuthenticated)
        {
            // Displaying the menu
            Console.WriteLine("\nPlease choose an option:");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Perform login action
                    isAuthenticated = PerformLogin(authService);
                    break;
                case "2":
                    Console.WriteLine("Exiting the system...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }

    static bool PerformLogin(AuthenticationService authService)
    {
        Console.Write("\nEnter Username: ");
        string username = Console.ReadLine();

        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        return authService.Login(username, password);
    }
}
