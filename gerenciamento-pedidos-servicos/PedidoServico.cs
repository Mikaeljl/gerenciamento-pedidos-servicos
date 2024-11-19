using System;
using System.Collections.Generic;

namespace gerenciamento_pedidos_servicos
{
    public class PedidoServico
    {
        public IClienteServico Cliente { get; set; }
        public List<IServico> ListaServicos { get; set; }

        public PedidoServico(IClienteServico cliente)
        {
            Cliente = cliente;
            ListaServicos = new List<IServico>();
        }

        public decimal CalcularTotalServico()
        {
            decimal total = 0;
            foreach (var servico in ListaServicos)
            {
                total += servico.CalcularCusto(2);
            }
            return Cliente.AplicarDesconto(total);
        }

        public void ExibirResumoServico()
        {
            Console.WriteLine($"Resumo do Pedido para Cliente {Cliente.TipoCliente}");
            foreach (var servico in ListaServicos)
            {
                decimal custo = servico.CalcularCusto(2);
                Console.WriteLine($"Serviço: {servico.Descricao}, Custo: R${custo}");
            }
            Console.WriteLine($"Total com desconto: R${CalcularTotalServico()}");
        }
    }
}
