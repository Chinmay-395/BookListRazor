using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        /* [Key] ---> this will automatically add a 'id' field in the database */
        [Key]
        public int Id { get; set; }
        /* [Required] ---> this attribute cannot be null */
        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
