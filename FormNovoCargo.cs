using EmpresaDigital.Database;
using EmpresaDigital.Modelos;
using MySql.Data.MySqlClient;

namespace EmpresaDigital;

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
            try
            {
                new Cargo(txbCargo.Text).NovoCargo(conexao);
            }
            catch (Exception ex)
            {
                if(MessageBox.Show("Erro ao executar o salvamento", "Requisição falhou", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    return;
                }
            }
            this.Close();
        }
    }
}
