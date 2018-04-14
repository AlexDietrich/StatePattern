using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte einen Spieltitel eingeben: ");
            var name = Console.ReadLine();
            string command;
            var game = new Game(name);
            Console.Write("Gib ein Kommando für " + name + " ein: ");

            while ((command = Console.ReadLine()) != "exit")
            {
                switch (command)
                {
                    case "install":
                        game.InstallGame();
                        break;
                    case "download":
                        game.DownloadGame();
                        break;
                    case "update":
                        game.UpdateGame();
                        break;
                    case "start":
                        game.StartGame();
                        break;
                    case "share":
                        Console.Write("Gib den User ein, dem du das Spiel leihen möchtest: ");
                        game.ShareGame(Console.ReadLine());
                        break;
                    case "uninstall":
                        game.UnInstallGame();
                        break;
                    case "buy":
                        game.BuyGame();
                        break;
                }
                Console.Write("Gib ein Kommando für " + name + " ein: ");
            }
        }
    }
}
