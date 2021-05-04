using Corportal.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Corportal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<TaskList> TaskList { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// Дополнительная настройка контекста.
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// Конструктор по-умолчанию
        /// </summary>
        public ApplicationDbContext()
        {

        }

        /// <summary>
        /// Выбирает и конфигурирует источник данных, используемых контекстом.
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
