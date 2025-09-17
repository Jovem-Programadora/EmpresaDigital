using EmpresaDigital.Database;
using EmpresaDigital.Modelos;
using MySql.Data.MySqlClient;
using System.Data;

namespace EmpresaDigital
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnVerCargos_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new(DBConfiguration.conexaoString))
            {
                try
                {
                    dgvVisualizador.DataSource = Cargo.CarregarCargos(conexao);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro tentando abrir o banco de dados: {ex.Message}");
                }
            }
        }

        private void btnNovoCargo_Click(object sender, EventArgs e)
        {
            new FormNovoCargo().ShowDialog();
            // Ao fechar a janela os codigo abaixo sao executados
            btnVerCargos_Click(sender, e);

        }

        private void btnVerFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexao = new(DBConfiguration.conexaoString))
                {
                    conexao.Open();
                    string querySQL = "SELECT funcionario_nome AS Funcionario, cargos.cargo_nome AS Cargo FROM funcionarios JOIN cargos ON funcionarios.cargo_id = cargos.cargo_id";
                    MySqlCommand comando = new(querySQL, conexao);
                    MySqlDataAdapter adaptador = new(comando);
                    DataTable tabelaFuncionarios = new();
                    adaptador.Fill(tabelaFuncionarios);
                    dgvVisualizador.DataSource = tabelaFuncionarios;
                }
            }
            catch (Exception ex)
            {
                if(MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro na solicitação", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    btnVerFuncionario_Click(sender, e);
                }
            }
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            new FormNovoFuncionario().ShowDialog();
        }
    }
}
