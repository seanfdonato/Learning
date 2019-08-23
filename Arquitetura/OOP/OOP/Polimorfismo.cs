using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Cafeteira : Eletrodomestico
    {
        public Cafeteira(string nome, int voltagem) : base(nome, voltagem)
        {

        }
        public Cafeteira() : base(nome: "XICO", voltagem: 220)
        {

        }

        private void FazerCafe()
        {
            Testar();
            Testar2();
        }

        public override void Testar2()
        {
            throw new NotImplementedException();
        }
        public override void Desligar()
        {
            throw new NotImplementedException();
        }

        public override void Ligar()
        {
            throw new NotImplementedException();
        }
    }
}
