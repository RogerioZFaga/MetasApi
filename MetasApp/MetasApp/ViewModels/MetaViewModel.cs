using System.Collections.ObjectModel;
using System.ComponentModel;
using MetasApp.Models;
using MetasApp.Services;

namespace MetasApp.ViewModels
{
    public class MetaViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Meta> Metas { get; set; } = new();
        public Meta MetaAtual { get; set; } = new();
        private MetaService service = new();

        public event PropertyChangedEventHandler? PropertyChanged;

        public void CarregarMetas()
        {
            Metas.Clear();
            foreach (var meta in service.GetAll())
                Metas.Add(meta);
        }

        public void Adicionar()
        {
            service.Add(MetaAtual);
            CarregarMetas();
            MetaAtual = new();
        }


        public void Atualizar()
        {
            service.Update(MetaAtual);
            CarregarMetas();
        }

        public void Remover(int id)
        {
            service.Delete(id);
            CarregarMetas();
        }
    }
}
