public class Gerenciador{
list <questao>listaQuestoes = new list<questao();
list <int> listaQuestoesRespondida = new list<int>();

Questao questaoCorrente;

void criarQuestoes(labelPergunta, buResp02,buResp03,buResp04,buResp05){
    var q1 = new Quest();
    q1.Pergunta = "QUANTO É 2 + 2"
    q1.Pergunta01 = "1"
    q1.Pergunta02= "13"
    q1.Pergunta03 = "21"
    q1.Pergunta04 = "11"
    q1.Pergunta05 = "2"
configurarDesenho(label Pergunta,buResp02, buResp03,buResp04,buResp05);
listaQuestoes.Add(q1);
}
public Gerenciador(label labelpergunta, Button buResp...,Button buResp05){
criarQuestoes(labelPergunta, buResp02,buResp03,buResp04,buResp05 )
}

public class Gerenciador{
    public numberRandom = Random.shred.next(0,listaQuestoes.count - 1)
    while(listaQuestoesContais(numberRandom))
    numberRandom = Random.Saared.next(0,listaQuestoes.count -1);
    listaQuestoesRespondida.add(numberRandom);
    Questao Corrente = ListaQuestoes[numberRandom]
}
public async void VerificarCorreto(int rr)
{
    if(questaoCorrente.VerificaResposta(rr)){
        await Task.Deay(1000);
        ProximaQuestao();
    }
}


}