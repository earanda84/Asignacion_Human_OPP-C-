// Create a Human class with four public fields: Name (string) , Strength (int), Intelligence (int), Dexterity (int)
class Human
{
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;
    public Human(string name, int strength = 3, int intelligence = 3, int dexterity = 3, int health = 100)
    {
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        Health = health;
    }

    public int Attack(Human target){
        
        int damage = 3 * Strength;
        target.Health -= damage;

        return target.Health;
        
    }
}