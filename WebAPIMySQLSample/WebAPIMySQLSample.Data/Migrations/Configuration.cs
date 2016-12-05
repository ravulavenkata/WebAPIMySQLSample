namespace WebAPIMySQLSample.Data.Migrations
{
    using WebAPIMySQLSample.Common.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SampleMySQLApplicationDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SampleMySQLApplicationDataContext context)
        {
          
           
        }

    }
}
