using AppBuscaCep.Models;
using AppBuscaCep.Services;

namespace AppBuscaCep.Views;

public partial class BuscaCepLogradouro : ContentPage
{
	public BuscaCepLogradouro()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            carregando.IsRunning = true;

            List<Cep> arr_ceps =
                await DataService.GetCepsByLogradouro(
                    txt_logradouro.Text);

            lst_ceps.ItemsSource = arr_ceps;
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
        finally
        {
            carregando.IsRunning = false;
        }
    }
}