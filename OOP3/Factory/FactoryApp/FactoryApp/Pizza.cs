using FactoryApp.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp
{
    public abstract class Pizza
    {
        public Dough dough;
        public Sauce sauce;
        public List<Veggies> veggies;
        public Cheese cheese;
        public Pepperoni pepperoni;
        public Clams clam;

        public string Name { get; set; }

        public virtual void Prepare()
        {
        }

        public void bake()
        {
            Console.WriteLine("Baking " + Name);
        }

        public void cut()
        {
            Console.WriteLine("Cutting " + Name);
        }

        public void box()
        {
            Console.WriteLine("Boxing " + Name);
        }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("---- " + Name + " ----\n");
            if (dough != null)
            {
                result.Append(dough);
                result.Append("\n");
            }
            if (sauce != null)
            {
                result.Append(sauce);
                result.Append("\n");
            }
            if (cheese != null)
            {
                result.Append(cheese);
                result.Append("\n");
            }
            if (veggies != null)
            {
                for (int i = 0; i < veggies.Count; i++)
                {
                    result.Append(veggies[i]);
                    if (i < veggies.Count - 1)
                    {
                        result.Append(", ");
                    }
                }
                result.Append("\n");
            }
            if (clam != null)
            {
                result.Append(clam);
                result.Append("\n");
            }
            if (pepperoni != null)
            {
                result.Append(pepperoni);
                result.Append("\n");
            }
            return result.ToString();
        }
        
    }
}
