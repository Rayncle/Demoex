namespace Доп.задание
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Спецификация материалов")]
    public partial class Спецификация_материалов
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(150)]
        public string Изделие { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string Материал { get; set; }

        public int Количество { get; set; }

        public virtual Изделие Изделие1 { get; set; }

        public virtual Материал Материал1 { get; set; }
    }
}
