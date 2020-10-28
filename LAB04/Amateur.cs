using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Amateur:Competitor
    {
        private double english;
        public Amateur(double english, string name, string id,double m1,double m2,double m3 ) 
            : base(id, name, m1, m2, m3)
        {
            this.english = english;
            this.name = name;
            this.id = id;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
            this.total = base.getTotal();
        }

        public override double getTotal()
        {
            if (english >= 7 && english <= 8) english++;
            if (english >= 9 && english <= 10) english+=2;

            return m1 + m2 + m3 + english;
        }

    }
}
