namespace VWW_EF_CodeFirst
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }


        public virtual DbSet<Hersteller> Hersteller { get; set; }
        public virtual DbSet<Monitor> Monitor { get; set; }
    }

}