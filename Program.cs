// Add a constructor method that takes a string to initialize Name - and that will initialize Strength, Intelligence, and Dexterity to a default value of 3, and health to default value of 100
string name = "Andrea";
Console.WriteLine("******** PERSON 1 *********");

Human person1 = new Human(name);
Console.WriteLine($"Nombre: {person1.Name}");
Console.WriteLine($"Fuerza: {person1.Strength}");
Console.WriteLine($"Inteligencia: {person1.Intelligence}");
Console.WriteLine($"Destreza: {person1.Dexterity}");
Console.WriteLine($"Salud: {person1.Health}");

Console.WriteLine("******** PERSON 2 *********");
Human person2 = new Human("Jhon", 5,5,5,100);
Console.WriteLine($"Nombre: {person2.Name}");
Console.WriteLine($"Fuerza: {person2.Strength}");
Console.WriteLine($"Inteligencia: {person2.Intelligence}");
Console.WriteLine($"Destreza: {person2.Dexterity}");
Console.WriteLine($"Salud: {person2.Health}");

Console.WriteLine("******** DAMAGE *********");
Console.WriteLine($"Salud antes del ataque de la persona 1: {person2.Health}");
person1.Attack(person2);
Console.WriteLine($"Salud restante de la persona2: {person2.Health}");