namespace Доп.задание
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Спецификация комплектующих")]
    public partial class Спецификация_комплектующих
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(150)]
        public string Изделие { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string Комплектующий { get; set; }

        [Required]
        [StringLength(150)]
        public string Количество { get; set; }

        public virtual Изделие Изделие1 { get; set; }

        public virtual Комплектующий Комплектующий1 { get; set; }
    }
}
