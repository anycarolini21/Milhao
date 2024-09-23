  using System.Security.Cryptography.X509Certificates;

  public class Gerenciador 
  {
      List<Questao> ListaQuestoes= new List<Questao> ();
      List <int> ListaQuestoesRespondidas = new List <int> ();
      Questao QuestaoCorrente;

      public Gerenciador (LabelPerg,  Button bt01)
      {
          CriaPerguntas (labePerg, Button bt01)
        
        {
          var Q1 = new Questao ();
          Q1.ConfigurarDesenho(LabelPerg, Button bt01);
          Q1.Pergunta= "Quanto é 2+2?";
          Q1.Pergunta01="2";
          Q1.Pergunta02="22";
          Q1.Pergunta03="4";
          Q1.Pergunta04="sim";
          Q1.Pergunta05="1";
          Q1.ResposraCorreta=3;
          ListaQuestoes.Add(Q1);
          var Q2= new Questao();              
        }
     }
        public async void VerificaCorreta (int rr)
        {
          if (QuestaoCorreta.EstaCorreto(rr))
          {
            await Iask.Delay(1000);
            AdicionaPontuacao(NivelAtual);
            NivelAtual ++, //NivelAtual = NivelAtual +1;
            ProximaQuestao();
          }
          else{
            await App.Current.MainPage.DisplayAcert ("Fim")
            Inicializar();
          }  
        {
        void ProximaQuestao()
          {
         var numAleat = Random.Shared.Next(0,ListaQuestoes.Count);
         while(ListaQuestoesRespondidas.Contains(numAleat))
         numAleat = Random.Shared.Next(0,ListaQuestoes.Count);

         ListaQuestoesRespondidas.Add(numAleat);
         QuestaoCorrente = ListaQuestoes[numAleat];
         QuestaoCorrente.Desenha();
          }
        }

        {
        public int Pontuacao {get; private set;}
        int NivelAtual = 0;
        void Inicializar ()
          {
        Pontuacao = 0;
        NivelAtual = 1;
        ProximaQuestao();
          }
        }
          void Adiciona Pontuacao(int n)
          {
            if(n == 1)
            pontuacao = 1000;
            else if (n == 2)
            pontuacao 2000;
            else if (n == 3)
            pontuacao 5000;
            else if (n == 4)
            pontuacao 10000;
            else if (n == 5)
            pontuacao 20000;
            else if (n == 6)
            pontuacao 50000;
            else if (n == 7)
            pontuacao 100000;
            else if (n == 8)
            pontuacao 200000;
            else if (n == 9)
            pontuacao 500000;
            else if (n == 10)
            pontuacao 1000000;
          }
        }
  
          }
        }
      }
  }