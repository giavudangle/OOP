using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Super : Competitor
    {
        private double database;
        public Super(double database, string name, string id, double m1, double m2, double m3)
            : base(id, name, m1, m2, m3)
        {
            this.database = database;
            this.name = name;
            this.id = id;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
            this.total = base.getTotal();
        }

        public override double getTotal()
        {
         

            return m1 + m2 + m3 + database;
        }

    }
}
