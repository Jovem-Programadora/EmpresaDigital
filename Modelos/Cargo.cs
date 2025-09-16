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
}
