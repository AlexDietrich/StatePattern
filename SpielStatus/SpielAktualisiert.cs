using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.SpielStatus
{
    internal class SpielAktualisiert : IState
    {
        public override IState SpielStarten(string spiel)
        {
            Console.WriteLine(spiel + " wird gestartet...");
            return new SpielGestartet();
        }

        public override IState SpielKaufen(string spiel)
        {
            Console.WriteLine(spiel + " wurde bereits gekauft! Es ist installiert und aktualisiert!");
            return new SpielAktualisiert();
        }

        public override IState SpielVerleihen(string user, string spiel)
        {
            Console.WriteLine(spiel + " wird an " + user + " verliehen!");
            return new SpielVerliehen();
        }

        public override IState SpielAktualisieren(string spiel)
        {
            Console.WriteLine(spiel + " ist bereits aktualisiert!");
            return new SpielAktualisiert();
        }

        public override IState SpielDeinstallieren(string spiel)
        {
            Console.WriteLine(spiel + " wird deinstalliert!");
            return new SpielDeinstalliert();
        }

        public override IState SpielHerunterladen(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht erneut heruntergeladen werden!");
            return new SpielAktualisiert();
        }

        public override IState SpielInstallieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht erneut installiert werden!");
            return new SpielAktualisiert();
        }
    }
}
