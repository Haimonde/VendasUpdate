using System;
using System.Collections.Generic;
using Listas;
using Aplicação;

namespace Listas
{
    public class Raiz
    {
        static void Main(string[] args)
        {
            Program.Dadosdoadministrador.Add(new Login { Clientname = "Admin", Password = "Admin123" });

            Program.Cliente();
            Console.ReadKey();
        }
    }
    public class Program
    {
        public static List<Login> Dadosdoadministrador = new List<Login>();
        public static List<Login> Dadosdocliente = new List<Login>();
        public static void Cliente()
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua senha");
            string senha = Console.ReadLine();

            Login cliente = null;

            foreach (Login ndc in Dadosdoadministrador)
            {
                if (ndc.Clientname == nome && ndc.Password == senha)
                {
                    cliente = ndc;
                    Console.Clear();
                    App.Application(cliente);
                }
                else if (ndc.Clientname != nome && ndc.Password != senha)
                {
                    Console.Clear();
                    Console.WriteLine("Usuário e senha incorretos!\n");
                    Cadastrocliente();
                }
                else if (ndc.Clientname != nome && ndc.Password == senha)
                {
                    Console.Clear();
                    Console.WriteLine("Nome errado!\n");
                    Cadastrocliente();
                }
                else if (ndc.Password != senha && ndc.Clientname == nome)
                {
                    Console.Clear();
                    Console.WriteLine("Senha errada!\n");
                    Cadastrocliente();
                }  
            }
        }
        public static void Cadastrocliente()
        {
            Console.WriteLine("Você ainda não tem uma conta no App!");
            Console.WriteLine("Deseja cadastrar-se? [S/N]\n");
            char cadastro = Console.ReadKey().KeyChar;

            if (cadastro == 'S' || cadastro =='s')
            {
                Console.Clear();
                Console.WriteLine("Cadastre seu novo nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Cadastre sua nova senha");
                string senha = Console.ReadLine();

                Login cliente = null;

                Dadosdocliente.Add(new Login { Clientname = nome, Password = senha });

                foreach (Login lg in Dadosdocliente)
                {
                    if (lg.Clientname == nome && lg.Password == senha)
                    {
                        cliente = lg;
                        Console.Clear();
                        App.Application(cliente);
                    }
                }
            }
            else
            Environment.Exit(0);
        }
    }
    public class Login
    {
        public string Clientname { get; set; }
        public string Password { get; set; }

        public Login()
        {

        }
        public Login(string clientname, string password) : this()
        {
            Clientname = clientname;
            Password = password;
        }
    }
}