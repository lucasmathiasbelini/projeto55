
namespace projeto55
{
   public class Gerenciador{

    List<Questao> listaQuestoes = new List<Questao>();
    List<int> listaQuestaoRespondida = new List<int>();
    Questao questaoAtual;
    public Gerenciador(Label labelPergunta, Button buttonResposta01, Button buttonResposta02, Button buttonResposta03, Button buttonResposta04, Button buttonResposta05){
        CriarQuestoes(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
    }

    void CriarQuestoes(Label labelPergunta, Button buttonResposta01, Button buttonResposta02, Button buttonResposta03, Button buttonResposta04, Button buttonResposta05){
        var q1 = new Questao();

        q1.Pergunta = "qual foi a linguagem de programação q levou o homen a lua ";
        q1.Resposta1 = "JAVA";
        q1.Resposta2 = "SQL";
        q1.Resposta3 = "python"; 
        q1.Resposta4 = "assembly";
        q1.Resposta5 = "mais ele nem foi a lua mano";

        q1.RespostaCerta = 4;
        q1.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q1);

        var q2 = new Questao();
        q2.Pergunta = "Qual a linguagem de programação foi criada em 1998";
        q2.Resposta1 = "C#";
        q2.Resposta2 = "HTML";
        q2.Resposta3 = "kotlin";
        q2.Resposta4 = "C++";
        q2.Resposta5 = "C";

    }
         public void ProximaQuestao(){
        var numRandom = Random.Shared.Next(0, listaQuestoes.Count- 1);

        while(listaQuestaoRespondida.Contains(numRandom)){
            numRandom = Random.Shared.Next(0,listaQuestoes.Count - 1);
        } 

        listaQuestaoRespondida.Add(numRandom);
        questaoAtual = listaQuestoes[numRandom];
        questaoAtual.Desenhar();
    }

    public async void VerificaCorreta(int rr){
        if(questaoAtual.VerificaResposta(rr)){
            await Task.Delay(1000);
            ProximaQuestao();
        }
    }
}
}

      