using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace EmpresaDigital.Modelos;

internal class Cargo
{
    private int id;
    private string nome;

    public Cargo(string nome) 
    { // Para quando o cargo ainda nao foi criado
        this.nome = nome;
    }

    public Cargo(int id, string nome)
    {// Para quando os cargos já foram criados
        this.id = id;
        this.nome = nome;
    }

    public void NovoCargo(MySqlConnection conexao)
    {
        conexao.Open();
        string querySQL = "INSERT INTO cargos(cargo_nome) VALUES (@nome_cargo)";
        var comando = new MySqlCommand(querySQL, conexao);
        comando.Parameters.AddWithValue("@nome_cargo", this.nome);
        var resultado = comando.ExecuteNonQuery();
        if (resultado > 0)
        {
            MessageBox.Show($"O cargo {this.nome} foi adicionado com sucesso");
        } else
        {
            throw new Exception("Não foi possivel criado o cargo solicitado");
        }
    }

    public static DataTable CarregarCargos(MySqlConnection conexao)
    {
        conexao.Open();
        string querySql = "SELECT cargo_nome AS Cargo FROM cargos";
        MySqlCommand comando = new(querySql, conexao);
        MySqlDataAdapter adaptador = new(comando);
        DataTable tabelaCargos = new();
        adaptador.Fill(tabelaCargos);
        return tabelaCargos;
    }
}
