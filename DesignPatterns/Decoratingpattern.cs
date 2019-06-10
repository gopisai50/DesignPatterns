using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Decoratingpattern
    {
        public static void Main()
        {
            bevarages bev  = new HouseBlends ();
     
            bev = new Mocha(bev);
         
            bev = new Mocha(bev);
            bev = new soya(bev);
            Console.WriteLine(bev.description()+bev.Cost().ToString ());
            Console.ReadKey();
        
        }


    }

    public abstract class bevarages
    {
        public virtual void add()
        {
            Console.WriteLine("in abstract");
        }
        public abstract string description();
        public  abstract float Cost();

    }

   
    public class Espresso : bevarages
    {
        
        public override float Cost()
        {
            return 2;
        }

        public override string description()
        {
            return "Espresso";
        }
    }

    public class HouseBlends : bevarages
    {
        public override void add()
        {
            Console.WriteLine("in houseblends");
        }

        public override float Cost()
        {
            return 3;
        }

        public override string description()
        {
            return "HouseBlends";
        }
    }

    public abstract class Condiments : bevarages
    {
        

    }
    public class Mocha : Condiments
    {
        bevarages bev;
        public Mocha(bevarages bev)
        {
            this.bev = bev;
        }
        public override float Cost()
        {
            return 1 + bev.Cost();
        }

        public override string description()
        {
            return bev.description() + "Mocha";
        }

        //public override string getdescription()
        //{
        //    return bev.getdescription() + "mocha";
        //}
    }


    public class soya : Condiments
    {
        bevarages bev;
        public soya(bevarages bev)
        {
            this.bev = bev;
        }
        public override float Cost()
        {
            return (float)0.5 + bev.Cost();
        }

        public override string description()
        {
            return bev.description() + "soya";
        }

        //public override string getdescription()
        //{
        //    return bev.getdescription() + "soya";
        //}
    }
    
}
