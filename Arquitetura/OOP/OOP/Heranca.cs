using System;

namespace OOP
{
    public abstract class Pessoa
    {

        protected Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
    }
    //Funcionario é um PESSOA
    public class Funcionario : Pessoa
    {
        public Funcionario(string nome, int idade) : base(nome, idade)
        {

        }
        public string Cargo { get; set; }
    }

}