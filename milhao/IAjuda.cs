using Milhao;

public abstract class IAjuda
{
    protected Button Botao1;
    protected Button Botao2;
    protected Button Botao3;
    protected Button Botao4;
    protected Button Botao5;
    protected Frame frameAjuda;

    public void ConfiguraDesenho( Botao1, Botao2,  Botao3,  Botao4, Botao5)
    {
        this.Butao1 = Butao1;
        this.Butao2 = Butao2;
        this.Butao3 = Butao3;
        this.Butao4 = Butao4;
        this.Butao5 = Butao5;
    }
    public void ConfiguraDesenho(Frame frameAjuda)
    {
        this.frameAjuda = frameAjuda;
    }
    public abstract void RealizaAjuda(Questao questao);
}