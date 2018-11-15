using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournoiCSharp
{
    class Equipe
    {
        private int id;
        private Coach coach;
        private string nom;
        private string nacionalite;
        private int point = 0 ;
        private List<MembreEquipe> team = new List<MembreEquipe>();

        public Equipe(Coach newCoach , string newNom , string newNacionalite)
        {
            coach = newCoach;
            nom = newNom;
            nacionalite = newNacionalite;
           
        }
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        public Coach Coach
        {
            set { coach = value; }
            get { return coach; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Nacionalite
        {
            get { return nacionalite; }
            private set { nacionalite = value; }
        }
        public int Points
        {
            get { return point; }
            set { point = value; }
        }
        public List<MembreEquipe> Team
        {
            get { return new List<MembreEquipe>(team); }
        }
        

        public List<MembreEquipe> RechercherJoueurComencePar(string joueurNom)
        {
            if(joueurNom == null)
            {
                throw new Exception();
            }
            List<MembreEquipe> listPlayer = new List<MembreEquipe>();
            foreach (Joueur player in Team)
            {
                if (player.Nom.StartsWith(joueurNom, StringComparison.InvariantCultureIgnoreCase))
                {
                    listPlayer.Add(player);
                }

            }

            return listPlayer;


        }

        public Joueur RechercherJoueur(int joueurId)
        {
            foreach(Joueur player in team)
            {
                if (player.Id == joueurId)
                {
                    return player;
                }
            }

            return null;

        }

        public bool AddJoueur(Joueur joueurAdd)
        {
           if(joueurAdd == null)
            {
                throw new Exception();
            }

            Joueur j = RechercherJoueur(joueurAdd.Id);
            if(j == null)
            {
                team.Add(joueurAdd);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool SupprJoueur(Joueur joueurSuppr)
        {
            if(joueurSuppr == null)
            {
                throw new Exception();
            }

            Joueur j = RechercherJoueur(joueurSuppr.Id);
            if(j != null)
            {
                team.Remove(j);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool ModifJoueur(Joueur joueurModif)
        {
            if (joueurModif == null){
                throw new Exception();
            }
            Joueur j = RechercherJoueur(joueurModif.Id);
            if(j != null)
            {
                j.NumeroJoueur = joueurModif.NumeroJoueur;
                j.Position = joueurModif.Position;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ListerEquipe()
        {
            foreach (Joueur p in team)
            {
                Console.WriteLine(p.FicheDescriptive);
            }
        }

        public string DescriptionEquipe
        {
            get { return string.Format("{0} , {1} , {2}", nom, nacionalite , coach); }
        }

    }
}
