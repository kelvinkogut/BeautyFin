using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Inicial
{
    /// <summary>
    /// Lógica interna para Servicos.xaml
    /// </summary>
    public partial class Servicos : Window
    {
        public Servicos()
        {
            InitializeComponent();
        }

        private void btnAgen_Click(object sender, RoutedEventArgs e)
        {
            AgendaX ag = new AgendaX();
            ag.Show();
        }

        private void btnFinanceiro_Click(object sender, RoutedEventArgs e)
        {
            Financeiro fc = new Financeiro();
            fc.Show();
        }

        private void btnFunc_Click(object sender, RoutedEventArgs e)
        {
            Funcionarios fc = new Funcionarios();
            fc.Show();
        }
    }
}
