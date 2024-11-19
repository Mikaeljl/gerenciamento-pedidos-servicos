namespace gerenciamento_pedidos_servicos
{
    public interface IClienteServico
    {
        string TipoCliente { get; set; }

        decimal AplicarDesconto(decimal valor);
    }
}
