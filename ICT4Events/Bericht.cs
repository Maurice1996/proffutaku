using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events
{
    class Bericht
    {
        string locatie;
        string inhoud;
        //TODO: Get and set
        //Missen we hier niet een paar dingen uit de database?

        public Bericht(string Loc, string Inh)
        {
            locatie = Loc;
            inhoud = Inh;
        }
    }
}
