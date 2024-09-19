
namespace projeto55
{
    public class Gerenciador
    {
        List<Questao> ListaQuestoes = new List<Questao>();
        List<int> ListaQuestoesRespondidas = new List<int>();
        Questao QuestaoAtual;
        public Gerenciador(Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
        {
            CriarQuestoes(labelpergunta, button1, button2, button3, button4, button5);
        }
      void CriarQuestoes(Label labelPergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
{
    var Q1 = new Questao();
    Q1.Pergunta = "Qual é a linguagem de programação que levou o homem à lua?";
    Q1.Resposta01 = "C#";
    Q1.Resposta02 = "Java";
    Q1.Resposta03 = "Python";
    Q1.Resposta04 = "C++";
    Q1.Resposta05 = "Assembly";
    Q1.RespostaCorreta = 5;
    Q1.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
    ListaQuestoes.Add(Q1);
}
 public void ProximaQuestao()
        {
            var numRandomico = Random.Shared.Next(0, ListaQuestoesRespondidas.Count);
            while (ListaQuestoesRespondidas.Contains(numRandomico))
                numRandomico = Random.Shared.Next(0, ListaQuestoesRespondidas.Count - 1);

            ListaQuestoesRespondidas.Add(numRandomico);
            QuestaoAtual = ListaQuestoes[numRandomico];
            QuestaoAtual.Desenhar();
        }
        public async void VerfiicaCorreto(int RespostaSelecionada)
        {
            if (QuestaoAtual.VerificaResposta(RespostaSelecionada))
            {
                await Task.Delay(1000);
                ProximaQuestao();
            }
        }
    }
}
      