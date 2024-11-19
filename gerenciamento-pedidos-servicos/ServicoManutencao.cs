namespace gerenciamento_pedidos_servicos
{
    public class ServicoManutencao : Servico
    {
        public override decimal CalcularCusto(int horas)
        {
            decimal custoBase = CalcularPrecoBase(horas);
            if (horas > 8)
            {
                custoBase *= 0.90m;
            }
            return custoBase;
        }
    }
}
