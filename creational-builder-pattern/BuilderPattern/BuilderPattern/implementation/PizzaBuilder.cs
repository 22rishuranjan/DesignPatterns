using BuilderPattern.interfaces;
using BuilderPattern.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.implementation
{
    public class PizzaBuilder : IPizzaBuilder
    {
        private readonly Pizza _pizza;

        public PizzaBuilder()
        {
            _pizza = new Pizza();
        }

        public void SetDough(string dough)
        {
            _pizza.Dough = dough;
        }

        public void SetSauce(string sauce)
        {
            _pizza.Sauce = sauce;
        }

        public void SetTopping(string topping)
        {
            _pizza.Topping = topping;
        }

        public Pizza Build()
        {
            return _pizza;
        }
    }
}
