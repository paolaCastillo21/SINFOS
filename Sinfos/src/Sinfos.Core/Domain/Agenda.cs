using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sinfos.Core.Domain
{
    [Table("Agenda")]
    public class Agenda
    {
        //[Key]
        public int Id { get; set; }

        [StringLength(11)]
        [Required(ErrorMessage ="Fecha es obligatoria.")]
        [Display(Name ="Feha de Agendamiento")]
        public string Fecha { get; set; }

        [StringLength(11)]
        [Required(ErrorMessage = "Hora es obligatoria.")]
        [Display(Name = "Hora Inicial")]
        public string Hora_inicio { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "Texto es obligatorio.")]       
        public string Hallazgo { get; set; }

        [Display(Name = "Usuario Responsable")]
        public int UserId { get; set; }

        [Display(Name = "Usuario Responsable")]
        public User User { get; set; }
    }
}
