﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.SpielStatus
{
    internal class SpielGekauft : IState
    {
        public override IState SpielStarten(string spiel)
        {
            Console.WriteLine(spiel + " muss heruntergeladen und installiert werden bevor es gestartet werden kann!");
            return new SpielGekauft();
        }

        public override IState SpielKaufen(string spiel)
        {
            Console.WriteLine(spiel + " wurde bereits gekauft. Kann nicht erneut gekauft werden.");
            return new SpielGekauft();
        }

        public override IState SpielVerleihen(string user, string spiel)
        {
            Console.WriteLine(spiel + " wurde an " + user + " verliehen!");
            return new SpielVerliehen();
        }

        public override IState SpielAktualisieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht aktualisert werden. Ist nicht installiert!");
            return new SpielGekauft();
        }

        public override IState SpielDeinstallieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht deinstalliert werden. Ist nicht installiert.");
            return new SpielInstalliert();
        }

        public override IState SpielHerunterladen(string spiel)
        {
            Console.WriteLine(spiel + " wird heruntergeladen ...");
            return new SpielHeruntergeladen();
        }

        public override IState SpielInstallieren(string spiel)
        {
            Console.WriteLine(spiel + " muss erst heruntergeladen werden bevor es installiert werden kann!");
            return new SpielGekauft();
        }
    }
}
