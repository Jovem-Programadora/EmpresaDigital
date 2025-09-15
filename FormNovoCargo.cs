using EmpresaDigital.Database;
using MySql.Data.MySqlClient;

namespace EmpresaDigital
{
    public partial class FormNovoCargo : Form
    {
        public FormNovoCargo()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new(DBConfiguration.conexaoString))
            {
                conexao.Open();
                string querySQL = "INSERT INTO cargos(cargo_nome) VALUES (@nome_cargo)";
                var comando = new MySqlCommand(querySQL, conexao);
                comando.Parameters.AddWithValue("@nome_cargo", txbCargo.Text);
                var resultado = comando.ExecuteNonQuery();
                if (resultado > 0)
                {
                    MessageBox.Show("O cargo foi adicionado");
                    this.Close();
                }
            }
        }
    }
}
