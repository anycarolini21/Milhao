namespace milhao 
{
    public class Questao
    {
        public string Pergunta;
        public string RespostaUm;
        public string RespostaDois;
        public string RespostaTres;
        public string RespostaQuatro;
        public string RespostaCinco;
        public int RespostaCerta = 0;
        public int Nivel;
        private Label labelPergunta;
        private Button buttonRespostaUm;
        private Button buttonRespostaDois;
        private Button buttonRespostaTres;
        private Button buttonRespostaQuatro;
        private Button buttonRespostaCinco;
        public Questao ()
        {

        }
        public void Desenhar ()
        {
            labelPergunta.Text = Pergunta;
            buttonRespostaUm.Text = RespostaUm;
            buttonRespostaUm.Text = RespostaDois;
            buttonRespostaUm.Text = RespostaTres;
            buttonRespostaUm.Text = RespostaQuatro;
            buttonRespostaUm.Text = RespostaCinco;

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
            buttonResposta1 = bt01;
            buttonResposta2 = bt02;
            buttonResposta3 = bt03;
            buttonResposta4 = bt04;
            buttonResposta5 = bt05;
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
            if (Respostacorreta == RespostaSelecionada)
            {
                var Button = QualButton(RespostaSelecionada);
                Button.BackgroundColor = Colors.Green;
                return true;
            }
            else
            {
                var ButtonCorreto = QualButton (Respostacorreta);
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
