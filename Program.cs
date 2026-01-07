//Method Hiding Example in C#

class Animal {
    public  void Speak() {
        Console.WriteLine("Animal Speaks!");
    }
}

class Dog : Animal {
    public new void Speak()
    {
        Console.WriteLine("Dog Barks!");
    }
}

class Program {
    public static void Main(string[] args) {
        Animal a = new Dog();
        Dog b = new Dog();
        a.Speak();  // Outputs: Animal Speaks!
        b.Speak();  // Outputs: Dog Barks!
    }
}
