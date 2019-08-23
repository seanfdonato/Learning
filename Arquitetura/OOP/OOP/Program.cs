using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var funcionario = new Funcionario("nome", 30);
            funcionario.Cargo = "Operador";
            funcionario.Idade = 25;
            funcionario.Nome = "Chico bateu no bode";

            //var pessoa = new Pessoa();
            //pessoa.idade = 35;
            //pessoa.nome = "Ze";
        }
    }
}
