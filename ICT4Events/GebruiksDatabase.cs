using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events
{
    class GebruiksDatabase //communicatiepunt met de database, hierin wordt de gebruiker in de database gezet en kan die eruit worden gehaald
    {
        public string Lokatie { get; set; } //weet nog niet of dit relevant is

        public void InDatabase()
        {
            //hoe moeten de gebruikers in de database?
        }

        public Gebruiker UitDatabase()
        {
            //hoe wordt de gebruiker uit de database gehaald
            return null;
        }
    }
}
