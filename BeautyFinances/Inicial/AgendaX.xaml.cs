using System;
using System.Linq;
using System.Windows;

namespace Inicial
{
    /// <summary>
    /// Lógica interna para AgendaX.xaml
    /// </summary>
    public partial class AgendaX : Window
    {
        public AgendaX()
        {
            InitializeComponent();
            cldDia.DisplayDateStart = DateTime.Today;

            using (var db = new ModelContext())
            {
                cbFuncionario.ItemsSource = db.Funcionarios.ToList();
                cbCliente.ItemsSource = db.Clientes.ToList();
            }
        }
    }
}
