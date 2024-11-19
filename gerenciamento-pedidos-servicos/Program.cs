using System;

namespace gerenciamento_pedidos_servicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicoLimpeza limpeza = new ServicoLimpeza
            {
                Descricao = "Limpeza Geral",
                PrecoBase = 100,
                Dificuldade = 6
            };

            ServicoManutencao manutencao = new ServicoManutencao
            {
                Descricao = "Manutenção de Equipamentos",
                PrecoBase = 150,
                Dificuldade = 3
            };

            ServicoSuporteTecnico suporteTecnico = new ServicoSuporteTecnico
            {
                Descricao = "Suporte Técnico Noturno",
                PrecoBase = 200,
                Dificuldade = 2,
                Noturno = true
            };

            Cliente clienteResidencial = new Cliente { TipoCliente = "Residencial" };
            Cliente clienteComercial = new Cliente { TipoCliente = "Comercial" };

            PedidoServico pedidoResidencial = new PedidoServico(clienteResidencial);
            pedidoResidencial.ListaServicos.Add(limpeza);
            pedidoResidencial.ListaServicos.Add(manutencao);
            pedidoResidencial.ListaServicos.Add(suporteTecnico);

            PedidoServico pedidoComercial = new PedidoServico(clienteComercial);
            pedidoComercial.ListaServicos.Add(limpeza);
            pedidoComercial.ListaServicos.Add(manutencao);
            pedidoComercial.ListaServicos.Add(suporteTecnico);

            Console.WriteLine("Pedido Residencial:");
            pedidoResidencial.ExibirResumoServico();

            Console.WriteLine("\nPedido Comercial:");
            pedidoComercial.ExibirResumoServico();

            Console.ReadLine();
        }
    }
}
