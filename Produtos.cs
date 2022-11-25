using Aplicação;
using System;
using Listas;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace Vendas
{
    public class Produtos
    {
        public decimal Dinheiro { get; set; } = 30.00m;
        public decimal Banana { get; set; } = 10.90m;
        public decimal Abacate { get; set; } = 8.90m;
        public decimal Abacaxi { get; set; } = 11.90m;
        public decimal Limão { get; set; } = 22.95m;
        public decimal Uva { get; set; } = 2.00m;

        public Produtos()
        {
            
        }
        public Produtos(decimal dinheiro, decimal banana, decimal abacate, decimal abacaxi, decimal limão, decimal uva)
        {
            Dinheiro = dinheiro;
            Banana = banana;
            Abacate = abacate;
            Abacaxi = abacaxi;
            Limão = limão;
            Uva = uva;
        }
    }
    public class ProdutoBanana : Produtos
    {

        public decimal Frutas(decimal valor)
        {
            valor = Dinheiro - Banana;
            Console.WriteLine("Você comprou a banana. Saldo: "+ valor);
            return valor;
        }
    }
    class ProdutoAbacate : Produtos
    {
        public decimal Frutas(decimal valor)
        {
            valor = Dinheiro - Abacate;
            Console.WriteLine("\nVocê comprou o Abacate. Saldo: " + valor);
            return valor;
        }
    }
    class ProdutoAbacaxi : Produtos
    {
        public decimal Frutas(decimal valor)
        {
            valor = Dinheiro - Abacaxi;
            Console.WriteLine("\nVocê comprou o Abacaxi. Saldo: " + valor);
            return valor;
        }
    }
    class ProdutoLimão : Produtos
    {
        public decimal Frutas(decimal valor)
        {
            valor = Dinheiro - Limão;
            Console.WriteLine("\nVocê comprou o limão. Saldo: " + valor);
            return valor;
        }
    }
    class ProdutoUva : Produtos
    {
        public decimal Frutas(decimal valor)
        {
            valor = Dinheiro - Uva;
            Console.WriteLine("\nVocê comprou a uva. Saldo: " + valor);
            return valor;
        }
    }
}
