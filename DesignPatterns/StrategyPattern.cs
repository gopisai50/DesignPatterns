using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class StrategyPattern
    {
        static void main(string[] args)
        {
            real nwduck = new real();
            nwduck.setfly(new flywithwings());
            nwduck.setSound(new quack());
            nwduck.display();
            nwduck.fly();
            nwduck.sound();
            nwduck.setfly(new flywithoutwings());
            nwduck.setSound(new squeak());
            nwduck.fly();
            nwduck.sound();
            Console.ReadKey();
        }
        
    }


    public class duck
    {

        public void display()
        {
            Console.WriteLine("displaying");
            Console.ReadKey();
        }



        //public duck()
        //    {
        //    Console.WriteLine("displaying");
        //    Console.ReadKey();

        //}

        //public void fly()
        //{
        //    Console.WriteLine("fly by duck");
        //    Console.ReadKey();
        //}
        //public void sound()
        //{
        //    //sound something
        //}
    }

    public interface flyingbehaviour
    {
         void fly();
    }

    public interface Soundbehaviour
    {
        void Sound();
    }


    public class flywithwings : flyingbehaviour
    {
        public void fly()
        {
            Console.WriteLine("flyingwithwings");
        }
    }

    public class flywithoutwings : flyingbehaviour
    {
        public void fly()
        {
            Console.WriteLine("flyingwithoutwings");
        }
    }

    public class quack : Soundbehaviour
    {
       
        public void Sound()
        {
            Console.WriteLine("quack");
        }
    }


    public class squeak : Soundbehaviour
    {

        public void Sound()
        {
            Console.WriteLine("squeak");
        }
    }
    public class real:duck
    {
        public flyingbehaviour fly1;
        public Soundbehaviour sound1;
        public void setfly(flyingbehaviour fly)
        {
           this.fly1 = fly;
        }
        public void setSound(Soundbehaviour sound)
        {
            this.sound1 = sound;
        }
        public void display()
        {
            Console.WriteLine("realduck");
        }
        public void fly()
        {
            fly1.fly();
        }
        public void sound()
        {
            sound1.Sound();
        }

    }

}
