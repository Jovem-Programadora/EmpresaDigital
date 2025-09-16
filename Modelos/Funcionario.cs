namespace EmpresaDigital.Modelos;

internal class Funcionario
{
    private int id;
    private string nome;
    private Cargo cargo;

    public Funcionario(string nome, Cargo cargo)
    {
        this.nome = nome;
        this.cargo = cargo;
    }

    public Funcionario(int id, string nome, Cargo cargo)
    {
        this.id = id;
        this.nome = nome;
        this.cargo = cargo;
    }
}
