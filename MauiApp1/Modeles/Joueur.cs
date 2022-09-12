using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Modeles
{
    public class Joueur
    {
        #region Attributs

        public static List<Joueur> CollClasse = new List<Joueur>();
        private string _nom;
        #endregion

        #region Constructeurs

        public Joueur(string nom)
        {
            Joueur.CollClasse.Add(this);

            Nom = nom;
        }


        #endregion

        #region Getters/Setters
        public string Nom { get => _nom; set => _nom = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
