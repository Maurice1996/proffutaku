using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events
{
    class Gebruiker
    {
        //properties
        public string GebruikerNaam { get; private set; } // bestaat uit voor en achtenaam
        public string GebruikerEmail { get; private set; }
        public DateTime GebruikerGebDatum { get; private set; }
        public bool GebruikerBetaald { get; set; } //geen private set, kan worden aangepast door toegangscontrole
        public int GebruikerTelefoon { get; private set; } // telefoon toegevoegd
        public string GebruikerAdres { get; private set; } // adres toegevoegd
        public string GebruikerWoonplaats { get; private set; } // woonplaats toegevoegd
        public Plek GebruikerPlaats { get; private set; } //slaapplaats toegevoegd
        public string GebruikerBankrekening { get; private set;} // bankrekening toegevoegd


        //constructor
        public Gebruiker(string gebruikerVoorNaam, 
            string gebruikerAchternaam, 
            string gebruikerEmail, 
            DateTime gebruikerGebDatum, 
            bool gebruikerBetaald,
            int gebruikerTelefoon,
            string gebruikerAdres,
            string gebruikerWoonplaats,
            Plek gebruikerPlaats,
            string gebruikerBankrekening
            )
        {
            this.GebruikerNaam = gebruikerVoorNaam + " " + gebruikerAchternaam; // Voor + achternaam wordt naam
            this.GebruikerEmail = gebruikerEmail;
            this.GebruikerGebDatum = gebruikerGebDatum;
            this.GebruikerBetaald = gebruikerBetaald;
            this.GebruikerTelefoon = gebruikerTelefoon;
            this.GebruikerAdres = gebruikerAdres;
            this.GebruikerWoonplaats = gebruikerWoonplaats;
            this.GebruikerPlaats = gebruikerPlaats;
            this.GebruikerBankrekening = gebruikerBankrekening;
        }
    }
}
