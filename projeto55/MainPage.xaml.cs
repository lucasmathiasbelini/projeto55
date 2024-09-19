namespace projeto55;

public partial class MainPage : ContentPage
{
	Gerenciador gerenciador;
	public MainPage()
	{
		InitializeComponent();
		gerenciador = new Gerenciador(labelpergunta,Button1,Button2,Button3,Button4,Button5,ButtonCartas);
		gerenciador.ProximaPergunta();
	}
	void button1(object sender, EventArgs args){
		gerenciador.VerificarCorreto(1);
	}
	
}

