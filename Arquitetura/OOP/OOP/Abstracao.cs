using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public abstract class Eletrodomestico
    {
        private readonly string nome;
        private readonly int voltagem;
        //So tem acesso ao construtor quem herda
        protected Eletrodomestico(string nome, int voltagem)
        {
            this.nome = nome;
            this.voltagem = voltagem;
        }
        //Deve ser sobrescrito. Não implementado
        public abstract void Ligar();
        public abstract void Desligar();
        //Não pode ser modificado
        public void Testar()
        {
            //implementado
        }
        //Pode ser modificado
        public virtual void Testar2()
        {
            //implementado
        }
    }
}
