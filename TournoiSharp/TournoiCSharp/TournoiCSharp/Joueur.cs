using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournoiCSharp
{
    class Joueur:MembreEquipe
    {
        public enum Fonction { Gardien ,  Defenseur , Milieu , Attaquant }

        private Fonction position;
        private int numeroJoueur;
        
        public Joueur(int newId , string newNom , string newPrenom , string newNacionalite , DateTime newDateNasc , Fonction newPosition , int newNumeroJoueur):base(newId , newNom , newPrenom , newNacionalite , newDateNasc)
        {
           position = newPosition;
            numeroJoueur = newNumeroJoueur;

        }

        public Fonction Position
        {
            set { position = value; }
            get { return position; }
        }

        public int NumeroJoueur
        {
            set { numeroJoueur = value; }
            get { return numeroJoueur; }
        }
        public override string FicheDescriptive
        {
            get { return string.Format("{0} ,{1}", base.FicheDescriptive, Position); }
        }
    }
}
