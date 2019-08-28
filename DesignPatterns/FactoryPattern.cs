using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class FactoryPattern
    {
        public static void Main() { 
        PizzaStore nypi = new NyPizzaStore();
        nypi.orderPizza ("cheese");
        }

    }

    abstract class PizzaStore
    {
        public  void orderPizza(string type)
        {
            Pizza pizza;
           pizza= create(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.parcel();


        }
      public  abstract  Pizza create(string type);
    }

    class NyPizzaStore:PizzaStore 
    {

      
        public override Pizza create(string type)
        {
           if(type=="cheese")
            {
                return  new NyCheesePizza();
            }
            else if (type == "Corn")
            {
                return new NyCornPizza();
            }
            else { return null; }
        }
    }

    class CfPizzaStore : PizzaStore
    {


        public override Pizza create(string type)
        {
            if (type == "cheese")
            {
                return new CfCheesePizza();
            }
           else  if (type =="Corn")
            {
                return new CfCornPizza();
            }
            else { return null; }
        }
    }

   abstract class Pizza
    {
        public abstract  void  prepare();
        public abstract void bake();
        public abstract void cut();
        public abstract void parcel();

    }

    class NyCheesePizza : Pizza
    {
        public override void bake()
        {
            Console.WriteLine("baking NyCheesePizza");
        }

        public override void cut()
        {
            Console.WriteLine("baking NyCheesePizza");
        }

        public override void parcel()
        {
            Console.WriteLine("cut NyCheesePizza");
        }

        public override void prepare()
        {
            Console.WriteLine("prepare NyCheesePizza");
        }
    }

    class NyCornPizza : Pizza
    {
        public override void bake()
        {
            Console.WriteLine("baking NyCornePizza");
        }

        public override void cut()
        {
            Console.WriteLine("baking NyCornePizza");
        }

        public override void parcel()
        {
            Console.WriteLine("cut NyCornePizza");
        }

        public override void prepare()
        {
            Console.WriteLine("prepare NyCornePizza");
        }
    }


    class CfCheesePizza : Pizza
    {
        public override void bake()
        {
            Console.WriteLine("baking CfCheesePizza");
        }

        public override void cut()
        {
            Console.WriteLine("baking CfCheesePizza");
        }

        public override void parcel()
        {
            Console.WriteLine("cut CfCheesePizza");
        }

        public override void prepare()
        {
            Console.WriteLine("prepare CfCheesePizza");
        }
    }

    class CfCornPizza : Pizza
    {
        public override void bake()
        {
            Console.WriteLine("baking CfCornPizza");
        }

        public override void cut()
        {
            Console.WriteLine("baking CfCornPizza");
        }

        public override void parcel()
        {
            Console.WriteLine("cut CfCornPizza");
        }

        public override void prepare()
        {
            Console.WriteLine("prepare CfCornPizza");
        }
    }



}
