namespace gerenciamento_pedidos_servicos
{
    public class Cliente : IClienteServico
    {
        public string TipoCliente { get; set; }

        public decimal AplicarDesconto(decimal valor)
        {
            if (TipoCliente == "Comercial")
            {
                return valor * 0.85m;
            }
            else
            {
                return valor * 0.95m;
            }
        }
    }
}
