namespace milhao
{
    public class Questao
    {
        public string Pergunta;
        public string Pergunta01;
        public string Pergunta02;
        public string Pergunta03;
        public string Pergunta04;
        public string Pergunta05;
        public int RespostaCerta = 0;
        public int Nivel;
        private Label labelPergunta;
        private Button buttonPergunta01;
        private Button buttonPergunta02;
        private Button buttonPergunta03;
        private Button buttonPergunta04;
        private Button buttonPergunta05;
        public Questao ()
        {

        }
        public void Desenhar ()
        {
            labelPergunta.Text = Pergunta;
            buttonRespostaUm.Text = Pergunta01;
            buttonRespostaUm.Text = Pergunta02;
            buttonRespostaUm.Text = Pergunta03;
            buttonRespostaUm.Text = Pergunta04;
            buttonRespostaUm.Text = Pergunta05;

            this.ButtonResposta1!.BackgroundColor = Colors.DarkBlue;
            this.ButtonResposta1!.TextColor       = Colors.White;
            this.ButtonResposta2!.BackgroundColor = Colors.DarkBlue;
            this.ButtonResposta2!.TextColor       = Colors.White;
            this.ButtonResposta3!.BackgroundColor = Colors.DarkBlue;
            this.ButtonResposta3!.TextColor       = Colors.White;
            this.ButtonResposta4!.BackgroundColor = Colors.DarkBlue;
            this.ButtonResposta4!.TextColor       = Colors.White;
            this.ButtonResposta5!.BackgroundColor = Colors.DarkBlue;
            this.ButtonResposta5!.TextColor       = Colors.White;
        }
        public Questao (Label LP, Button bt01, Button bt02,Button bt03, Button bt04, Button bt05)
        {
            labelPergunta = LabelPergunta;
            Botao1 = bt01;
            Botao2 = bt02;
            Botao3 = bt03;
            Botao4 = bt04;
            Botao5 = bt05;
        }
        public void ConfigurarDesenho (Label LP, Button bt01, Button bt02,Button bt03, Button bt04, Button bt05)
        {
            labelPergunta = LabelPergunta;
            buttonRespostaUm.Text = Resposta1;
            buttonRespostaUm.Text = Resposta2;
            buttonRespostaUm.Text = Resposta3;
            buttonRespostaUm.Text = Resposta4;
            buttonRespostaUm.Text = Resposta5;
        }
        public bool VerificaResposta(int RespostaSelecionada)
        {
            if (RespostaCorreta == RespostaSelecionada)
            {
                var Button = QualButton(RespostaSelecionada);
                Button.BackgroundColor = Colors.Green;
                return true;
            }
            else
            {
                var ButtonCorreto = QualButton (RespostaCorreta);
                var ButtonIncorreto = QualButton (RespostaSelecionada);
                ButtonCorreto.BackgroundColor = Colors.Yellow;
                ButtonIncorreto.BackgroundColor = Colors.Red;
                return false;
            }
        }
        private Button Qual (int RespostaEscolhida)
        {
            if (RespostaEscolhida == 1 )
            return buttonResposta1;
            else if (RespostaEscolhida == 2 )
            return buttonResposta2;
            else if (RespostaEscolhida == 3 )
            return buttonResposta3;
            else if (RespostaEscolhida == 4 )
            return buttonResposta4;
            else if (RespostaEscolhida == 5 )
            return buttonResposta5;
            else 
            return null;
        }
    
        }

    }
