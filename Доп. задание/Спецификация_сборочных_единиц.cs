namespace Доп.задание
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Спецификация сборочных единиц")]
    public partial class Спецификация_сборочных_единиц
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(150)]
        public string Изделие { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string Сборочная_единица_или_деталь { get; set; }

        public int Количество { get; set; }

        public virtual Изделие Изделие1 { get; set; }
    }
}
