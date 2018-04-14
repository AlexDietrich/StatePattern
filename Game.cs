using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.SpielStatus;

namespace StatePattern
{
    internal class Game
    {
        private IState _state = new SpielNichtGekauft();
        private readonly string _name;

        public Game(string name)
        {
            this._name = name;
        }

        public void StartGame()
        {
            _state = _state.SpielStarten(_name);
        }

        public void BuyGame()
        {
            _state = _state.SpielKaufen(_name);
        }

        public void InstallGame()
        {
            _state = _state.SpielInstallieren(_name);
        }

        public void ShareGame(string user)
        {
            _state = _state.SpielVerleihen(user, _name);
        }

        public void UnInstallGame()
        {
            _state = _state.SpielDeinstallieren(_name);
        }

        public void UpdateGame()
        {
            _state = _state.SpielAktualisieren(_name);
        }

        public void DownloadGame()
        {
            _state = _state.SpielHerunterladen(_name);
        }

    }
}
