using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.SpielStatus
{
    internal class SpielHeruntergeladen : IState
    {
        public override IState SpielStarten(string spiel)
        {
            Console.WriteLine(spiel + " ist nicht installiert. Kann nicht gestartet werden!");
            return new SpielHeruntergeladen();
        }

        public override IState SpielKaufen(string spiel)
        {
            Console.WriteLine(spiel + " befindet sich bereits in deinem Besitz.");
            return new SpielHeruntergeladen();
        }

        public override IState SpielVerleihen(string user, string spiel)
        {
            Console.WriteLine(spiel + " wird an " + user + " verliehen");
            return new SpielVerliehen();
        }

        public override IState SpielAktualisieren(string spiel)
        {
            Console.WriteLine(spiel + " wird aktualisiert ...");
            return new SpielAktualisiert();
        }

        public override IState SpielDeinstallieren(string spiel)
        {
            Console.WriteLine(spiel + " ist nicht installiert. Kann nicht deinstalliert werden!");
            return new SpielHeruntergeladen();
        }

        public override IState SpielHerunterladen(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht erneut heruntergeladen werden. Ist bereits heruntergeladen");
            return new SpielHeruntergeladen();
        }

        public override IState SpielInstallieren(string spiel)
        {
            Console.WriteLine(spiel + " wird installiert ...");
            return new SpielInstalliert();
        }
    }
}
