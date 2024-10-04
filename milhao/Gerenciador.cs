using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using milhao;
namespace Milhao;
public class Gerenciador


{
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao QuestaoCorrente;
    int Pontuacao { get; set; }
    int NivelAtual = 0;


    public Gerenciador (Label LabelPergunta, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05)
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

          
      var Q2 = new Questao();
      Q2.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q2.Pergunta = "Qual é a capital da França?";
      Q2.Pergunta01 = "Londres";
      Q2.Pergunta02 = "Berlim";
      Q2.Pergunta03 = "Paris";
      Q2.Pergunta04 = "Madri";
      Q2.Pergunta05 = "Roma";
      Q2.ResposraCorreta = 3;
      Q2.Nivel = 1;
      ListaQuestoes.Add(Q2);
    
      var Q3 = new Questao();
      Q3.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q3.Pergunta = "Em que ano o Brasil foi descoberto?";
      Q3.Pergunta01 = "1550";
      Q3.Pergunta02 = "1500";
      Q3.Pergunta03 = "2024";
      Q3.Pergunta04 = "sim";
      Q3.Pergunta05 = "não foi descoberto";
      Q3.ResposraCorreta = 2;
      Q3.Nivel = 1;
      ListaQuestoes.Add(Q3);
    

    
      var Q4 = new Questao();
      Q4.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q4.Pergunta = "Quem pintou a Mona Lisa?";
      Q4.Pergunta01 = "Michelangelo";
      Q4.Pergunta02 = "Leonardo da Vinci";
      Q4.Pergunta03 = "Pablo Picasso";
      Q4.Pergunta04 = "Vincent van Gogh";
      Q4.Pergunta05 = "Claude Monet";
      Q4.ResposraCorreta = 2;
      Q4.Nivel = 1;
      ListaQuestoes.Add(Q4);
    

    
      var Q5 = new Questao();
      Q5.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q5.Pergunta = "Qual o maior planeta do sistema solar?";
      Q5.Pergunta01 = "Terra";
      Q5.Pergunta02 = "Marte";
      Q5.Pergunta03 = "Saturno";
      Q5.Pergunta04 = "Júpiter";
      Q5.Pergunta05 = "Netuno";
      Q5.ResposraCorreta = 4;
      Q5.Nivel = 1;
      ListaQuestoes.Add(Q5);
    

    
      var Q6 = new Questao();
      Q6.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q6.Pergunta = "Qual é o idioma mais falado do mundo?";
      Q6.Pergunta01 = "Inglês";
      Q6.Pergunta02 = "Francês";
      Q6.Pergunta03 = "Mandarim";
      Q6.Pergunta04 = "Espanhol";
      Q6.Pergunta05 = "Árabe";
      Q6.ResposraCorreta = 3;
      Q6.Nivel = 1;
      ListaQuestoes.Add(Q6);
    

    
      var Q7 = new Questao();
      Q7.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q7.Pergunta = "Quem foi o primeiro presidente dos Estados Unidos?";
      Q7.Pergunta01 = "Thomas Jefferson";
      Q7.Pergunta02 = "George Washington";
      Q7.Pergunta03 = "Abraham Lincoln";
      Q7.Pergunta04 = "Vincent van Gogh";
      Q7.Pergunta05 = "John Adams";
      Q7.ResposraCorreta = 2;
      Q7.Nivel = 1;
      ListaQuestoes.Add(Q7);
    

    
      var Q8 = new Questao();
      Q8.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q8.Pergunta = "Em que ano terminou a Segunda Guerra Mundial?";
      Q8.Pergunta01 = "1940";
      Q8.Pergunta02 = "1985";
      Q8.Pergunta03 = "1939";
      Q8.Pergunta04 = "1945";
      Q8.Pergunta05 = "1960";
      Q8.ResposraCorreta = 4;
      Q8.Nivel = 1;
      ListaQuestoes.Add(Q8);
    

    
      var Q9 = new Questao();
      Q9.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q9.Pergunta = "Qual civilização construiu as pirâmides do Egito?";
      Q9.Pergunta01 = "Romana";
      Q9.Pergunta02 = "Maia";
      Q9.Pergunta03 = "Brasileira";
      Q9.Pergunta04 = "Grega";
      Q9.Pergunta05 = "Egípcia";
      Q9.ResposraCorreta = 5;
      Q9.Nivel = 1;
      ListaQuestoes.Add(Q9);
    

    
      var Q10 = new Questao();
      Q10.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q10.Pergunta = "Quem foi Dom Pedro I?";
      Q10.Pergunta01 = "Rei de Portugal";
      Q10.Pergunta02 = "Leonardo da Vinci";
      Q10.Pergunta03 = "Imperador do Brasil";
      Q10.Pergunta04 = "Presidente do Brasil";
      Q10.Pergunta05 = "Governador da Argentina";
      Q10.ResposraCorreta = 3;
      Q10.Nivel = 1;
      ListaQuestoes.Add(Q10);
    

    
      var Q11 = new Questao();
      Q11.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q11.Pergunta = "O que foi a Revolução Industrial?";
      Q11.Pergunta01 = "Mudança para a produção em massa";
      Q11.Pergunta02 = "Revolta política";
      Q11.Pergunta03 = "Descobrimento de novas terras";
      Q11.Pergunta04 = "Revolução agrícola";
      Q11.Pergunta05 = "Criação de novas máquinas de guerra";
      Q11.ResposraCorreta = 1;
      Q11.Nivel = 2;
      ListaQuestoes.Add(Q11);
    

    
      var Q12 = new Questao();
      Q12.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q12.Pergunta = "Qual é o maior país do mundo?";
      Q12.Pergunta01 = "China";
      Q12.Pergunta02 = "Brasil";
      Q12.Pergunta03 = "Canadá";
      Q12.Pergunta04 = "Rússia";
      Q12.Pergunta05 = "Estados Unidos";
      Q12.ResposraCorreta = 4;
      Q12.Nivel = 2;
      ListaQuestoes.Add(Q12);
    
    
      var Q13 = new Questao();
      Q13.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q13.Pergunta = "Onde está localizada a Torre Eiffel";
      Q13.Pergunta01 = "Roma";
      Q13.Pergunta02 = "Londres";
      Q13.Pergunta03 = "Paris";
      Q13.Pergunta04 = "Berlim";
      Q13.Pergunta05 = "Brasil";
      Q13.ResposraCorreta = 3;
      Q13.Nivel = 2;
      ListaQuestoes.Add(Q13);
    

    
      var Q14 = new Questao();
      Q14.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q14.Pergunta = "Qual é o rio mais longo do mundo?";
      Q14.Pergunta01 = "Nilo";
      Q14.Pergunta02 = "Amazonas";
      Q14.Pergunta03 = "Yangtze";
      Q14.Pergunta04 = "Mississipi";
      Q14.Pergunta05 = "Ganges";
      Q14.ResposraCorreta = 2;
      Q14.Nivel = 2;
      ListaQuestoes.Add(Q14);
    

    
      var Q15 = new Questao();
      Q15.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q15.Pergunta = "Quais são os cinco oceanos do planeta?";
      Q15.Pergunta01 = "Atlântico, Pacífico, Índico, Ártico, Antártico";
      Q15.Pergunta02 = " Atlântico, Pacífico, Índico, Sul, Norte";
      Q15.Pergunta03 = "Atlântico, Pacífico, Índico, Ártico, Antártico";
      Q15.Pergunta04 = "Atlântico, Pacífico, Mediterrâneo, Ártico, Antártico";
      Q15.Pergunta05 = "Atlântico, Índico, Ártico, Sul, Norte";
      Q15.ResposraCorreta = 1;
      Q15.Nivel = 2;
      ListaQuestoes.Add(Q15);
    

    
      var Q16 = new Questao();
      Q16.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q16.Pergunta = "Em que continente fica o Egito?";
      Q16.Pergunta01 = "América";
      Q16.Pergunta02 = "Europa";
      Q16.Pergunta03 = "África";
      Q16.Pergunta04 = "Ásia";
      Q16.Pergunta05 = "Oceania";
      Q16.ResposraCorreta = 3;
      Q16.Nivel = 2;
      ListaQuestoes.Add(Q16);
    

    
      var Q17 = new Questao();
      Q17.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q17.Pergunta = "Qual é a fórmula química da água?";
      Q17.Pergunta01 = "H2";
      Q17.Pergunta02 = "O2";
      Q17.Pergunta03 = "CO2";
      Q17.Pergunta04 = "H2O";
      Q17.Pergunta05 = "Nh3";
      Q17.ResposraCorreta = 4;
      Q17.Nivel = 2;
      ListaQuestoes.Add(Q17);
    

    
      var Q18 = new Questao();
      Q18.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q18.Pergunta = "Quem é o cantor da música Thriller?";
      Q18.Pergunta01 = "Elvis Presley";
      Q18.Pergunta02 = "Whitney Houston";
      Q18.Pergunta03 = "Prince";
      Q18.Pergunta04 = "Stevie Wonder";
      Q18.Pergunta05 = "Michael Jackson";
      Q18.ResposraCorreta = 5;
      Q18.Nivel = 2;
      ListaQuestoes.Add(Q18);
    

    
      var Q19 = new Questao();
      Q19.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q19.Pergunta = "Em qual filme aparece o personagem Jack Sparrow?";
      Q19.Pergunta01angel = "O Senhor dos Anéis";
      Q19.Pergunta02 = "O Rei Leão";
      Q19.Pergunta03 = "Transformers";
      Q19.Pergunta04 = "Harry Potter";
      Q19.Pergunta05 = "Piratas do Caribe";
      Q19.ResposraCorreta = 2;
      Q19.Nivel = 2;
      ListaQuestoes.Add(Q19);
    

    
      var Q20 = new Questao();
      Q20.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q20.Pergunta = "Quantas Copas do Mundo de Futebol o Brasil ganhou?";
      Q20.Pergunta01 = "5";
      Q20.Pergunta02 = "3";
      Q20.Pergunta03 = "2";
      Q20.Pergunta04 = "6";
      Q20.Pergunta05 = "4";
      Q20.ResposraCorreta = 1;
      Q20.Nivel = 2;
      ListaQuestoes.Add(Q20);
    
    
      var Q21 = new Questao();
      Q21.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q21.Pergunta = "Quem escreveu 'Dom Casmurro'?";
      Q21.Pergunta01 = "José de Alencar";
      Q21.Pergunta02 = "Graciliano Ramos";
      Q21.Pergunta03 = "Clarice Lispector";
      Q21.Pergunta04 = "Érico Veríssimo";
      Q21.Pergunta05 = "Machado de Assis";
      Q21.RespostaCorreta = 5;
      Q21.Nivel = 3;
      ListaQuestoes.Add(Q21);
    

    
      var Q22 = new Questao();
      Q22.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q22.Pergunta = "Quem é o autor de 'Harry Potter'?";
      Q22.Pergunta01 = "C.S. Lewis";
      Q22.Pergunta02 = "Suzanne Collins";
      Q22.Pergunta03 = "George R.R. Martin";
      Q22.Pergunta04 = "J.R.R. Tolkien";
      Q22.Pergunta05 = "J.K. Rowling";
      Q22.RespostaCorreta = 5;
      Q22.Nivel = 3;
      ListaQuestoes.Add(Q22);
    

    
      var Q23 = new Questao();
      Q23.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q23.Pergunta = "Qual é a teoria que explica a origem do universo?";
      Q23.Pergunta01 = "Teoria da Evolução";
      Q23.Pergunta02 = "Teoria da Relatividade";
      Q23.Pergunta03 = "Teoria do Big Bang";
      Q23.Pergunta04 = "Teoria Quântica";
      Q23.Pergunta05 = "Teoria da Gravidade";
      Q23.RespostaCorreta = 3;
      Q23.Nivel = 3;
      ListaQuestoes.Add(Q23);
    

    
      var Q24 = new Questao();
      Q24.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q24.Pergunta = "Quem dirigiu 'Titanic'?";
      Q24.Pergunta01 = "Steven Spielberg";
      Q24.Pergunta02 = "George Lucas";
      Q24.Pergunta03 = "Martin Scorsese";
      Q24.Pergunta04 = "Christopher Nolan";
      Q24.Pergunta05 = "James Cameron";
      Q24.RespostaCorreta = 5;
      Q24.Nivel = 3;
      ListaQuestoes.Add(Q24);
    

    
      var Q25 = new Questao();
      Q25.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q25.Pergunta = "Qual é a música tema de 'Star Wars'?";
      Q25.Pergunta01 = "The Imperial March";
      Q25.Pergunta02 = "Duel of the Fates";
      Q25.Pergunta03 = "Cantina Band";
      Q25.Pergunta04 = "The Force Theme";
      Q25.Pergunta05 = "Star Wars Theme";
      Q25.RespostaCorreta = 5;
      Q25.Nivel = 3;
      ListaQuestoes.Add(Q25);
    

    
      var Q26 = new Questao();
      Q26.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q26.Pergunta = "Qual é a capital do Japão?";
      Q26.Pergunta01 = "Seul";
      Q26.Pergunta02 = "Tóquio";
      Q26.Pergunta03 = "Pequim";
      Q26.Pergunta04 = "Bangkok";
      Q26.Pergunta05 = "Hanoi";
      Q26.RespostaCorreta = 2;
      Q26.Nivel = 3;
      ListaQuestoes.Add(Q26);
    

    
      var Q27 = new Questao();
      Q27.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q27.Pergunta = "Qual é o menor país do mundo?";
      Q27.Pergunta01 = "Mônaco";
      Q27.Pergunta02 = "Vaticano";
      Q27.Pergunta03 = "Nauru";
      Q27.Pergunta04 = "Tuvalu";
      Q27.Pergunta05 = "San Marino";
      Q27.RespostaCorreta = 2;
      Q27.Nivel = 3;
      ListaQuestoes.Add(Q27);
    
