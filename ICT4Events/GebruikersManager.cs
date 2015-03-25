using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events
{
    class GebruikersManager
    {

        public List<Gebruiker> GebruikersLijst { get; private set; } //lijst van gebruikers

        //gebruiker toevoegen
        public void GebruikerToevoegen(string gebruikerVoorNaam, 
            string gebruikerAchternaam, 
            string gebruikerEmail, 
            DateTime gebruikerGebDatum, 
            bool gebruikerBetaald,
            int gebruikerTelefoon,
            string gebruikerAdres,
            string gebruikerWoonplaats,
            Plek gebruikerPlaats,
            string gebruikerBankrekening)
        {
            Gebruiker nieuweGebruiker = new Gebruiker(gebruikerVoorNaam,
                gebruikerAchternaam,
                gebruikerEmail,
                gebruikerGebDatum,
                gebruikerBetaald,
                gebruikerTelefoon,
                gebruikerAdres,
                gebruikerWoonplaats,
                gebruikerPlaats,
                gebruikerBankrekening);
            GebruikersLijst.Add(nieuweGebruiker);
        }

        //gebruiker verwijderen
        public void GebruikerVerwijderen(Gebruiker TeVerwijderen)
        {
            GebruikersLijst.Remove(TeVerwijderen);
        }
    }
}
