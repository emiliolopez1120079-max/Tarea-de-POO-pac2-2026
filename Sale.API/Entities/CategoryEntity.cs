using System.ComponentModel.DataAnnotations.Schema;
using Sale.API.Entities;

namespace Sales.API.Entities
{
    [Table("Categories")]
    public class CategoryEntity : BaseEntity 
    {
        // [Key]
        // [Column("id")]//pone Id en minuscula en la tabla
        // public int? Id {get; set;}
        [Column("name")]
        public string? Name{get; set;}
        [Column("description")]
        public string? Description { get; set; }
        //criao por
        //fecha de criacion
        // ultimo en editar
        //fecha diultima edicion
    }
}