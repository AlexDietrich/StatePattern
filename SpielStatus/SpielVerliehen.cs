using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.SpielStatus
{
    internal class SpielVerliehen : IState
    {
        public override IState SpielStarten(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht gestartet werden. Es wurde verliehen!");
            return new SpielVerliehen();
        }

        public override IState SpielKaufen(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht erneut gekauft werden. Spiel wurde verliehen!");
            return new SpielVerliehen();
        }

        public override IState SpielVerleihen(string user, string spiel)
        {
            Console.WriteLine(spiel + " kann nicht ein zweites mal verliehen werden!");
            return new SpielVerliehen();
        }

        public override IState SpielAktualisieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht aktualisiert werden. Spiel befindet sich momentan nicht in deinem Besitz!");
            return new SpielVerliehen();
        }

        public override IState SpielDeinstallieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht deinstalliert werden. Spiel befindet sich momentan nicht in deinem Besitz!");
            return new SpielVerliehen();
        }

        public override IState SpielHerunterladen(string spiel)
        {
            Console.WriteLine(spiel + " wird heruntergeladen... Spiel wechselt den Besitz zu dir. Es kann von anderen Personen nicht mehr gestartet werden.");
            return new SpielHeruntergeladen();
        }

        public override IState SpielInstallieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht installiert werden. Spiel befindet sich momentan nicht in deinem Besitz!");
            return new SpielVerliehen();
        }
    }
}
