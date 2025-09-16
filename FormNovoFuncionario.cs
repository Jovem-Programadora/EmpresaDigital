using EmpresaDigital.Database;
using MySql.Data.MySqlClient;
using System.Data;

namespace EmpresaDigital
{
    public partial class FormNovoFuncionario : Form
    {
        public FormNovoFuncionario()
        {
            InitializeComponent();
        }

        private void FormNovoFuncionario_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new(DBConfiguration.conexaoString))
            {
                conexao.Open();
                string querySQL = "SELECT cargo_id AS ID, cargo_nome AS Cargo FROM cargos";
                MySqlCommand comando = new(querySQL, conexao);
                MySqlDataAdapter adaptador = new(comando);
                DataTable tabelaCargos = new();
                adaptador.Fill(tabelaCargos);
                cboCargos.DataSource = tabelaCargos;
                cboCargos.DisplayMember = "Cargo";
                cboCargos.ValueMember = "ID";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new(DBConfiguration.conexaoString))
            {
                string querySQL = "INSERT INTO funcionarios(funcionario_nome, cargo_id) VALUES(@nome_funcionario, @cargo_id)";
                conexao.Open();
                MySqlCommand comando = new(querySQL, conexao);
                comando.Parameters.AddWithValue("@nome_funcionario", txbNomeFuncionario.Text);
                comando.Parameters.AddWithValue("@cargo_id", cboCargos.SelectedValue);
                if (comando.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Funcionário adicionado com sucesso.", "Operação Sucedida");
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
