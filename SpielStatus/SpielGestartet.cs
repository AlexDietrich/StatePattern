using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.SpielStatus
{
    internal class SpielGestartet : IState
    {
        public override IState SpielStarten(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht erneut gestartet werden! Ist bereits gestartet.");
            return new SpielGestartet();
        }

        public override IState SpielKaufen(string spiel)
        {
            Console.WriteLine(spiel + " befindet sich bereits in deinem Besitz.");
            return new SpielGestartet();
        }

        public override IState SpielVerleihen(string user, string spiel)
        {
            Console.WriteLine(spiel + " kann nicht verliehen werden während es gestartet ist");
            return new SpielGestartet();
        }

        public override IState SpielAktualisieren(string spiel)
        {
            Console.WriteLine(spiel + " wird beendet und aktualisiert ...");
            return new SpielAktualisiert();
        }

        public override IState SpielDeinstallieren(string spiel)
        {
            Console.WriteLine(spiel + " wird beendet und deinstalliert...");
            return new SpielDeinstalliert();
        }

        public override IState SpielHerunterladen(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht erneut heruntergeladen werden.");
            return new SpielGestartet();
        }

        public override IState SpielInstallieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht erneut installiert werden");
            return new SpielGestartet();
        }
    }
}
