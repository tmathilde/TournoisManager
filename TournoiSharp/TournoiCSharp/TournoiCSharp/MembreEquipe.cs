using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournoiCSharp
{
    abstract class MembreEquipe
    {
        private int id;
        private string nom;
        private string prenom;
        private string nacionalite;
        private DateTime dateNasc;

        public MembreEquipe(int newId , string newNom , string newPrenom , string newNacionalite , DateTime newDateNasc)
        {
            id = newId;
            nom = newNom;
            prenom = newPrenom;
            nacionalite = newNacionalite;
            dateNasc = newDateNasc;

        }

        public int Id
        {
            private set { id = value; }
            get { return id; }
        }
        public string Nom
        {
            private set { nom = value; }
            get { return nom; }
        }
        public string Prenom
        {
            private set { prenom = value; }
            get { return prenom; }
        }
       public string Nacionalite
        {
            private set { nacionalite = value; }
            get { return nacionalite; }
        }
        public string DateNasc
        {
            get { return dateNasc.ToString("yyyy/MM/dd"); }
            private set { dateNasc = DateTime.ParseExact(value, "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture); }
        }

        public virtual string FicheDescriptive
        {
            get { return string.Format("{0} , {1} ,{2} , {3} , {4}", id , nom , prenom , nacionalite , DateNasc); }
        }

    }
}
