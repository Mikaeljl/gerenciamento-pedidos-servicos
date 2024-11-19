namespace gerenciamento_pedidos_servicos
{
    public class ServicoSuporteTecnico : Servico
    {
        public bool Noturno { get; set; }

        public override decimal CalcularCusto(int horas)
        {
            decimal custoBase = CalcularPrecoBase(horas);
            if (Noturno)
            {
                custoBase *= 1.20m;
            }
            return custoBase;
        }
    }
}
