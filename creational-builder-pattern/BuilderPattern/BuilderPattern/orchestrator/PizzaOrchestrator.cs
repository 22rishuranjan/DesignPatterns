using BuilderPattern.interfaces;
using BuilderPattern.product;

namespace BuilderPattern.orchestrator
{
    internal class PizzaOrchestrator
    {

        private readonly IPizzaBuilder _builder;

        public PizzaOrchestrator(IPizzaBuilder builder)
        {
            _builder = builder;
        }

        public Pizza BuildMargheritaPizza()
        {
            _builder.SetDough("thin");
            _builder.SetSauce("tomato");
            _builder.SetTopping("mozzarella");
            return _builder.Build();
        }

        public Pizza BuildPepperoniPizza()
        {
            _builder.SetDough("thick");
            _builder.SetSauce("barbecue");
            _builder.SetTopping("pepperoni");
            return _builder.Build();
        }
    }
}
