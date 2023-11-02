class Comida
{
    public string Nombre {get; set;}
    public int Calorias {get; set;}
    public bool Picante {get; set;}
    public bool Dulce {get; set;}

    public Comida(string n, int c, bool p, bool d)
    {
        Nombre = n;
        Calorias = c;
        Picante = p;
        Dulce = d;
    }
}

class Buffet
{
    public List<Comida> Menu;

    //constructor
    public Buffet()
    {
        Menu = new List<Comida>()
        {
            new("Sushi", 300, false, false),
            new("Pizza", 500, false, false),
            new("Pebre", 200, true, false),
            new("Hamburguesa", 800, false, true),
            new("Ensalada", 150, false, false),
            new("Maruchan Hot Spacy", 350, true, false),
            new("Torta", 400, false, true),
            new("Lasaña", 550, false, false),
            new("Takis", 250, true, false),
            new("Ñachi", 350, true, true)
        };
    }

    public Comida Serve()
    {
        Random random = new();
        int index = random.Next(Menu.Count);
        return Menu[index];
    }
}

class Ninja
{
    private int calorieIntake ;
    public List<Comida> FoodHistory;

    public Ninja()
    {
        calorieIntake  = 0;
        FoodHistory = new List<Comida>();
    }

    public bool IsFull
    {
        get { return calorieIntake  > 1200; }
    }

    public void Comer(Comida item)
    {
        if (!IsFull)
        {
            calorieIntake  += item.Calorias;
            FoodHistory.Add(item);
            Console.WriteLine($"El ninja comió {item.Nombre}. Estaba picante?: {(item.Picante ? "Sí" : "No")}. ||  Estaba dulce?: {(item.Dulce ? "Sí" : "No")}");
        }
        else
        {
            Console.WriteLine("El Ninja está que revienta, no puede comer más!");
        }
    }
}