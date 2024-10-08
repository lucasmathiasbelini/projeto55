using System.Runtime.CompilerServices;

namespace projeto55
{
    public partial class MainPage : ContentPage
    {
        Gerenciador gerenciador;

        public MainPage()
        {
            InitializeComponent();
            gerenciador = new Gerenciador(labelpergunta, Button1, Button2, Button3, Button4, Button5);
            gerenciador.ProximaQuestao();
        }   

        void OnButtonResposta01ButtonClicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreta(1); // Correção aqui
        }
        void OnButtonResposta02ButtonClicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreta(2); // Correção aqui
        }
        void OnButtonResposta03ButtonClicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreta(3); // Correção aqui
        }
        void OnButtonResposta04ButtonClicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreta(4); // Correção aqui
        }
        void OnButtonResposta05ButtonClicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreta(5); // Correção aqui
        }
        private void ButtonVoltarButtonClicked(object sender, EventArgs args)
	{

		Application.Current.MainPage = new MainPage();

	}
    
    int pulou = 0;
	async void OnAjudaPulaClicked(object s, EventArgs E)
	{
		if (await DisplayAlert("PULAR QUESTÃO!", "Deseja mesmo pular a questão, depois não será possível usar esse recurso", "PULAR QUESTÃO", "CANCELAR"))
		{
			if (pulou == 2)
			{
				(s as Button).IsVisible = false;
			}

			else if (pulou == 0)
			{
				gerenciador.ProximaQuestao();
				pulou++;
				(s as Button).Text = "Pular " + 2.ToString();
			}
				else if (pulou == 1)
			{
				gerenciador.ProximaQuestao();
				pulou++;
				(s as Button).Text = "Pular " + 3.ToString();

			}
	
}
    }
    }
    }


    

