using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Corportal.Models
{
    /// <summary>
    /// Модель задач
    /// </summary>
    public class TaskList
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [Display(Name = "Наименование")]
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [Display(Name = "Описание задачи")]
        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [Display(Name = "Срок")]
        [JsonPropertyName("Deadline")]
        public DateTime Deadline { get; set; }

        [Display(Name = "Выполнил")]
        [JsonPropertyName("IsDone")]
        public bool IsDone { get; set; }
    }
}
