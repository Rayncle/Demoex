namespace Доп.задание
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Материал
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Материал()
        {
            Спецификация_материалов = new HashSet<Спецификация_материалов>();
        }

        [Key]
        [StringLength(150)]
        public string Артикул { get; set; }

        [Required]
        [StringLength(150)]
        public string Наименование { get; set; }

        [Required]
        [StringLength(150)]
        public string Единица_измерения { get; set; }

        public double? Длина { get; set; }

        public int Количество { get; set; }

        [Required]
        [StringLength(150)]
        public string Тип_материала { get; set; }

        [StringLength(150)]
        public string Характеристика { get; set; }

        [StringLength(150)]
        public string Закупочна_цена { get; set; }

        [StringLength(150)]
        public string ГОСТ { get; set; }

        [StringLength(150)]
        public string Основной_поставщик { get; set; }

        [Column(TypeName = "image")]
        public byte[] Изображение { get; set; }

        public virtual Поставщик Поставщик { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Спецификация_материалов> Спецификация_материалов { get; set; }
    }
}
