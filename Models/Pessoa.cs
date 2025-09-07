namespace Models;

public class Pessoa
{
    private string _nome;
    private string _sobrenome;

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public string Nome
    {
        get => _nome;

        set
        {
            if (value == "")
            {
                throw new ArgumentException("O nome não pode ser vazio.");
            }
            _nome = value;
        }
    }


    public string Sobrenome
    {
        get => _sobrenome;

        set
        {
            if (value == "")
            {
                throw new ArgumentException("O sobrenome não pode ser vazio.");
            }
            _sobrenome = value;
        }
    }
}
