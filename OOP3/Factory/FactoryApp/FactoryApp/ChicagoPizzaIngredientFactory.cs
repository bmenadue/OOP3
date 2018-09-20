using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryApp.Ingredients;

namespace FactoryApp
{
    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {

        public Dough createDough()
        {
            return new ThickCrust();
        }

        public Sauce createSauce()
        {
            return new PlumTomatoeSauce();
        }

        public Cheese createCheese()
        {
            return new MozzarellaCheese();
        }

        public List<Veggies> createVeggies()
        {
            List<Veggies> veggies = new List<Veggies>{ new BlackOlives(), new Spinach(), new Eggplant() };
            return veggies;
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams createClams()
        {
            return new FrozenClams();
        }
    }
}
