namespace Доп.задание
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Изделие
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Изделие()
        {
            Заказ = new HashSet<Заказ>();
            Спецификация_комплектующих = new HashSet<Спецификация_комплектующих>();
            Спецификация_материалов = new HashSet<Спецификация_материалов>();
            Спецификация_операции = new HashSet<Спецификация_операции>();
            Спецификация_сборочных_единиц = new HashSet<Спецификация_сборочных_единиц>();
        }

        [Key]
        [StringLength(150)]
        public string Наименование { get; set; }

        [Required]
        [StringLength(150)]
        public string Размеры { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказ> Заказ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Спецификация_комплектующих> Спецификация_комплектующих { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Спецификация_материалов> Спецификация_материалов { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Спецификация_операции> Спецификация_операции { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Спецификация_сборочных_единиц> Спецификация_сборочных_единиц { get; set; }
    }
}
