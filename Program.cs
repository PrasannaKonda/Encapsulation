//Method Overriding Example in C#
//Overriding is calling the derived class behaviour using a base class reference.
class Animal {
    public virtual void Speak() {
        Console.WriteLine("Animal Speaks!");
    }
}

class Dog : Animal {
    public override void Speak()
    {
        Console.WriteLine("Dog Barks!");
    }
}

class Program {
    public static void Main(string[] args) {
        Animal a = new Animal();
        Animal b = new Dog();
        a.Speak();  // Outputs: Animal Speaks!
        b.Speak();  // Outputs: Dog Barks!
    }
}
