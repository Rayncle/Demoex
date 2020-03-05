namespace Доп.задание
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Тип оборудования")]
    public partial class Тип_оборудования
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Тип_оборудования()
        {
            Оборудование = new HashSet<Оборудование>();
            Спецификация_операции = new HashSet<Спецификация_операции>();
        }

        [Key]
        [Column("Тип_оборудования")]
        [StringLength(150)]
        public string Тип_оборудования1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Оборудование> Оборудование { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Спецификация_операции> Спецификация_операции { get; set; }
    }
}
