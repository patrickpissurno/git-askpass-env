using System;

namespace git_askpass_env
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = Environment.GetEnvironmentVariable("GIT_PASSWORD");

            if (string.IsNullOrEmpty(password))
                Environment.Exit(1);

            Console.Write(password);
        }
    }
}
