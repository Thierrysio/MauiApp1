using MauiApp1.VuesModeles;

namespace MauiApp1.Vues;

public partial class EtudiantVue : ContentPage
{
	EtudiantVueModele vueModele;
	public EtudiantVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new EtudiantVueModele(); ;
	}
}