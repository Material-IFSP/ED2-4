using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    class Program
    {
        #region funcoes para gerar vendedor e venda    
        static int IdVendedor = 1;

        public static  Vendedor GerarVendedor()
        {
            string NomeVendedor = "";
            

            Console.WriteLine("Nome do Vendedor: ");
            NomeVendedor = Console.ReadLine();
            Vendedor vendedor1 = new Vendedor(IdVendedor, NomeVendedor);
            IdVendedor++;
            return vendedor1;
        }

        public static  Venda GerarVenda()
        {
            int quantidade, dia;
            double valor;

            Console.WriteLine("Quantidade de produtos vendidos: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor do produto Vendido: ");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o dia que foi efetuada a venda: ");
            dia = int.Parse(Console.ReadLine());

            while (dia < 1 || dia > 30)
            {
                Console.WriteLine("Informe corretamente o dia que foi efetuada a venda!");
                Console.WriteLine("Insira somente um valor entre 1 e 30: ");
                dia = int.Parse(Console.ReadLine());
            }
            Venda venda1 = new Venda(quantidade, valor, dia);

            return venda1;

        }

        #endregion



        static void Main(string[] args)
        {
            

            #region variaveis e objetos de classes
            Vendedores vendedores1 = new Vendedores();
            Vendedor vendedor1 = new Vendedor();
            int opcao, idvendedor, contVendas = 0;


            #endregion

            #region corpo do programa
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Selecione uma Opção Abaixo :\n");

                Console.WriteLine("----------//----------------------");
                Console.WriteLine("1 - Cadastrar Vendedor :");
                Console.WriteLine("2 - Consultar Vendedor :");
                Console.WriteLine("3 - Excluir Vendedor :");
                Console.WriteLine("4 - Registrar Venda :");
                Console.WriteLine("5 - Listar Vendedores :");
                Console.WriteLine("99 - SAIR :");
                Console.WriteLine("----------//----------------------");
                Console.Write("Opção: ");
                
                opcao = int.Parse(Console.ReadLine());
                
                Console.Clear();

                switch(opcao)
                {
                    case 1:
                        bool resultado = vendedores1.addVendedor(GerarVendedor());
                        Console.Clear();                     
                        if (resultado == true)
                        {
                            Console.WriteLine("O Vendedor foi Cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Não foi possivel efetuar o cadastro do funcionario! Limite Excedido!");
                        }
                        Console.ReadKey();
                    break;
                    case 2:
                        Console.Clear();
                         Console.WriteLine("Insira a Indentificação do Vendedor");
                         idvendedor = int.Parse(Console.ReadLine());
                         var vendedor = vendedores1.retornarIdVendedor(idvendedor);
                        if (vendedor != null)
                        {
                            Console.Clear();
                            Console.WriteLine("---------------------------//----------------------------------------");
                            Console.WriteLine("Nome : " + vendedor.nome +
                                "\nId: " + vendedor.id +
                                "\nvalor Total de Vendas: " + vendedor.valorVendas() +
                                "\nValor Comissão: " + vendedor.valorComissao());
                            Console.WriteLine("---------------------------//----------------------------------------");
                            foreach (var item in vendedor.AsVendas)
                            {
                                if (item.dia != 0)
                                {
                                    Console.WriteLine("Dia: " + item.dia +
                                        "\nQuantidade: " + item.qtde +
                                        "\nValor: " + item.valor +
                                        "\n");
                                }
                                else
                                {
                                    Console.WriteLine("Nenhuma Venda");
                                }
                            }
                            Console.ReadKey();
                        }
                       
                    break;
                    case 3:
                        Console.WriteLine("Insira o Id do vendedor que deseja efetuar a exclusão");
                        idvendedor = int.Parse(Console.ReadLine());
                        resultado = vendedores1.delVendedor(idvendedor);
                        if (resultado == true){
                            Console.WriteLine("Vendedor Removido com sucesso!");
                        }
                        else {
                            Console.WriteLine("Erro! Vendedor possui vendas! não pode ser removido !");
                        }
                        Console.ReadKey();


                    break;
                    case 4:
                        Console.Clear();
                        if(contVendas < 3){
                            Console.WriteLine("Insira o ID do Vendedor: ");
                            idvendedor = int.Parse(Console.ReadLine());
                            vendedores1.registarVendas(idvendedor, GerarVenda());

                            
                        }
                        Console.Clear();
                        contVendas++;
                        if (contVendas < 3){                       
                            Console.WriteLine("Venda Registrada com sucesso!");
                        }
                        else {
                            Console.WriteLine("Erro! Excedeu O limite de Vendas!");
                        }
                        Console.ReadKey();


                        break;
                    case 5:
                        Console.Clear();
                        var retornarVendedor = vendedores1.RetornarVendedores();
                        for (int i = 0; i < retornarVendedor.Length; i++)
                        {
                            if (retornarVendedor[i].id > -1)
                            {
                                Console.WriteLine("Id: " + retornarVendedor[i].id +
                                        "\nNome: " + retornarVendedor[i].nome +
                                        "\nValor Total Vendas: " + retornarVendedor[i].valorVendas() +
                                        "\nValor Comissão Devida: " + retornarVendedor[i].valorComissao() +
                                        "\n-----------------------------//---------------------------------");
                            }
                        }
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            }

            #endregion
        }
    }
}
