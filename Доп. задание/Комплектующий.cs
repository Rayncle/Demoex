namespace Доп.задание
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Комплектующий
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Комплектующий()
        {
            Спецификация_комплектующих = new HashSet<Спецификация_комплектующих>();
        }

        [Key]
        [StringLength(150)]
        public string Артикул { get; set; }

        [Required]
        [StringLength(150)]
        public string Наименование { get; set; }

        [Required]
        [StringLength(150)]
        public string Количество { get; set; }

        [Required]
        [StringLength(150)]
        public string Единица_измерения { get; set; }

        [Required]
        [StringLength(150)]
        public string Тип { get; set; }

        [Required]
        [StringLength(150)]
        public string Цена { get; set; }

        public double? Вес { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Спецификация_комплектующих> Спецификация_комплектующих { get; set; }
    }
}
