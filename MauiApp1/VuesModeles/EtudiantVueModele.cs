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