      var Q28 = new Questao();
      Q28.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q28.Pergunta = "Quem descobriu a penicilina?";
      Q28.Pergunta01 = "Louis Pasteur";
      Q28.Pergunta02 = "Alexander Fleming";
      Q28.Pergunta03 = "Marie Curie";
      Q28.Pergunta04 = "Isaac Newton";
      Q28.Pergunta05 = "Thomas Edison";
      Q28.RespostaCorreta = 2;
      Q28.Nivel = 3;
      ListaQuestoes.Add(Q28);
    

    
      var Q29 = new Questao();
      Q29.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q29.Pergunta = "Qual é a língua mais falada do mundo?";
      Q29.Pergunta01 = "Espanhol";
      Q29.Pergunta02 = "Inglês";
      Q29.Pergunta03 = "Francês";
      Q29.Pergunta04 = "Mandarim";
      Q29.Pergunta05 = "Árabe";
      Q29.RespostaCorreta = 4;
      Q29.Nivel = 3;
      ListaQuestoes.Add(Q29);
    

    
      var Q30 = new Questao();
      Q30.ConfigurarDesenho(LabelPergunta, bt01, bt02, bt03, bt04, bt05);
      Q30.Pergunta = "Com quantos anos é permitido dirigir no Brasil";
      Q30.Pergunta01 = "15";
      Q30.Pergunta02 = "21";
      Q30.Pergunta03 = "25";
      Q30.Pergunta04 = "10";
      Q30.Pergunta05 = "18";
      Q30.RespostaCorreta = 5;
      Q30.Nivel = 3;
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



