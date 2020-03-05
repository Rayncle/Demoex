namespace Доп.задание
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Поставщик
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Поставщик()
        {
            Материал = new HashSet<Материал>();
        }

        [Key]
        [StringLength(150)]
        public string Наименование { get; set; }

        [StringLength(150)]
        public string Адрес { get; set; }

        [Required]
        [StringLength(150)]
        public string Срок_доставки { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Материал> Материал { get; set; }
    }
}
