using FactoryApp.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp
{
    public interface PizzaIngredientFactory
    {
        Dough createDough();
        Sauce createSauce();
        Cheese createCheese();
        List<Veggies> createVeggies();
        Pepperoni createPepperoni();
        Clams createClams();
    }
}
