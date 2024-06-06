namespace AppBuscaCep.Views;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private void btn_CEPBUSCA_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void btn_CIDADEbusca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.BairrosPorCidade());

    }

    private void btn_RUABAIRRObusca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.BuscaCepLogradouro());
    }

    private void btn_CEPbusca_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}