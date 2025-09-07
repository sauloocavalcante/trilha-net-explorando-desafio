namespace Models;

public class Suite
{
    private string _tipoSuite;
    private int _capacidade;
    private decimal _valorDiaria;

    public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
    {
        TipoSuite = tipoSuite;
        Capacidade = capacidade;
        ValorDiaria = valorDiaria;
    }

    public string TipoSuite
    {
        get => _tipoSuite;

        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O tipo da suíte não pode ser vazio ou nulo.");
            _tipoSuite = value;
        }
    }

    public int Capacidade
    {
        get => _capacidade;

        set
        {
            if (value <= 0)
                throw new ArgumentException("A capacidade deve ser maior que zero.");
            _capacidade = value;
        }
    }

    public decimal ValorDiaria
    {
        get => _valorDiaria;

        set
        {
            if (value < 0)
                throw new ArgumentException("O valor da diária não pode ser negativo.");
            _valorDiaria = value;
        }
    }
}
