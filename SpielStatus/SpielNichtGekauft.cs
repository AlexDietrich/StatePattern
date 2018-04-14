using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.SpielStatus
{
    internal class SpielNichtGekauft : IState
    {
        public override IState SpielStarten(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht gestartet werden. Es befindet sich nicht in deinem Besitz!");
            return new SpielNichtGekauft();
        }

        public override IState SpielKaufen(string spiel)
        {
            Console.WriteLine(spiel + " erfolgreicht gekauft!");
            return new SpielGekauft();
        }

        public override IState SpielVerleihen(string user, string spiel)
        {
            Console.WriteLine(spiel + " kann nicht verliehen werden. Es befindet sich nicht in deinem Besitz!");
            return new SpielNichtGekauft();
        }

        public override IState SpielAktualisieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht aktualisiert werden. Es befindet sich nicht in deinem Besitz!");
            return new SpielNichtGekauft();
        }

        public override IState SpielDeinstallieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht deinstalliert werden. Es befindet sich nicht in deinem Besitz!");
            return new SpielNichtGekauft();
        }

        public override IState SpielHerunterladen(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht heruntergeladen werden. Es befindet sich nicht in deinem Besitz!");
            return new SpielNichtGekauft();
        }

        public override IState SpielInstallieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht installiert werden. Es befindet sich nicht in deinem Besitz!");
            return new SpielNichtGekauft();
        }
    }
}
