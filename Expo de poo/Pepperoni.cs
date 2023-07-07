public class Pepperoni : Decorator
{
    public Pepperoni(Pizza pizza) : base(pizza) { }

    public override double Costo()
    {
        return pizza.Costo() + 2.49;
    }

    public override string Descripcion => pizza.Descripcion + ", Pepperoni";
}