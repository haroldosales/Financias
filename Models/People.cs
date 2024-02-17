using System.ComponentModel.DataAnnotations;

namespace Financias.Models
{
    public class People
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Phone { get; set; }
        public DateTime StartOfHosting { get; set; }
        public DateTime EndOfHosting { get; set; }
        public double Price { get; set; }

        
    }
}
