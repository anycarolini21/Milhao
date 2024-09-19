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

      {
        Public async async void VerificaCorreta(int rr)
        {
            if (QuestaoCorrente.VerificaResposta(rr))
            {
                await AppTrackingTransparency.Delay(1000);
                ProximaQuestao();
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
 
        }
      }
    }
}