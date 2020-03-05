namespace Доп.задание
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Пользователь
    {
        [Key]
        [StringLength(150)]
        public string Логин { get; set; }

        [Required]
        [StringLength(150)]
        public string ФИО { get; set; }

        [Required]
        [StringLength(150)]
        public string Пароль { get; set; }

        [Required]
        [StringLength(150)]
        public string Роль { get; set; }

        [Column(TypeName = "image")]
        public byte[] Фото { get; set; }
    }
}
