using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournoiCSharp
{
    class Tournoi
    {
        private List<Equipe>championnat = new List<Equipe>();

        public List<Equipe>Championnat
        {
            get { return new List<Equipe>(championnat);}
        }
        
        public Equipe RechercherEquipe(int EquipeId)
        {
            foreach(Equipe teams in championnat)
            {
                if(teams.Id == EquipeId)
                {
                    return teams;
                }
            }

            return null;
        } 

        public List<Equipe> RechercherEquipeComencePar(string teamName)
        {
            if(teamName == null)
            {
                throw new Exception();
            }
            List<Equipe> SelectedTeam = new List<Equipe>();
          
            foreach(Equipe teams in championnat)
            {
             if(teams.Nom.StartsWith(teamName , StringComparison.InvariantCultureIgnoreCase))
                {
                    SelectedTeam.Add(teams);
                }

            }

            return SelectedTeam;
        }

        public bool AddEquipe(Equipe newTeam)
        {
           if(newTeam == null)
            {
                throw new Exception();
            }

            Equipe e = RechercherEquipe(newTeam.Id);
            if(e == null)
            {
                championnat.Add(newTeam);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SupprEquipe(Equipe oldTeam)
        {
            if(oldTeam == null)
            {
                throw new Exception();
            }
            Equipe e = RechercherEquipe(oldTeam.Id);
            if(e != null)
            {
                championnat.Remove(e);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ModifEquipe(Equipe modifTeam) {
            if (modifTeam == null)
            {
                throw new Exception();
            }
            Equipe e = RechercherEquipe(modifTeam.Id);
            if (e != null)
            {
                e.Points = modifTeam.Points;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ListerEquipes()
        {
            foreach (Equipe teams in championnat)
            {
                Console.WriteLine(teams.DescriptionEquipe);
            } 
        }
    }
      
        
    }

