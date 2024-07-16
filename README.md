# Assignment 1 Advanced Programming Module IT2154

## Pokemon Battle Mini-game
This is what i submitted for Assignment 1 of Advanced Programming Module, the files contain all the correct answers for the request 'pokemon' game program which make up 30% of the module

It is a mini-game coded in c# to simulate 'pokemon' battles , a pokemon can perform their special attacks and deal damage to the opponent, when the opponent health points reaches 0, the game ends.
When they have enough experience point(exp) gained after defeating an enemy, they can evolve into another form.

The purpose of this assignment is to demonstrate the use of Object-Oriented Principles, namely Class, Object, Inheritance, Abstraction and Polymorphism.

Inheritance:

```
// Pikachu and Eevee classes inherit from a base Pokemon class. This demonstrates code reuse and extension of base class functionality.

public class Pikachu : Pokemon {
    public Pikachu(string name) : base(name) {
    }

    public void Thunderbolt(Pokemon target) {
        // Implementation of Thunderbolt attack
        target.HP -= 10;
        Console.WriteLine($"{Name} used Thunderbolt on {target.Name}!");
    }
}

public class Eevee : Pokemon {
    public Eevee(string name) : base(name) {
    }
}


```

Polymorphism:

```
// Both Pikachu and Eevee implement a common interface or base class method, such as Runaway(). This allows for treating different objects uniformly.

public interface Normal {
}

public class Pikachu : Pokemon, Normal {
    public void Runaway() {
        Console.WriteLine($"{Name} ran away!");
    }
}

public class Eevee : Pokemon, Normal {
    public void Runaway() {
        Console.WriteLine($"{Name} tries to exit the battle.");
    }
}

```
Abstraction 
```
// The base Pokemon class defines common properties and methods, providing a simple interface for derived classes.
// This hides complex implementation details and provide a clear interface for derived classes.

public abstract class Pokemon {
    public string Name { get; private set; }
    public int HP { get; protected set; }
    public int Exp { get; protected set; }

    public Pokemon(string name) {
        Name = name;
        HP = 100;
        Exp = 0;
    }

    public abstract void Evolve();
}

```
