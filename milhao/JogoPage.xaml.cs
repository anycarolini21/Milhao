
namespace Milhao;

public partial class MainPage : ContentPage
{
	 Gerenciador gerenciador;


	public MainPage()
	{
		InitializeComponent();
	    gerenciador= new Gerenciador (LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5, Pontuacao, Nivel);
	}

	  void Botao1(object sender, EventArgs args)
	{
	    gerenciador.VerificaCorreta(1);
	}
	void Botao2(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(2);
	}
	void Botao3(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(3);
	}
	void Botao4(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(4);
	}
	void Botao5(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(5);
	}

	void retiraaoclicar(object sender, EventArgs args)
	{
		var ajuda = new RetiraErrada();
		ajuda.ConfiguraDesenho( ButtonResposta1, ButtonResposta2,  ButtonResposta3,  ButtonResposta4, ButtonResposta5);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
		(sender as Button).IsVisible = false;

	}

	void botaouniversitario(object sender, EventArgs args)
	{
		var ajuda = new Universitario();
		ajuda.ConfiguraDesenho( ButtonResposta1, ButtonResposta2,  ButtonResposta3,  ButtonResposta4, ButtonResposta5);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
		(sender as Button).IsVisible = false;

	}

	void botaopular(object sender, EventArgs args)
	{
		gerenciador.ProximaQuestao();
		(sender as Button).IsVisible = false;
	}


}