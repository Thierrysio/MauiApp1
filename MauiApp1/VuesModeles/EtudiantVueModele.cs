using MauiApp1.Modeles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.VuesModeles
{
    public class EtudiantVueModele : BaseVueModele
    {
        #region Attributs

        private ObservableCollection<Joueur> _mesJoueurs;

        #endregion

        #region Constructeurs

        public EtudiantVueModele()
        {
            Equipe E1 = new Equipe("equipe 1");

            Joueur J1 = new Joueur("Riri");
            Joueur J2 = new Joueur("Fifi");
            Joueur J3 = new Joueur("Loulou");

            E1.AjoutPoints(J1, 5);
            E1.AjoutPoints(J3, 7);

            MesJoueurs = E1.GetJoueurs();
        }

        #endregion

        #region Getters/Setters

        public ObservableCollection<Joueur> MesJoueurs
        {
            get
            {
                return _mesJoueurs;
            }
            set
            {
                SetProperty(ref _mesJoueurs, value);
            }
        }
        #endregion

        #region Methodes

        #endregion
    }
}
