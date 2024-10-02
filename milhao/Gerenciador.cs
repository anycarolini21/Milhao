using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Gerenciador
{
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao QuestaoCorrente;
    int Pontuacao { get; set; }
    int NivelAtual = 0;

    public Gerenciador(Label LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05)
    {
        CriaPerguntas(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
    }

    void CriaPerguntas(Label LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05)
    {
        var Q1 = new Questao();
        Q1.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
        Q1.Pergunta = "Quanto é 2+2?";
        Q1.Pergunta01 = "2";
        Q1.Pergunta02 = "22";
        Q1.Pergunta03 = "4";
        Q1.Pergunta04 = "sim";
        Q1.Pergunta05 = "1";
        Q1.RespostaCorreta = 3;
        Q1.Nivel = 1;
        ListaQuestoes.Add(Q1);

            {
      var Q2 = new Questao();
      Q1.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q1.Pergunta = "Qual é a capital da França?";
      Q1.Pergunta01 = "Londres";
      Q1.Pergunta02 = "Berlim";
      Q1.Pergunta03 = "Paris";
      Q1.Pergunta04 = "Madri";
      Q1.Pergunta05 = "Roma";
      Q1.ResposraCorreta = 3;
      Q1.Nivel = 1;
      ListaQuestoes.Add(Q2);
    }

    {
      var Q3 = new Questao();
      Q1.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q1.Pergunta = "Em que ano o Brasil foi descoberto?";
      Q1.Pergunta01 = "1550";
      Q1.Pergunta02 = "1500";
      Q1.Pergunta03 = "2024";
      Q1.Pergunta04 = "sim";
      Q1.Pergunta05 = "não foi descoberto";
      Q1.ResposraCorreta = 2;
      Q1.Nivel = 1;
      ListaQuestoes.Add(Q3);
    }

    {
      var Q4 = new Questao();
      Q1.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q1.Pergunta = "Quem pintou a Mona Lisa?";
      Q1.Pergunta01 = "Michelangelo";
      Q1.Pergunta02 = "Leonardo da Vinci";
      Q1.Pergunta03 = "Pablo Picasso";
      Q1.Pergunta04 = "Vincent van Gogh";
      Q1.Pergunta05 = "Claude Monet";
      Q1.ResposraCorreta = 2;
      Q1.Nivel = 1;
      ListaQuestoes.Add(Q4);
    }

    {
      var Q5 = new Questao();
      Q1.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q1.Pergunta = "Qual o maior planeta do sistema solar?";
      Q1.Pergunta01 = "Terra";
      Q1.Pergunta02 = "Marte";
      Q1.Pergunta03 = "Saturno";
      Q1.Pergunta04 = "Júpiter";
      Q1.Pergunta05 = "Netuno";
      Q1.ResposraCorreta = 4;
      Q1.Nivel = 1;
      ListaQuestoes.Add(Q5);
    }

    {
      var Q6 = new Questao();
      Q1.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q1.Pergunta = "Qual é o idioma mais falado do mundo?";
      Q1.Pergunta01 = "Inglês";
      Q1.Pergunta02 = "Francês";
      Q1.Pergunta03 = "Mandarim";
      Q1.Pergunta04 = "Espanhol";
      Q1.Pergunta05 = "Árabe";
      Q1.ResposraCorreta = 3;
      Q1.Nivel = 1;
      ListaQuestoes.Add(Q6);
    }

    {
      var Q7 = new Questao();
      Q1.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q1.Pergunta = "Quem foi o primeiro presidente dos Estados Unidos?";
      Q1.Pergunta01 = "Thomas Jefferson";
      Q1.Pergunta02 = "George Washington";
      Q1.Pergunta03 = "Abraham Lincoln";
      Q1.Pergunta04 = "Vincent van Gogh";
      Q1.Pergunta05 = "John Adams";
      Q1.ResposraCorreta = 2;
      Q1.Nivel = 1;
      ListaQuestoes.Add(Q7);
    }

    {
      var Q8 = new Questao();
      Q1.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q1.Pergunta = "Em que ano terminou a Segunda Guerra Mundial?";
      Q1.Pergunta01 = "1940";
      Q1.Pergunta02 = "1985";
      Q1.Pergunta03 = "1939";
      Q1.Pergunta04 = "1945";
      Q1.Pergunta05 = "1960";
      Q1.ResposraCorreta = 4;
      Q1.Nivel = 1;
      ListaQuestoes.Add(Q8);
    }

    {
      var Q9 = new Questao();
      Q1.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q1.Pergunta = "Qual civilização construiu as pirâmides do Egito?";
      Q1.Pergunta01 = "Romana";
      Q1.Pergunta02 = "Maia";
      Q1.Pergunta03 = "Brasileira";
      Q1.Pergunta04 = "Grega";
      Q1.Pergunta05 = "Egípcia";
      Q1.ResposraCorreta = 5;
      Q1.Nivel = 1;
      ListaQuestoes.Add(Q9);
    }

    {
      var Q10 = new Questao();
      Q1.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q1.Pergunta = "Quem foi Dom Pedro I?";
      Q1.Pergunta01 = "Rei de Portugal";
      Q1.Pergunta02 = "Leonardo da Vinci";
      Q1.Pergunta03 = "Imperador do Brasil";
      Q1.Pergunta04 = "Presidente do Brasil";
      Q1.Pergunta05 = "Governador da Argentina";
      Q1.ResposraCorreta = 3;
      Q1.Nivel = 1;
      ListaQuestoes.Add(Q10);
    }

    {
      var Q11 = new Questao();
      Q1.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q1.Pergunta = "O que foi a Revolução Industrial?";
      Q1.Pergunta01 = "Mudança para a produção em massa";
      Q1.Pergunta02 = "Revolta política";
      Q1.Pergunta03 = "Descobrimento de novas terras";
      Q1.Pergunta04 = "Revolução agrícola";
      Q1.Pergunta05 = "Criação de novas máquinas de guerra";
      Q1.ResposraCorreta = 1;
      Q1.Nivel = 2;
      ListaQuestoes.Add(Q11);
    }

    {
      var Q12 = new Questao();
      Q1.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q1.Pergunta = "Qual é o maior país do mundo?";
      Q1.Pergunta01 = "China";
      Q1.Pergunta02 = "Brasil";
      Q1.Pergunta03 = "Canadá";
      Q1.Pergunta04 = "Rússia";
      Q1.Pergunta05 = "Estados Unidos";
      Q1.ResposraCorreta = 4;
      Q1.Nivel = 2;
      ListaQuestoes.Add(Q12);
    }

    {
      var Q13 = new Questao();
      Q1.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q1.Pergunta = "Onde está localizada a Torre Eiffel";
      Q1.Pergunta01 = "Roma";
      Q1.Pergunta02 = "Londres";
      Q1.Pergunta03 = "Paris";
      Q1.Pergunta04 = "Berlim";
      Q1.Pergunta05 = "Brasil";
      Q1.ResposraCorreta = 3;
      Q1.Nivel = 2;
      ListaQuestoes.Add(Q13);
    }

    {
      var Q14 = new Questao();
      Q1.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q1.Pergunta = "Qual é o rio mais longo do mundo?";
      Q1.Pergunta01 = "Nilo";
      Q1.Pergunta02 = "Amazonas";
      Q1.Pergunta03 = "Yangtze";
      Q1.Pergunta04 = "Mississipi";
      Q1.Pergunta05 = "Ganges";
      Q1.ResposraCorreta = 2;
      Q1.Nivel = 2;
      ListaQuestoes.Add(Q14);
    }

    {
      var Q15 = new Questao();
      Q1.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q1.Pergunta = "Quais são os cinco oceanos do planeta?";
      Q1.Pergunta01 = "Atlântico, Pacífico, Índico, Ártico, Antártico";
      Q1.Pergunta02 = " Atlântico, Pacífico, Índico, Sul, Norte";
      Q1.Pergunta03 = "Atlântico, Pacífico, Índico, Ártico, Antártico";
      Q1.Pergunta04 = "Atlântico, Pacífico, Mediterrâneo, Ártico, Antártico";
      Q1.Pergunta05 = "Atlântico, Índico, Ártico, Sul, Norte";
      Q1.ResposraCorreta = 1;
      Q1.Nivel = 2;
      ListaQuestoes.Add(Q15);
    }

    {
      var Q16 = new Questao();
      Q1.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q1.Pergunta = "Em que continente fica o Egito?";
      Q1.Pergunta01 = "América";
      Q1.Pergunta02 = "Europa";
      Q1.Pergunta03 = "África";
      Q1.Pergunta04 = "Ásia";
      Q1.Pergunta05 = "Oceania";
      Q1.ResposraCorreta = 3;
      Q1.Nivel = 2;
      ListaQuestoes.Add(Q16);
    }

    {
      var Q17 = new Questao();
      Q1.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q1.Pergunta = "Qual é a fórmula química da água?";
      Q1.Pergunta01 = "H2";
      Q1.Pergunta02 = "O2";
      Q1.Pergunta03 = "CO2";
      Q1.Pergunta04 = "H2O";
      Q1.Pergunta05 = "Nh3";
      Q1.ResposraCorreta = 4;
      Q1.Nivel = 2;
      ListaQuestoes.Add(Q17);
    }

    {
      var Q18 = new Questao();
      Q1.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q1.Pergunta = "Quem é o cantor da música Thriller?";
      Q1.Pergunta01 = "Elvis Presley";
      Q1.Pergunta02 = "Whitney Houston";
      Q1.Pergunta03 = "Prince";
      Q1.Pergunta04 = "Stevie Wonder";
      Q1.Pergunta05 = "Michael Jackson";
      Q1.ResposraCorreta = 5;
      Q1.Nivel = 2;
      ListaQuestoes.Add(Q18);
    }

    {
      var Q19 = new Questao();
      Q1.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q1.Pergunta = "Em qual filme aparece o personagem Jack Sparrow?";
      Q1.Pergunta01angel = "O Senhor dos Anéis";
      Q1.Pergunta02 = "O Rei Leão";
      Q1.Pergunta03 = "Transformers";
      Q1.Pergunta04 = "Harry Potter";
      Q1.Pergunta05 = "Piratas do Caribe";
      Q1.ResposraCorreta = 2;
      Q1.Nivel = 2;
      ListaQuestoes.Add(Q19);
    }

    {
      var Q20 = new Questao();
      Q1.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q1.Pergunta = "Quantas Copas do Mundo de Futebol o Brasil ganhou?";
      Q1.Pergunta01 = "5";
      Q1.Pergunta02 = "3";
      Q1.Pergunta03 = "2";
      Q1.Pergunta04 = "6";
      Q1.Pergunta05 = "4";
      Q1.ResposraCorreta = 1;
      Q1.Nivel = 2;
      ListaQuestoes.Add(Q20);
    }

    {
      var Q21 = new Questao();
      Q5.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q5.Pergunta = "Quem escreveu 'Dom Casmurro'?";
      Q5.Pergunta01 = "José de Alencar";
      Q5.Pergunta02 = "Graciliano Ramos";
      Q5.Pergunta03 = "Clarice Lispector";
      Q5.Pergunta04 = "Érico Veríssimo";
      Q5.Pergunta05 = "Machado de Assis";
      Q5.RespostaCorreta = 5;
      Q5.Nivel = 3;
      ListaQuestoes.Add(Q21);
    }

    {
      var Q22 = new Questao();
      Q7.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q7.Pergunta = "Quem é o autor de 'Harry Potter'?";
      Q7.Pergunta01 = "C.S. Lewis";
      Q7.Pergunta02 = "Suzanne Collins";
      Q7.Pergunta03 = "George R.R. Martin";
      Q7.Pergunta04 = "J.R.R. Tolkien";
      Q7.Pergunta05 = "J.K. Rowling";
      Q7.RespostaCorreta = 5;
      Q7.Nivel = 3;
      ListaQuestoes.Add(Q22);
    }

    {
      var Q23 = new Questao();
      Q8.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q8.Pergunta = "Qual é a teoria que explica a origem do universo?";
      Q8.Pergunta01 = "Teoria da Evolução";
      Q8.Pergunta02 = "Teoria da Relatividade";
      Q8.Pergunta03 = "Teoria do Big Bang";
      Q8.Pergunta04 = "Teoria Quântica";
      Q8.Pergunta05 = "Teoria da Gravidade";
      Q8.RespostaCorreta = 3;
      Q8.Nivel = 3;
      ListaQuestoes.Add(Q23);
    }

    {
      var Q24 = new Questao();
      Q9.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q9.Pergunta = "Quem dirigiu 'Titanic'?";
      Q9.Pergunta01 = "Steven Spielberg";
      Q9.Pergunta02 = "George Lucas";
      Q9.Pergunta03 = "Martin Scorsese";
      Q9.Pergunta04 = "Christopher Nolan";
      Q9.Pergunta05 = "James Cameron";
      Q9.RespostaCorreta = 5;
      Q9.Nivel = 3;
      ListaQuestoes.Add(Q24);
    }

    {
      var Q25 = new Questao();
      Q10.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q10.Pergunta = "Qual é a música tema de 'Star Wars'?";
      Q10.Pergunta01 = "The Imperial March";
      Q10.Pergunta02 = "Duel of the Fates";
      Q10.Pergunta03 = "Cantina Band";
      Q10.Pergunta04 = "The Force Theme";
      Q10.Pergunta05 = "Star Wars Theme";
      Q10.RespostaCorreta = 5;
      Q10.Nivel = 3;
      ListaQuestoes.Add(Q25);
    }

    {
      var Q26 = new Questao();
      Q11.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q11.Pergunta = "Qual é a capital do Japão?";
      Q11.Pergunta01 = "Seul";
      Q11.Pergunta02 = "Tóquio";
      Q11.Pergunta03 = "Pequim";
      Q11.Pergunta04 = "Bangkok";
      Q11.Pergunta05 = "Hanoi";
      Q11.RespostaCorreta = 2;
      Q11.Nivel = 3;
      ListaQuestoes.Add(Q26);
    }

    {
      var Q27 = new Questao();
      Q12.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q12.Pergunta = "Qual é o menor país do mundo?";
      Q12.Pergunta01 = "Mônaco";
      Q12.Pergunta02 = "Vaticano";
      Q12.Pergunta03 = "Nauru";
      Q12.Pergunta04 = "Tuvalu";
      Q12.Pergunta05 = "San Marino";
      Q12.RespostaCorreta = 2;
      Q12.Nivel = 3;
      ListaQuestoes.Add(Q27);

    }

    {
      var Q28 = new Questao();
      Q13.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q13.Pergunta = "Quem descobriu a penicilina?";
      Q13.Pergunta01 = "Louis Pasteur";
      Q13.Pergunta02 = "Alexander Fleming";
      Q13.Pergunta03 = "Marie Curie";
      Q13.Pergunta04 = "Isaac Newton";
      Q13.Pergunta05 = "Thomas Edison";
      Q13.RespostaCorreta = 2;
      Q13.Nivel = 3;
      ListaQuestoes.Add(Q28);
    }

    {
      var Q29 = new Questao();
      Q14.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q14.Pergunta = "Qual é a língua mais falada do mundo?";
      Q14.Pergunta01 = "Espanhol";
      Q14.Pergunta02 = "Inglês";
      Q14.Pergunta03 = "Francês";
      Q14.Pergunta04 = "Mandarim";
      Q14.Pergunta05 = "Árabe";
      Q14.RespostaCorreta = 4;
      
      Q14.Nivel = 4;
      ListaQuestoes.Add(Q29);
    }

    {
      var Q30 = new Questao();
      Q14.ConfigurarDesenho(LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05);
      Q14.Pergunta = "Com quantos anos é permitido dirigir no Brasil";
      Q14.Pergunta01 = "15";
      Q14.Pergunta02 = "21";
      Q14.Pergunta03 = "25";
      Q14.Pergunta04 = "10";
      Q14.Pergunta05 = "18";
      Q14.RespostaCorreta = 5;
      Q14.Nivel = 3;
      ListaQuestoes.Add(Q30);
    }

    public async void VerificaCorreta(int rr)
    {
        if (QuestaoCorrente.EstaCorreto(rr))
        {
            await Task.Delay(1000);
            AdicionaPontuacao(NivelAtual);
            NivelAtual++;
            ProximaQuestao();
        }
        else
        {
            await App.Current.MainPage.DisplayAlert("Fim", "Fim do Jogo", "OK");
            Inicializar();
        }
    }

    void ProximaQuestao()
    {
        var numAleat = Random.Shared.Next(0, ListaQuestoes.Count);
        while (ListaQuestoesRespondidas.Contains(numAleat))
        {
            numAleat = Random.Shared.Next(0, ListaQuestoes.Count);
        }

        ListaQuestoesRespondidas.Add(numAleat);
        QuestaoCorrente = ListaQuestoes[numAleat];
        QuestaoCorrente.Desenha();
    }

    void Inicializar()
    {
        Pontuacao = 0;
        NivelAtual = 1;
        ProximaQuestao();
    }

    void AdicionaPontuacao(int n)
    {
        if (n == 1) Pontuacao = 1000;
        else if (n == 2) Pontuacao = 2000;
        else if (n == 3) Pontuacao = 5000;
        else if (n == 4) Pontuacao = 10000;
        else if (n == 5) Pontuacao = 20000;
        else if (n == 6) Pontuacao = 50000;
        else if (n == 7) Pontuacao = 100000;
        else if (n == 8) Pontuacao = 200000;
        else if (n == 9) Pontuacao = 500000;
        else if (n == 10) Pontuacao = 1000000;
    }
}
