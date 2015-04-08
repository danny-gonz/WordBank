using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace WordBank.Models
{
    public class Term
    {

        public int TermId { get; set; }
        
        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Word { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Definition { get; set; }

        
    }

    


        public class TermDBContext : DbContext
        {
            public DbSet<Term> Terms { get; set; }

 
        }

           

}