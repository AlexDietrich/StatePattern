using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.SpielStatus
{
    internal class SpielDeinstalliert : IState
    {
        public override IState SpielStarten(string spiel)
        {
            Console.WriteLine(spiel + " ist nicht installiert!");
            return new SpielDeinstalliert();
        }

        public override IState SpielKaufen(string spiel)
        {
            Console.WriteLine(spiel + " ist bereits gekauft aber nicht installiert!");
            return new SpielDeinstalliert();
        }

        public override IState SpielVerleihen(string user, string spiel)
        {
            Console.WriteLine(spiel + " wurde an " + user + " verliehen!");
            return new SpielVerliehen();
        }

        public override IState SpielAktualisieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht aktualisert werden. Ist auf dem Gerät nicht installiert!");
            return new SpielDeinstalliert();
        }

        public override IState SpielDeinstallieren(string spiel)
        {
            Console.WriteLine(spiel + " ist bereits deinstalliert!");
            return new SpielDeinstalliert();
        }

        public override IState SpielHerunterladen(string spiel)
        {
            Console.WriteLine(spiel + " wird heruntergeladen ...");
            return new SpielHeruntergeladen();
        }

        public override IState SpielInstallieren(string spiel)
        {
            Console.WriteLine(spiel + " muss erst heruntergeladen werden bevor es installiert werden kann");
            return new SpielDeinstalliert();
        }
    }
}
