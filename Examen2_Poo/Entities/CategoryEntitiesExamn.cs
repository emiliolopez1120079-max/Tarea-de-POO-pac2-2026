using System.ComponentModel.DataAnnotations.Schema;
namespace  Examen2_Poo.Entities
{
    [Table("Categories")]
    public class CategoryEntitiesExam :  EntityExam
    {
        // [Key]
        // [Column("id")]//pone Id en minuscula en la tabla
        // public int? Id {get; set;}
        [Column("name")]
        public string? Name{get; set;}
        [Column("description")]
        public string? Description { get; set; }
        [Column("is_active")]
        public bool IsActive {get; set;} = true;
    }
}