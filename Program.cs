using System;
using System.IO;
using System.Reflection;
using System.Threading;
using OnitamaTestClient.Models.Enums;
using RemoteBotClient;

namespace OnitamaTestClient
{
    class Program {
        private static readonly string ApiKey = File.ReadAllText(Path.Combine(
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
            "apikey.txt"
        )).Trim();

        static void Main(string[] args)
        {
            var botInterface = RemoteBotClientInitializer.Init(ApiKey, forceLocal: false);

            var testbot = new TestBot(botInterface);
            testbot.Run();
        }
    }
}
