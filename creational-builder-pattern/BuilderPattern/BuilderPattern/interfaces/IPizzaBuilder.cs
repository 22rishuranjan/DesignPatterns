using BuilderPattern.product;

namespace BuilderPattern.interfaces
{
    public interface IPizzaBuilder
    {
        void SetDough(string dough);
        void SetSauce(string sauce);
        void SetTopping(string topping);
        Pizza Build();
    }
}
