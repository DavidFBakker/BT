using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMDB
{
    public class EmToName
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Node { get; set; }
        public string Channel { get; set; }
        public string Name { get; set; }
    }
}