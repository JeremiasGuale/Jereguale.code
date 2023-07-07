// Clase base de Pizza
public abstract class Pizza
{
    public abstract string Descripcion { get; }

    public abstract double Costo();
}

// Implementación concreta de Pizza
public class PizzaMargherita : Pizza
{
    public override string Descripcion => "Pizza Margherita";

    public override double Costo()
    {
        return 5.99;
    }
}