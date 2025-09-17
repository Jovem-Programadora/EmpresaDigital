using EmpresaDigital.Database;
using EmpresaDigital.Modelos;
using MySql.Data.MySqlClient;
using System.Data;

namespace EmpresaDigital;

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
            try
            {
                cboCargos.DataSource = Cargo.CarregarCargos(conexao);
                cboCargos.DisplayMember = "Cargo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os cargos");
            }
        }
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        //TODO: Criar a ação de salvar o Funcionario
    }

    private void btnVoltar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
