using Listas;
using System;
using Vendas;

namespace Aplicação
{
    public class App
    {
        public App()
        {

        }
        public static void Application(Login cliente)
        {
            Produtos produt = new Produtos();

            ProdutoBanana banana = new ProdutoBanana();
            ProdutoAbacate abacate = new ProdutoAbacate();
            ProdutoAbacaxi abacaxi = new ProdutoAbacaxi();
            ProdutoLimão limão = new ProdutoLimão();
            ProdutoUva uva = new ProdutoUva();

            Console.WriteLine($"Cadastro realizado com sucesso!\n");
            Console.WriteLine($"Bem vindo, {cliente.Clientname}!\n");
            Console.WriteLine($"Carteira: R${produt.Dinheiro}");

            Console.WriteLine("Qual produto deseja comprar?\n");
            Console.WriteLine("1 - Banana, R$ 10,90 kg");
            Console.WriteLine("2 - Abacate, R$ 8,90 kg");
            Console.WriteLine("3 - Abacaxi, R$ 11,90 kg");
            Console.WriteLine("4 - Limão, R$ 22,95 kg");
            Console.WriteLine("5 - Uva, R$ 2,00 kg");

            char produto = Console.ReadKey().KeyChar;

            switch (produto)
            {
                case '1':
                    banana.Frutas(produt.Dinheiro);
                    break;
                case '2':
                     abacate.Frutas(produt.Dinheiro);
                    break;
                case '3':
                      abacaxi.Frutas(produt.Dinheiro);
                    break;
                case '4':
                      limão.Frutas(produt.Dinheiro);
                    break;
                case '5':
                       uva.Frutas(produt.Dinheiro);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("AVISO: Digite a opção correta\n");
                    Application(cliente);
                    break;
            }
        }
    }
}