
namespace Milhao;

public partial class MainPage : ContentPage
{
	 Gerenciador gerenciador;


	public MainPage()
	{
		InitializeComponent();
	    gerenciador= new Gerenciador (LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5, Pontuacao, Nivel);
	}

	  void Button1(object sender, EventArgs args)
	{
	    gerenciador.VerificaCorreta(1);
	}
	void Button2(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(2);
	}
	void Button3(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(3);
	}
	void Button4(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(4);
	}
	void Button5(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(5);
	}

}