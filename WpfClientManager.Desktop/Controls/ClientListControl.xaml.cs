using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using WpfClientManager.Desktop.Models;
using WpfClientManager.Domain;
using WpfClientManager.Domain.Clients;

namespace WpfClientManager.Desktop.Controls
{
    /// <summary>
    /// Interaction logic for ClientListControl.xaml
    /// </summary>
    public partial class ClientListControl : UserControl
    {
        private readonly ClientService _clientService;
        private readonly ClientListModel _model;

        public ClientListControl()
        {
            InitializeComponent();
            _clientService = new ClientService();
            _model = new ClientListModel();
            DataContext = _model;

        }

        private void btnGetClients_Click(object sender, RoutedEventArgs e)
        {
            _model.Clients = _clientService.GetClients();
        }
    }
}
