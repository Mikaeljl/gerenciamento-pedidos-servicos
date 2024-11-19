namespace gerenciamento_pedidos_servicos
{
    public class ServicoLimpeza : Servico
    {
        public override decimal CalcularCusto(int horas)
        {
            decimal custoBase = CalcularPrecoBase(horas);
            if (Dificuldade > 5)
            {
                custoBase += 30.00m;
            }
            return custoBase;
        }
    }
}
