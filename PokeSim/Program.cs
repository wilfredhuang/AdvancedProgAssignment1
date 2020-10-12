// Name: Huang Junwen, Wilfred
// Admin No: 191589S

using System;
using System.Collections.Generic;
namespace PokeSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PokeSim!");
            // uncomment the following for testing
            var pikachu = new Pikachu("Pikachu");
            var eevee = new Eevee("Eevee");

            pikachu.Thunderbolt(eevee);
            pikachu.Thunderbolt(eevee);

            List<Pokemon> pokemons = new List<Pokemon>();
            pokemons.Add(pikachu);
            pokemons.Add(eevee);

            foreach (var pokemon in pokemons) {
                Console.WriteLine($"Name:{pokemon.Name},HP:{pokemon.HP},Exp:{pokemon.Exp}");
                pokemon.Evolve();
            }

            List<Normal> normals = new List<Normal>();
            normals.Add(pikachu);
            normals.Add(eevee);
            foreach (var normal in normals) {
                normal.Runaway();
            }
        }
    }
}
