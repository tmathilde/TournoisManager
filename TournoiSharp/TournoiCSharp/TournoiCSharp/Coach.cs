using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournoiCSharp
{
    class Coach:MembreEquipe
    {
        private int quantiteDeVitoire;

        public Coach(int newId, string newNom, string newPrenom, string newNacionalite, DateTime newDateNasc , int newQuantiteDeVitoire) : base(newId, newNom, newPrenom, newNacionalite, newDateNasc)
        {
            quantiteDeVitoire = newQuantiteDeVitoire;
        }

        public int QuantiteDeVitoire
        {
            get { return quantiteDeVitoire; }
            set { QuantiteDeVitoire = value; }
        }
    }
}
