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
using Inicial.Models;
namespace Inicial
{
    /// <summary>
    /// Lógica interna para ListaClientes.xaml
    /// </summary>
    public partial class ListaClientes : Window
    {
        public ListaClientes()
        {
            InitializeComponent();
            var usuario = new List<Cliente>();
           

        
            using (var db = new ModelContext())
            {
               
                    foreach (var item in db.Clientes)
                    {

                        usuario.Add(new Cliente()
                        {
                            Nome = item.Nome,
                            ciccgc = item.ciccgc,
                            endereco = item.endereco,
                            telefone = item.telefone

                            
                        });
                        lvUsers.ItemsSource = usuario;
                    }
                
                
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

           //Inicial.BeautyFinancesDataSet beautyFinancesDataSet = ((Inicial.BeautyFinancesDataSet)(this.FindResource("beautyFinancesDataSet")));
           // //Carregue dados na tabela Clientes. Você pode modificar este código conforme necessário.
           // Inicial.BeautyFinancesDataSetTableAdapters.ClientesTableAdapter beautyFinancesDataSetClientesTableAdapter = new Inicial.BeautyFinancesDataSetTableAdapters.ClientesTableAdapter();
           //beautyFinancesDataSetClientesTableAdapter.Fill(beautyFinancesDataSet.Clientes);
           //System.Windows.Data.CollectionViewSource clientesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clientesViewSource")));
           //clientesViewSource.View.MoveCurrentToFirst();

            
            
           
        }
    }
}
