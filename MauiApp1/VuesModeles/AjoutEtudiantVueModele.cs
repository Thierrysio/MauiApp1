using MauiApp1.Modeles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Equipe
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
        public string Joueur
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
        public void AjoutPointsJoueur(string param1,string param2, int param3)
        {
            /*
             * - verifier que les objets existent (equipe et joueur)
             * 
             * 
            */
        }
        #endregion
    }
}

