using Microsoft.VisualStudio.TestTools.UnitTesting;
using MauiApp1.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Metrics;
using System.Collections.ObjectModel;

namespace MauiApp1.Modeles.Tests
{
    [TestClass()]
    public class EquipeTests
    {
        [TestMethod()]
        public void GetJoueursTest()
        {
            // Arrange - on crée les objets

            Equipe E1 = new Equipe("equipe 1");

            Joueur J1 = new Joueur("Riri");
            Joueur J2 = new Joueur("Fifi");
            Joueur J3 = new Joueur("Loulou");

            E1.AjoutPoints(J1, 5);
            E1.AjoutPoints(J3, 7);

            // Act - on lance la metthode

            ObservableCollection<string> reel = E1.GetJoueurs();

            // Assert - on verifie
            Assert.AreEqual(2,reel.Count());
        }
    }
}