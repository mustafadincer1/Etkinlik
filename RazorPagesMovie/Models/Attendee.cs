using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RazorPagesMovie.Models.DBEntities
{
    public class Attendee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column(TypeName = "int(15)")]
        public int UserID { get; set; }
        public int ActivityID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string UserName { get; set; }
        public string ActivityName { get; set; }


    }
}