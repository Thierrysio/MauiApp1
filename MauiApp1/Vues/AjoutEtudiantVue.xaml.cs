using MauiApp1.VuesModeles;

namespace MauiApp1.Vues;

public partial class AjoutEtudiantVue : ContentPage
{
    AjoutEtudiantVueModele vueModele;
    public AjoutEtudiantVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new AjoutEtudiantVueModele();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		/* Process
		 * 1 - recuperer le texte de equipe
		 * 2 - recuperer le texte de joueur
		 * 3 - recuperer le texte de points
		 * 4 - envoyer les 3 informations dans le VM 
		 * 5 - lancer la methode ajoutPointsJoueur*/

		if (equipe.Text != "" && joueur.Text != "" && int.Parse(points.Text) < 1)
		{ 
		vueModele.AjoutPointsJoueur(equipe.Text, joueur.Text, int.Parse(points.Text));
		}
    }
}