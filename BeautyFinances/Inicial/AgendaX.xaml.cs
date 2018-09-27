using Inicial.Models;
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
                cbServico.ItemsSource = db.Servicos.ToList();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (VerificaAgendamento())
            {
                using (var db = new ModelContext())
                {
                    db.Horarios.Add(new Horarios
                    {
                        idFuncionario = (int)cbFuncionario.SelectedValue,
                        idCliente = (int)cbCliente.SelectedValue,
                        IdServico = (int)cbServico.SelectedValue,

                    });
                }
            }
        }

        private bool VerificaAgendamento()
        {
            if (cbFuncionario.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um funcionário");
                return false;
            }
            if (cbCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cliente");
                return false;
            }
            if (cbServico.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um serviço");
                return false;
            }
            return true;
        }
    }
}
