namespace gerenciamento_pedidos_servicos
{
    public abstract class Servico : IServico
    {
        public string Descricao { get; set; }
        public decimal PrecoBase { get; set; }
        public int Dificuldade { get; set; }

        public abstract decimal CalcularCusto(int horas);

        public virtual decimal CalcularPrecoBase(int horas)
        {
            return PrecoBase * horas;
        }
    }
}
