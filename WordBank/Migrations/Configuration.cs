namespace WordBank.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WordBank.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WordBank.Models.TermDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WordBank.Models.TermDBContext context)
        {
            context.Terms.AddOrUpdate(i => i.Word,
        new Term
        {
            Word = "Lakers",
            Definition = "Professional BasketBall Team"

        },

           new Term
        {
            Word = "The Beatles",
            Definition = "A Band from Liverpool"

        },

          new Term
        {
            Word = "Who Wrote Grapes of Wrath",
            Definition = "John Steinbeck"

        }


   );

        }
    }
}

