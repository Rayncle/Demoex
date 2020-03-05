namespace Доп.задание
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Заказ> Заказ { get; set; }
        public virtual DbSet<Изделие> Изделие { get; set; }
        public virtual DbSet<Комплектующий> Комплектующий { get; set; }
        public virtual DbSet<Материал> Материал { get; set; }
        public virtual DbSet<Оборудование> Оборудование { get; set; }
        public virtual DbSet<Пользователь> Пользователь { get; set; }
        public virtual DbSet<Поставщик> Поставщик { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }
        public virtual DbSet<Спецификация_комплектующих> Спецификация_комплектующих { get; set; }
        public virtual DbSet<Спецификация_материалов> Спецификация_материалов { get; set; }
        public virtual DbSet<Спецификация_операции> Спецификация_операции { get; set; }
        public virtual DbSet<Спецификация_сборочных_единиц> Спецификация_сборочных_единиц { get; set; }
        public virtual DbSet<Тип_оборудования> Тип_оборудования { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Заказ>()
                .Property(e => e.Стоимость)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Изделие>()
                .HasMany(e => e.Заказ)
                .WithRequired(e => e.Изделие1)
                .HasForeignKey(e => e.Изделие)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделие>()
                .HasMany(e => e.Спецификация_комплектующих)
                .WithRequired(e => e.Изделие1)
                .HasForeignKey(e => e.Изделие)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделие>()
                .HasMany(e => e.Спецификация_материалов)
                .WithRequired(e => e.Изделие1)
                .HasForeignKey(e => e.Изделие)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделие>()
                .HasMany(e => e.Спецификация_операции)
                .WithRequired(e => e.Изделие1)
                .HasForeignKey(e => e.Изделие)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделие>()
                .HasMany(e => e.Спецификация_сборочных_единиц)
                .WithRequired(e => e.Изделие1)
                .HasForeignKey(e => e.Изделие)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Комплектующий>()
                .HasMany(e => e.Спецификация_комплектующих)
                .WithRequired(e => e.Комплектующий1)
                .HasForeignKey(e => e.Комплектующий)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Материал>()
                .HasMany(e => e.Спецификация_материалов)
                .WithRequired(e => e.Материал1)
                .HasForeignKey(e => e.Материал)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Поставщик>()
                .HasMany(e => e.Материал)
                .WithOptional(e => e.Поставщик)
                .HasForeignKey(e => e.Основной_поставщик);

            modelBuilder.Entity<Тип_оборудования>()
                .HasMany(e => e.Оборудование)
                .WithRequired(e => e.Тип_оборудования1)
                .HasForeignKey(e => e.Тип_оборудования)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Тип_оборудования>()
                .HasMany(e => e.Спецификация_операции)
                .WithOptional(e => e.Тип_оборудования1)
                .HasForeignKey(e => e.Тип_оборудования);
        }
    }
}
