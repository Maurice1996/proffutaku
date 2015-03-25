using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events
{
    private enum bestandsType { video, foto, tekst, misc }

    class Bestand
    {

        private string bestandsLokatie;
        private string bestandsNaam;
        private int bestandsGrootte;
        private string bestandsBeschrijving;
        //private List<bericht>
        //TODO: Make bericht class!!!!!
        //TODO: get en setters!!


        //TODO: Constructors:
        //Maak code om er voor te zorgen dat we op basis van de bestandstype string kunnen zien
        //Welke keuze uit de enum we nodig hebben
        public Bestand(string bestandstype, string locatie , string naam, int grootte)
        {
            bestandsLokatie = locatie;
            bestandsNaam = naam;
            bestandsGrootte = grootte;
            bestandsBeschrijving = "";
        }
        public Bestand(string bestandstype, string locatie, string naam, int grootte, string beschrijving)
        {
            bestandsLokatie = locatie;
            bestandsNaam = naam;
            bestandsGrootte = grootte;
            bestandsBeschrijving = beschrijving;
        }

        }
}
