using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DesignPatterns
{
    class ObserverPattern
    {
        public static void main()
        {
            weatherdata wd = new weatherdata();
           
            currentconditionsdisplay cd = new currentconditionsdisplay();
            wd.register(cd);
            wd.setvalues(7, 8, 9);
            wd.setvalues(10, 8, 9);
            Console.ReadKey();


        }
    }

    //class workstation
    //{
    //    int temp;
    //    int pressure;
    //    int humidity;
    //    display dip = new display();
    //    public void  setvalues(int temp,int pressure,int humidity)
    //    {
    //        this.temp = temp;
    //        this.pressure = pressure;
    //        this.humidity = humidity;
    //        dip.currentconitions(temp, pressure, humidity);
    //    }
    //}

    //class display
    //{
    //    int temp;
    //    int pressure;
    //    int humidity;
    //    public void currentconitions(int temp, int pressure, int humidity)
    //    {
    //        Console.WriteLine(temp);
    //    }
    //}


    class weatherdata
    {
        public int temp, pres, hum;
        public ArrayList lsit;
        public weatherdata ()
        {
            lsit = new ArrayList();
        }

        public void register(display d)
        {
            lsit.Add(d);
        }
        public void unregister(display d)
        {
            var s=lsit.IndexOf(d);
            lsit.RemoveAt(s); 
        }
        public void notifyall( )
        {
            foreach(display o in lsit)
            {
                o.update(temp,pres,hum);
            }
        }
        public void setvalues(int temp,int pre,int hum)
        {
            this.temp = temp;
            this.pres = pre;
            this.hum = hum;
            notifyall();
        }

    }

    public interface display
    {
         void display();
        void update(int temp, int pre, int hum);
    }

    public class currentconditionsdisplay : display
    {
        public int temp, pre, hum;
        public void display()
        {
            Console.WriteLine(temp);
        }

        public void update(int temp, int pre, int hum)
        {
            this.temp = temp;
            this.pre = pre;
            this.hum = hum;
            display();
        }
    }

}
