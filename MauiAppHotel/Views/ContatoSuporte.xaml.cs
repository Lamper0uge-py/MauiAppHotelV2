namespace MauiAppHotel.Views;

public partial class ContatoSuporte : ContentPage
{
    public ContatoSuporte()
    {
        InitializeComponent();
    }

    private async void btn_voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}