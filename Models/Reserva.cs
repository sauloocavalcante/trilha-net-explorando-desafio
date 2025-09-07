namespace Models;

public class Reserva
{
    private List<Pessoa> _hospedes;
    private Suite _suite;
    private int _diasReservados;

    public Reserva(int diasReservados)
    {
        _diasReservados = diasReservados;
    }
    public Reserva()
    {
        _hospedes = new List<Pessoa>();
        _suite = null;
        _diasReservados = 0;
    }

    public Reserva(Suite suite, List<Pessoa> hospedes, int diasReservados)
    {
        _hospedes = hospedes ?? new List<Pessoa>();
        _suite = suite;
        _diasReservados = diasReservados;
    }

    public List<Pessoa> Hospedes
    {
        get => _hospedes;
    }

    public Suite Suite
    {
        get => _suite;
    }

    public int DiasReservados
    {
        get => _diasReservados;

        set
        {
            _diasReservados = value;
        }
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (hospedes == null || hospedes.Count == 0)
        {
            throw new ArgumentException("A lista de hóspedes não pode ser nula ou vazia.");
        }

        _hospedes = hospedes;
    }

    public void CadastrarSuite(Suite suite)
    {
        if (_hospedes == null || _hospedes.Count == 0)
        {
            throw new InvalidOperationException("Não é possível cadastrar uma suíte sem hóspedes.");
        }

        if (_hospedes.Count > suite.Capacidade)
        {
            throw new ArgumentException("A quantidade de hóspedes não pode ser maior que a capacidade da suíte.");
        }

        _suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {

        decimal valorTotal = Suite.ValorDiaria * DiasReservados;

        if (DiasReservados > 10)
        {
            return valorTotal *= 0.9m;
        }

        return valorTotal;
    }
}
