using MetasApp.ViewModels;

namespace MetasApp.Views;

public partial class MetaPage : ContentPage
{
    MetaViewModel vm;

    public MetaPage()
    {
        InitializeComponent();
        vm = BindingContext as MetaViewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        vm?.CarregarMetas();
    }

    private void OnAdicionarClicked(object sender, EventArgs e)
    {
        vm?.Adicionar();
    }

    private void OnAtualizarClicked(object sender, EventArgs e)
    {
        vm?.Atualizar();
    }

    private void OnSelecionarMeta(object sender, SelectionChangedEventArgs e)
    {
        vm.MetaAtual = e.CurrentSelection.FirstOrDefault() as MetasApp.Models.Meta ?? new();
    }

    private void OnExcluirMeta(object sender, EventArgs e)
    {
        var id = (int)((Button)sender).CommandParameter;
        vm?.Remover(id);
    }
}
