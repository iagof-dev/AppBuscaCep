using AppBuscaCep.Models;
using AppBuscaCep.Services;

namespace AppBuscaCep
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                Endereco dataendereco = await DataService.GetEnderecoByCep(txt_cep.Text);

                BindingContext = dataendereco;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {

            try
            {
                List<Bairro> databairro = await DataService.GetBairrosByIdCidade(4874);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }

}
