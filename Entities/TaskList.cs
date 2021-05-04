using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Corportal.Entities
{
    /// <summary>
    /// Класс сущности задачи
    /// </summary>
    public class TaskList
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Deadline { get; set; }

        public bool IsDone { get; set; }
    }
}
