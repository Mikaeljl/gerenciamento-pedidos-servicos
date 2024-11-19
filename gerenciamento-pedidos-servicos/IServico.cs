namespace gerenciamento_pedidos_servicos
{
    public interface IServico
    {
        string Descricao { get; set; }

        decimal PrecoBase { get; set; }

        int Dificuldade { get; set; }

        decimal CalcularCusto(int horas);
    }
}
