# Ninja Hambriento

Repositorio publico para el bootcamp de Coding Dojo.
.
<h2>Objetivo:</h2>
    <li>Construir una clase utilizando conceptos de POO en C#.​​​</li>
    <li>Construir campos y métodos dentro de las clases.​​</li>
    <li>Ilustrar los usos de los modificadores de accesibilidad.​​​​</li>
    <li>Demostrar cómo las clases pueden interactuar mediante la creación de instancias de una clase en otra o la construcción de funciones que esperan objetos de clase como parámetros. ​​​</li>

<h2>Instrucciones</h2>

<p>En base a lo que hemos aprendido de la tarea Humano, vamos a explorar cómo diferentes clases pueden interactuar entre sí utilizando propiedades privadas, getters públicos y métodos de clase.​

Para el ninja que se toma un descanso para comer, ¡está el Ninja Buffet! Todo lo que puedas comer, sabores atrevidos y calorías deliciosas para los ninjas trabajadores de este mundo. Ten en cuenta que revisaremos tu trabajo aquí en una tarea posterior.​​​<p>

<h2>Tareas</h2>

<h3>Crea una clase <code>Food</code></h3>

```cs
class Food
{
    public string Name;
    public int Calories;
    public bool IsSpicy; 
    public bool IsSweet; 
}
```

<h3>Crea una clase <code>Buffet</code> que contedrá un Menú <code>Food</code></h3>

```csharp
class Buffet
{
    public List<Food> Menu;
     
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Example", 1000, false, false)
        };
    }
     
    public Food Serve()
    {
    }
}
```

<h3>Crea una clase <code>Ninja</code></h3>

```csharp
class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;
     
    // add a constructor
     
    // add a public "getter" property called "IsFull"
     
    // build out the Eat method
    public void Eat(Food item)
    {
    }
}
```
</br>
<ul>
    <li>Agregar un constructor a la clase Comida</li>
    <li>En la clase Buffet, configure Menú en una lista codificada de 7 o más objetos de Comida que cree instancias manualmente</li>
    <li>En la clase Buffet, cree un método 'Serve' que seleccione aleatoriamente un objeto Comida de la lista Menú y devuelva el objeto Comida</li>
    <li>En la clase Ninja, agregue un constructor que establezca el consumo de calorías en 0 y cree una lista nueva y vacía de objetos de Alimentos en FoodHistory.</li>
    <li>En la clase Ninja, agregue una propiedad pública "getter" llamada "IsFull" que devuelve un valor booleano basado en si la ingesta de calorías del Ninja es mayor a 1200 calorías.</li>
    <li>Desarrolle el método "Eat" de la clase Ninja para que, si el Ninja no está lleno, agregue las calorías a la ingesta de calorías, agregue la comida al Historial de alimentos e imprima el nombre de la comida y si está o no. Picante o Dulce a la consola.</li>
    <li>Termine de desarrollar el método "Eat" de la clase Ninja para que, si el Ninja está lleno, se imprima una advertencia en la consola.</li>
    <li>En tu clase de program.cs, crea una instancia de un objeto Buffet y Ninja, ¡y haz que el Ninja coma hasta que esté lleno!</li>
</ul>
