using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal abstract class IState
    {
        //internal enum Status { SpielGekauft, SpielGestartet, SpielVerliehen, SpielAktualisiert, SpielDeistalliert, SpielHeruntergeladen, SpielInstalliert }

        public abstract IState SpielStarten(string spiel);
        public abstract IState SpielKaufen(string spiel);
        public abstract IState SpielVerleihen(string user, string spiel);
        public abstract IState SpielAktualisieren(string spiel);
        public abstract IState SpielDeinstallieren(string spiel);
        public abstract IState SpielHerunterladen(string spiel);
        public abstract IState SpielInstallieren(string spiel);
    }
}