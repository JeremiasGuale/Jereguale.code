public abstract class Decorator : Pizza
{
    protected Pizza pizza;

    public Decorator(Pizza pizza)
    {
        this.pizza = pizza;
    }

    public override string Descripcion => pizza.Descripcion;
}