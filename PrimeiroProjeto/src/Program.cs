using System;
using projeto.entities;

namespace projeto
{
    public class PrimeiroProjeto
    {
        static void Main(String[] args)
        {
            Heroi h1 = new Heroi("Gabriel", 100, 100, 100);
            HeroiTerra h2 = new HeroiTerra("Paulo", 100, 75, 75);

            Console.WriteLine(h1.atacar());
            Console.WriteLine(h2.atacar());
            Console.WriteLine(h1.apresentar());
        }

    }

}