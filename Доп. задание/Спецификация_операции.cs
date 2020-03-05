namespace Доп.задание
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Спецификация операции")]
    public partial class Спецификация_операции
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(150)]
        public string Изделие { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string Операция { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Порядковый_номер { get; set; }

        [StringLength(150)]
        public string Тип_оборудования { get; set; }

        [StringLength(150)]
        public string Время_на_операцию { get; set; }

        public virtual Изделие Изделие1 { get; set; }

        public virtual Тип_оборудования Тип_оборудования1 { get; set; }
    }
}
