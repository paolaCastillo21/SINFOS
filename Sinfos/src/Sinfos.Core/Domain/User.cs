using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sinfos.Core.Domain
{
    [Table("User")]
    public class User
    {
        public int Id { get; set; }

        
        [StringLength(100)]
        public string Name { get; set; }

        public string Mail { get; set; }

                
        public Agenda Agenda { get; set; }
    }
}
