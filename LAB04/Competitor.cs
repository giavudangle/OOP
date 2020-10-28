using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    abstract class Competitor
    {
        protected string id;
        protected string name;
        protected double m1, m2, m3;
        protected double total;

        protected Competitor(string id, string name, double m1, double m2, double m3)
        {
            this.id = id;
            this.name = name;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
            this.total = m1 + m2 + m3;
        }

        public virtual double getTotal()
        {
            return this.total;
        }

    }
}
