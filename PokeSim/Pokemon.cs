// Name: Huang Junwen, Wilfred
// Admin No: 191589S
using System;

namespace PokeSim {
    // TODO for Part 1

    // Part 2a) attributes with getter and setters
    class Pokemon {
        string name;
        int hp;
        double exp;

        public string Name {
            get{return name;}
            set{name=value;}
        }

        public int HP {
            get {return hp;}
            set {hp=value;}
        }

        public double Exp {
            get {return exp;}
            set {exp=value;}
        }

        // Part 2b) Constructor and Method Override

        public Pokemon(string name) {
            this.name = name;
            hp = 100;
            exp = 0;
        }

        virtual public void Evolve() {
            Console.WriteLine("");
        }
    }

            // Part 3)

        interface Normal {
            void Runaway();
        }

        interface Electric {
            void Thunderbolt(Pokemon target);
        }

    // Part 4a)
    class Pikachu:Pokemon, Normal, Electric{
        public Pikachu(string name):
        base(name) {
        }

        public void Runaway() {
            Console.WriteLine($"{Name} is running away!");
        }

        public void Thunderbolt(Pokemon target) {
            Console.WriteLine("Pikaaachuuu");
            target.HP -= 10;
            if (target.HP < 0)
            {
                target.HP = 0;
            }
            Exp += 10;

        }
        public override void Evolve() {
            if (Exp >= 20) {
                Console.WriteLine($"{Name} has evolved into Raichu.");
            }

            else {
                Console.WriteLine($"{Name} is trying to to evolved into Raichu");
            }
        }
    }

    // part 4b)
    class Eevee:Pokemon, Normal{
        public Eevee(string name):
        base(name) {
        }

        public void Runaway() {
            Console.WriteLine($"{Name} tries to exit the battle.");
        }

        public override void Evolve(){
            string[] evolutions = {"Vaporeon", "Leafeon", "Espeon", "Umbreon", "Sylveon", "Flareon", "Jolteon"};
            Random random = new Random();
            int selected = random.Next(0, evolutions.Length);
            var evolved_form = evolutions[selected];
            Console.WriteLine($"{Name} is evolving into {evolved_form}!");


        }
    }
}