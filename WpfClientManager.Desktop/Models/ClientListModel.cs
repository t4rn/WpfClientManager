using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfClientManager.Domain;

namespace WpfClientManager.Desktop.Models
{
    public class ClientListModel : INotifyPropertyChanged
    {
        private List<Client> clients;
        public List<Client> Clients
        {
            get { return clients; }
            set { clients = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }
}
