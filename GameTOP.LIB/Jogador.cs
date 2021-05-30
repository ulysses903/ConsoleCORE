using System;

namespace GameTOP.LIB
{
    public class Jogador
    {
        public string Nome { get; set; }

        public Jogador(string nome)
        {
            Nome = nome;
        }

        public void Chuta()
        {
            Console.Write($"{Nome} está Chutando.\n");
        }

        public void Passa()
        {
            Console.Write($"{Nome} está Passando.\n");
        }

    }
}