
namespace projeto55
{
   public class Gerenciador{

    List<Questao> listaQuestoes = new List<Questao>();
    List<int> listaQuestaoRespondida = new List<int>();
     public int Pontuacao { get; private set; }
    Questao QuestaoAtual;
    public Gerenciador(Label labelPergunta, Button buttonResposta01, Button buttonResposta02, Button buttonResposta03, Button buttonResposta04, Button buttonResposta05){
        CriarQuestoes(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
    }
    
        void AdicionaPontuacao(int n)
        {
            if (n == 1)
                Pontuacao = 1000;
            else if (n == 2)
                Pontuacao = 2000;
            else if (n == 3)
                Pontuacao = 5000;
            else if (n == 4)
                Pontuacao = 10000;
            else if (n == 5)
                Pontuacao = 20000;
            else if (n == 6)
                Pontuacao = 50000;
            else if (n == 7)
                Pontuacao = 10000;
            else if (n == 8)
                Pontuacao = 20000;
            else if (n == 9)
                Pontuacao = 500000;
            else if (n == 10)
                Pontuacao = 1000000;
        }
        public Questao GetQuestaoAtual()
        {
            return QuestaoAtual;
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

        var q3 = new Questao();
        q3.Pergunta = "O que é DOTNET.newMAUI";
        q3.Resposta1 = "framework";
        q3.Resposta2 = "linguagem de programação";
        q3.Resposta3 = "nenhum desses";
        q3.Resposta4 = "Biblioteca";
        q3.Resposta5 = "IDE";

        q3.RespostaCerta = 1;
        q3.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q3);

        var q4 = new Questao();
        q4.Pergunta = "Quando o foi o vazamento de dados da microsoft";
        q4.Resposta1 = "2024";
        q4.Resposta2 = "2000";
        q4.Resposta3 = "2006";
        q4.Resposta4 = "Saturno";
        q4.Resposta5 = "Netuno";

        q4.RespostaCerta = 3;
        q4.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q4);

        var q5 = new Questao();
        q5.Pergunta = "Quem foi arthur mamãe falei";
        q5.Resposta1 = "Machado de Assis";
        q5.Resposta2 = "1 poeta";
        q5.Resposta3 = "youtuber";
        q5.Resposta4 = "cara aleatorio";
        q5.Resposta5 = "Graciliano Ramos";

        q5.RespostaCerta = 2;
        q5.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q5);

        var q6 = new Questao();
        q6.Pergunta = "Quantos continentes existem?";
        q6.Resposta1 = "5";
        q6.Resposta2 = "6";
        q6.Resposta3 = "7";
        q6.Resposta4 = "4";
        q6.Resposta5 = "8";

