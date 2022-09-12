using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Modeles
{
    public class Equipe
    {
        #region Attributs

        public static List<Equipe> CollClasse = new List<Equipe>();
        private string _nom;

        private Dictionary<Joueur, int> _dicoPoints;
        #endregion

        #region Constructeurs

        public Equipe(string nom)
        {
            Equipe.CollClasse.Add(this);
            Nom = nom;
            DicoPoints = new Dictionary<Joueur, int>();
        }


        #endregion

        #region Getters/Setters
        public string Nom { get => _nom; set => _nom = value; }
        public Dictionary<Joueur, int> DicoPoints { get => _dicoPoints; set => _dicoPoints = value; }

        #endregion

        #region Methodes

        public void AjoutPoints(Joueur param1,int param2)
        {
            // ContainsKey balaie la dictionnaire pour retrouver la cle specifiée
            if (this.DicoPoints.ContainsKey(param1))
            {
                // affecte et modifie la valeur le param2(la value) à la clé correspondante
                DicoPoints[param1] = DicoPoints[param1] + param2;
            }
            else
            {
                // Ajoute une nouvelle entrée dans le dictionnaire
                DicoPoints.Add(param1, param2);
            }
        }

        /// <summary>
        /// cette methode renvoie les joueurs ayant marqués au moins un point
        /// </summary>
        /// <returns> liste des joueurs</returns>
        public ObservableCollection<string> GetJoueurs()
        {
            // ObservableCollection fonctionne comme une liste
            ObservableCollection<string> resultat = new ObservableCollection<string>();
            foreach(KeyValuePair<Joueur,int> unJoueur in this.DicoPoints)
            {
                if (unJoueur.Value > 0)
                {
                    resultat.Add(unJoueur.Key.Nom);
                }
            }
            return resultat;
        }



        #endregion
    }
}
