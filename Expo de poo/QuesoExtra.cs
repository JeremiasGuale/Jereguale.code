public class QuesoExtra : Decorator
{
    public QuesoExtra(Pizza pizza) : base(pizza) { }

    public override double Costo()
    {
        return pizza.Costo() + 1.99;
    }

    public override string Descripcion => pizza.Descripcion + ", Queso Extra";
}
