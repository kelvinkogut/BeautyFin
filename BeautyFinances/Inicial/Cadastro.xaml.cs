using Inicial.Models;
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
    /// Lógica interna para Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new ModelContext())
            {
                //db.Horarios.Add(new Horarios { });
                //var cliente = new Cliente();
                //cliente.Nome = "kelvin";
                //cliente.nascimento = DateTime.Today;
                //cliente.UltimaVisita = DateTime.Today;
                //db.Clientes.Add(cliente);

                db.Clientes.Add(new Models.Cliente
                {
                    Nome = txtNome.Text,
                    endereco = txtEndere.Text,
                    ciccgc = txtCPF.Text,
                    telefone = txtTele.Text,
                    sexo = txtSexo.Text,
                    
                    UltimaVisita = DateTime.Today,
                    nascimento = Convert.ToDateTime(txtNascime.Text)
                });

                db.SaveChanges();
            }
            txtTele.Text = "";
            txtSexo.Text = "";
            txtNome.Text = "";
            txtNascime.Text = "";
            txtEndere.Text = "";
            txtCPF.Text = "";
            MessageBox.Show("Cadastrador com sucesso!");
            //using (var db = new ModelContext())
            //{
            //    var cliente = db.Clientes.First(a => a.Nome == "Max");

            //    var lista = from c in db.Clientes
            //                where c.nascimento == DateTime.Today
            //                select c.Nome;

            //    foreach (var item in db.Clientes)
            //    {

            //    }
            //}
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            ListaClientes lc = new ListaClientes();
            lc.Show();
        }
    }
}
