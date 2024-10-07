using Milhao;

public class Universitario : IAjuda
{
    public override void RealizaAjuda(Questao questao)
    {
        var porcentagem = 100;
        for (int i = 0; i < 5; i ++ )
        {
            int numRand = 0;
            if (porcentagem > 0)
            {
                numRand = Random.Shared.Next(0, porcentagem);
                porcentagem -= numRand;
            }
            switch (i)
            {
                case 0:
                    Botao1.Text += "=" + numRand.ToString() + "%";
                    break;
                case 1:
                    Botao2.Text += "=" + numRand.ToString() + "%";
                    break;
                case 2:
                    Botao3.Text += "=" + numRand.ToString() + "%";
                    break;
                case 3:
                    Botao4.Text += "=" + numRand.ToString() + "%";
                    break;
                case 4:
                    Botao5.Text += "=" + numRand.ToString() + "%";
                    break;

            }
        }
    }
}