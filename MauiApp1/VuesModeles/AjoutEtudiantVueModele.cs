using MauiApp1.Modeles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MauiApp1.VuesModeles
{
    public class AjoutEtudiantVueModele : BaseVueModele
    {
        #region Attributs

        private string _equipe;
        private string _joueur;
        private int _points;

        #endregion

        #region Constructeurs

        public AjoutEtudiantVueModele()
        {
        }

        #endregion

        #region Getters/Setters
        public string Equipes
        {
            get
            {
                return _equipe;
            }
            set
            {
                SetProperty(ref _equipe, value);
            }
        }
        public string Joueurs
        {
            get
            {
                return _joueur;
            }
            set
            {
                SetProperty(ref _joueur, value);
            }
        }
        public int Points
        {
            get
            {
                return _points;
            }
            set
            {
                SetProperty(ref _points, value);
            }
        }

        #endregion

        #region Methodes
        public void AjoutPointsJoueur(string param1, string param2, int param3)
        {
            
            /*
             * - verifier que les objets existent (equipe et joueur)
             * 
             * 
            */
            Equipe res1 = this.TestEquipe(param1);
            Joueur res2 = this.TestJoueur(param2);
            res1.AjoutPoints(res2, param3);

        }
        public Equipe TestEquipe(string param)
        {
            Equipe resultat = null;
            foreach (Equipe uneEquipe in Equipe.CollClasse)
            {
                if (uneEquipe.Nom == param) resultat = uneEquipe;
            }
            if (resultat == null)  return new Equipe(param);

            return resultat;

        }

        public Joueur TestJoueur(string param)
        {
            Joueur resultat = null;
            foreach (Joueur unJoueur in Joueur.CollClasse)
            {
                if (unJoueur.Nom == param) resultat = unJoueur;
            }
            if (resultat == null) return new Joueur(param);

            return resultat;

        }
        #endregion
    }
}