        q6.RespostaCerta = 3;
        q6.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q6);

        var q7 = new Questao();
        q7.Pergunta = "Qual é a fórmula da água?";
        q7.Resposta1 = "H2O";
        q7.Resposta2 = "O2";
        q7.Resposta3 = "CO2";
        q7.Resposta4 = "NaCl";
        q7.Resposta5 = "C6H12O6";

        q7.RespostaCerta = 1;
        q7.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q7);

        var q8 = new Questao();
        q8.Pergunta = "Qual é a língua mais falada do mundo?";
        q8.Resposta1 = "Inglês";
        q8.Resposta2 = "Mandarim";
        q8.Resposta3 = "Espanhol";
        q8.Resposta4 = "Francês";
        q8.Resposta5 = "Árabe";

        q8.RespostaCerta = 2;
        q8.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q8);

        var q9 = new Questao();
        q9.Pergunta = "Quem pintou a Mona Lisa?";
        q9.Resposta1 = "Vincent van Gogh";
        q9.Resposta2 = "Leonardo da Vinci";
        q9.Resposta3 = "Pablo Picasso";
        q9.Resposta4 = "Claude Monet";
        q9.Resposta5 = "Michelangelo";

        q9.RespostaCerta = 2;
        q9.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q9);

        var q10 = new Questao();
        q10.Pergunta = "O que é if e else?";
        q10.Resposta1 = "se e se não";
        q10.Resposta2 = "se não e se sim";
        q10.Resposta3 = "loop laço de repetição";
        q10.Resposta4 = "while";
        q10.Resposta5 = "Oceano Antártico";

        q10.RespostaCerta = 1;
        q10.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q10);

        var q11 = new Questao();
        q11.Pergunta = "Qual é o comando usado para criar tabela e banco de dados no SQL?";
        q11.Resposta1 = "CREATE TABLE CLIENTE()";
        q11.Resposta2 = "DROP CLIENTE";
        q11.Resposta3 = "DELETE FROM CLIENTE";
        q11.Resposta4 = "CREATE VIEW CLIENTE";
        q11.Resposta5 = "AS CLIENTE";

        q11.RespostaCerta = 1;
        q11.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q11);

        var q12 = new Questao();
        q12.Pergunta = "O que significa a sgla SGBD";
        q12.Resposta1 = "Sistema de gerenciamento de dados";
        q12.Resposta2 = "Sistema de segurança de dados";
        q12.Resposta3 = "Sistema de gerenciamento e monitoramento";
        q12.Resposta4 = "Sistema sigilo de dados";
        q12.Resposta5 = "nenhuma delas";

        q12.RespostaCerta = 1;
        q12.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q12);

        var q13 = new Questao();
        q13.Pergunta = "O que é back-end";
        q13.Resposta1 = "cara que cuida de baixo dos panos de 1 site";
        q13.Resposta2 = "cara que cuida da interface do site";
        q13.Resposta3 = "é o cara que cuida dos dados";
        q13.Resposta4 = "é o patrão";
        q13.Resposta5 = "é 1 CLT aí";

        q13.RespostaCerta = 1;
        q13.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q13);

        var q14 = new Questao();
        q14.Pergunta = "Qual é a 1 linguagem de programação criada";
        q14.Resposta1 = "Fortran";
        q14.Resposta2 = "Binario";
        q14.Resposta3 = "JAVA";
        q14.Resposta4 = "HTML";
        q14.Resposta5 = "CSS";

        q14.RespostaCerta = 1;
        q14.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q14);

        var q15 = new Questao();
        q15.Pergunta = "Quem é o criador do COBOL linguagem de programação'?";
        q15.Resposta1 = "Lucas Mathias Belini";
        q15.Resposta2 = "Grace Murray Hopper";
        q15.Resposta3 = "Anders hejlsberg";
        q15.Resposta4 = "James Gosling";
        q15.Resposta5 = "Brendan Eich";

        q15.RespostaCerta = 2;
        q15.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q15);

        var q16 = new Questao();
        q16.Pergunta = "Qual planeta é conhecido como o 'planeta vermelho'?";
        q16.Resposta1 = "Marte";
        q16.Resposta2 = "Vênus";
        q16.Resposta3 = "Júpiter";
        q16.Resposta4 = "Saturno";
        q16.Resposta5 = "Mercúrio";

         q16.RespostaCerta = 2;
        q15.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q16);

         var q17 = new Questao();
        q17.Pergunta = "Qual linguagem de programação é menos utilizada no mundo?";
        q17.Resposta1 = "COBOL";
        q17.Resposta2 = "PHP";
        q17.Resposta3 = "Java script";
        q17.Resposta4 = "lua";
        q17.Resposta5 = "swelt";

        q15.RespostaCerta = 1;
        q15.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q17);

         var q18 = new Questao();
        q18.Pergunta = "Qual a linguagem de programação é orientada a objetos?";
        q18.Resposta1 = "HTML";
        q18.Resposta2 = "JAVA";
        q18.Resposta3 = "CSS";
        q18.Resposta4 = "SQL";
        q18.Resposta5 = "Brainfuck";

        q18.RespostaCerta = 2;
        q18.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q18);

         var q19 = new Questao();
        q19.Pergunta = "Qual o significado de SQL?";
        q19.Resposta1 = "Structured Query Language";
        q19.Resposta2 = "Sequential Query Language";
        q19.Resposta3 = "Standard Query Language";
        q19.Resposta4 = "nenhuma desses";
        q19.Resposta5 = "patrão agora complicou";

        q19.RespostaCerta = 1;
        q15.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q19);

         var q20 = new Questao();
        q20.Pergunta = "Qual é o operador de igualdade em Java?";
        q20.Resposta1 = "=";
        q20.Resposta2 = "==";
        q20.Resposta3 = "===";
        q20.Resposta4 = "!=";
        q20.Resposta5 = "?=";
        q15.RespostaCerta = 2;
        q15.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q20);

         var q21 = new Questao();
        q21.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q21.Resposta1 = "Array";
        q21.Resposta2 = "HashMap";
        q21.Resposta3 = "Set";
        q21.Resposta4 = "Queue";
        q21.Resposta5 = "nenhuma dessas";

        q21.RespostaCerta = 2;
        q21.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q21);

           var q22 = new Questao();
        q22.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q22.Resposta1 = "Array";
        q22.Resposta2 = "HashMap";
        q22.Resposta3 = "Set";
        q22.Resposta4 = "Queue";
        q22.Resposta5 = "nenhuma dessas";

        q22.RespostaCerta = 2;
        q22.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q22);

   var q23 = new Questao();
        q23.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q23.Resposta1 = "Array";
        q23.Resposta2 = "HashMap";
        q23.Resposta3 = "Set";
        q23.Resposta4 = "Queue";
        q23.Resposta5 = "nenhuma dessas";

        q23.RespostaCerta = 2;
        q23.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q23);

   var q24 = new Questao();
        q24.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q24.Resposta1 = "Array";
        q24.Resposta2 = "HashMap";
        q24.Resposta3 = "Set";
        q24.Resposta4 = "Queue";
        q24.Resposta5 = "nenhuma dessas";
        q24.RespostaCerta = 2;
        q24.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q24);

   var q25 = new Questao();
        q25.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q25.Resposta1 = "Array";
        q25.Resposta2 = "HashMap";
        q25.Resposta3 = "Set";
        q25.Resposta4 = "Queue";
        q25.Resposta5 = "nenhuma dessas";
        q25.RespostaCerta = 2;
        q25.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q25);

   var q26 = new Questao();
        q26.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q26.Resposta1 = "Array";
        q26.Resposta2 = "HashMap";
        q26.Resposta3 = "Set";
        q26.Resposta4 = "Queue";
        q26.Resposta5 = "nenhuma dessas";

        q26.RespostaCerta = 2;
        q26.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q26);

   var q27 = new Questao();
        q27.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q27.Resposta1 = "Array";
        q27.Resposta2 = "HashMap";
        q27.Resposta3 = "Set";
        q27.Resposta4 = "Queue";
        q27.Resposta5 = "nenhuma dessas";

        q27.RespostaCerta = 2;
        q27.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q27);

   var q28 = new Questao();
        q28.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q28.Resposta1 = "Array";
        q28.Resposta2 = "HashMap";
        q28.Resposta3 = "Set";
        q28.Resposta4 = "Queue";
        q28.Resposta5 = "nenhuma dessas";

        q28.RespostaCerta = 2;
        q21.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q28);

   var q29 = new Questao();
        q29.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q29.Resposta1 = "Array";
        q29.Resposta2 = "HashMap";
        q29.Resposta3 = "Set";
        q29.Resposta4 = "Queue";
        q29.Resposta5 = "nenhuma dessas";

        q29.RespostaCerta = 2;
        q29.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q21);

   var q30 = new Questao();
        q30.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q30.Resposta1 = "Array";
        q30.Resposta2 = "HashMap";
        q30.Resposta3 = "Set";
        q30.Resposta4 = "Queue";
        q30.Resposta5 = "nenhuma dessas";

        q30.RespostaCerta = 2;
        q30.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q30);

   var q31 = new Questao();
        q31.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q31.Resposta1 = "Array";
        q31.Resposta2 = "HashMap";
        q31.Resposta3 = "Set";
        q31.Resposta4 = "Queue";
        q31.Resposta5 = "nenhuma dessas";

        q31.RespostaCerta = 2;
        q31.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q31);

   var q32 = new Questao();
        q32.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q32.Resposta1 = "Array";
        q32.Resposta2 = "HashMap";
        q32.Resposta3 = "Set";
        q32.Resposta4 = "Queue";
        q32.Resposta5 = "nenhuma dessas";

        q32.RespostaCerta = 2;
        q32.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q32);

   var q33 = new Questao();
        q33.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q33.Resposta1 = "Array";
        q33.Resposta2 = "HashMap";
        q33.Resposta3 = "Set";
        q33.Resposta4 = "Queue";
        q33.Resposta5 = "nenhuma dessas";
        q33.RespostaCerta = 2;
        q33.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q33);

   var q34 = new Questao();
        q34.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q34.Resposta1 = "Array";
        q34.Resposta2 = "HashMap";
        q34.Resposta3 = "Set";
        q34.Resposta4 = "Queue";
        q34.Resposta5 = "nenhuma dessas";

        q34.RespostaCerta = 2;
        q34.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q34);

   var q35 = new Questao();
        q35.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q35.Resposta1 = "Array";
        q35.Resposta2 = "HashMap";
        q35.Resposta3 = "Set";
        q35.Resposta4 = "Queue";
        q35.Resposta5 = "nenhuma dessas";
        q35.RespostaCerta = 2;
        q35.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q35);

   var q36 = new Questao();
        q36.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q36.Resposta1 = "Array";
        q36.Resposta2 = "HashMap";
        q36.Resposta3 = "Set";
        q36.Resposta4 = "Queue";
        q36.Resposta5 = "nenhuma dessas";

        q36.RespostaCerta = 2;
        q36.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q36);

   var q37 = new Questao();
        q37.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q37.Resposta1 = "Array";
        q37.Resposta2 = "HashMap";
        q37.Resposta3 = "Set";
        q37.Resposta4 = "Queue";
        q37.Resposta5 = "nenhuma dessas";

        q37.RespostaCerta = 2;
        q37.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q37);

   var q38 = new Questao();
        q38.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q38.Resposta1 = "Array";
        q38.Resposta2 = "HashMap";
        q38.Resposta3 = "Set";
        q38.Resposta4 = "Queue";
        q38.Resposta5 = "nenhuma dessas";

        q38.RespostaCerta = 2;
        q38.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q21);

   var q39 = new Questao();
        q39.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q39.Resposta1 = "Array";
        q39.Resposta2 = "HashMap";
        q39.Resposta3 = "Set";
        q39.Resposta4 = "Queue";
        q39.Resposta5 = "nenhuma dessas";

        q39.RespostaCerta = 2;
        q39.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q39);

   var q40 = new Questao();
        q40.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q40.Resposta1 = "Array";
        q40.Resposta2 = "HashMap";
        q40.Resposta3 = "Set";
        q40.Resposta4 = "Queue";
        q40.Resposta5 = "nenhuma dessas";

        q40.RespostaCerta = 2;
        q40.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q40);

   var q41 = new Questao();
        q41.Pergunta = "Qual estrutura de dados é usada para armazenar um coleção de elementos de forma ordenada?";
        q41.Resposta1 = "Array";
        q41.Resposta2 = "HashMap";
        q41.Resposta3 = "Set";
        q41.Resposta4 = "Queue";
        q41.Resposta5 = "nenhuma dessas";
        q41.RespostaCerta = 2;
        q21.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q41);

   var q42 = new Questao();
        q42.Pergunta = "qual personagem do lol que usa 2 adagas";
        q42.Resposta1 = "corki";
        q42.Resposta2 = "orianna";
        q42.Resposta3 = "katarina";
        q42.Resposta4 = "aatrox";
        q42.Resposta5 = "nenhuma dessas";

        q42.RespostaCerta = 3;
        q42.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q42);

   var q43 = new Questao();
        q43.Pergunta = "Qual é o jogo mais jogado atualmente?";
        q43.Resposta1 = "minecraft";
        q43.Resposta2 = "league of leagends";
        q43.Resposta3 = "overwatch";
        q43.Resposta4 = "dota";
        q43.Resposta5 = "nenhuma dessas";

        q43.RespostaCerta = 1;
        q43.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q43);

   var q44 = new Questao();
        q44.Pergunta = "Qual campeao do lol usa katana que solta tornado?";
        q44.Resposta1 = "varus";
        q44.Resposta2 = "sett";
        q44.Resposta3 = "clarsmente é a catlyn";
        q44.Resposta4 = "yasuo";
        q44.Resposta5 = "nenhuma dessas";

        q44.RespostaCerta = 4;
        q44.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q44);



    }
       public void ProximaQuestao()
{
    var numRandom = Random.Shared.Next(0, listaQuestoes.Count);

    while (listaQuestaoRespondida.Contains(numRandom))
    {
        numRandom = Random.Shared.Next(0, listaQuestoes.Count);
    }

    listaQuestaoRespondida.Add(numRandom);
    QuestaoAtual = listaQuestoes[numRandom];
    QuestaoAtual.Desenhar();
}

public async void VerificaCorreta(int RespostaSelecionada)
{
    if (QuestaoAtual.VerificaResposta(RespostaSelecionada))
    {
        await Task.Delay(90);
        ProximaQuestao();
    }
}

   
       }
}



      