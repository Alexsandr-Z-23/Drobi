using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Drobi
{
    internal class Tdrob
    {
        public int num;
        public int denum;

        public Tdrob() : this(0)
        {
            num = 0;
            denum = 1;
           
        }
        public Tdrob(int num) : this(num, 1) { }
        public Tdrob(int num, int denum)
        {
            this.num = num;
            this.denum = denum;
        }

        public void Deconstruct(out int Dnum, out int Ddenum)
        {
            Dnum = num;
            Ddenum = denum;
        }
        public void Print1() => Console.Write($"\nДробь [1]  => : {num} /{denum} ");
        public void Print2() => Console.Write($"\nДробь [2]  => : {num} /{denum} ");
        public void Print() => Console.Write($"\nДробь итог  => :{num}/{denum} => {(double) num/denum} \n");

        public static Tdrob operator +(Tdrob a, Tdrob b)
        {
            Tdrob t = new Tdrob();
            t.num = (a.num * b.denum + a.denum * b.num);
            t.denum = a.denum * b.denum;
            return t;

        }
        public static Tdrob operator -(Tdrob a, Tdrob b)
        {
            Tdrob t = new Tdrob();
            t.num = (a.num * b.denum - a.denum * b.num);
            t.denum = a.denum * b.denum;
            return t;

        }
        public static Tdrob operator *(Tdrob a, Tdrob b)
        {
            Tdrob t = new Tdrob();
            t.num = (a.num * b.num);
            t.denum = a.denum * b.denum;
            return t;

        }
        public static Tdrob operator /(Tdrob a, Tdrob b)
        {
            Tdrob t = new Tdrob();
            t.num = (a.num / b.num);
            t.denum = a.denum / b.denum;
           
            return t;
        }

        


    }
}
