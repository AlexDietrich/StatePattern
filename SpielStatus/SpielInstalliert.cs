using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.SpielStatus
{
    internal class SpielInstalliert : IState
    {
        public override IState SpielStarten(string spiel)
        {
            Console.WriteLine(spiel + " wird gestartet...");
            return new SpielGestartet();
        }

        public override IState SpielKaufen(string spiel)
        {
            Console.WriteLine(spiel + " wurde bereits gekauft. Kann nicht erneut gekauft werden.");
            return new SpielInstalliert();
        }

        public override IState SpielVerleihen(string user, string spiel)
        {
            Console.WriteLine(spiel + " wurde an " + user + " verliehen!");
            return new SpielVerliehen();
        }

        public override IState SpielAktualisieren(string spiel)
        {
            Console.WriteLine(spiel + " wird aktualisiert ...");
            return new SpielAktualisiert();
        }

        public override IState SpielDeinstallieren(string spiel)
        {
            Console.WriteLine(spiel + " wird deinstalliert ...");
            return new SpielDeinstalliert();
        }

        public override IState SpielHerunterladen(string spiel)
        {
            Console.WriteLine(spiel + " wurde bereits installiert. Kann nicht erneut heruntergeladen werden!");
            return new SpielInstalliert();
        }

        public override IState SpielInstallieren(string spiel)
        {
            Console.WriteLine(spiel + " ist bereits installiert!");
            return new SpielInstalliert();
        }
    }
}
