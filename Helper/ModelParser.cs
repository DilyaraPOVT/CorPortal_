using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corportal.Helper
{
    public static class ModelParser
    {
        /// <summary>
        /// Преобразование Сущности в Модель 
        /// </summary>
        /// <param name="entity"> Сущность </param>
        /// <returns> Модель </returns>
        public static Models.TaskList ToDto(this Entities.TaskList entity)
        {
            return new Models.TaskList
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Deadline = entity.Deadline,
                IsDone = entity.IsDone
            };
        }

        /// <summary>
        /// Преобразование Модели в Сущность
        /// </summary>
        /// <param name="entity"> Модель </param>
        /// <returns> Сущность </returns>
        public static Entities.TaskList ToEntity(this Models.TaskList dto)
        {
            return new Entities.TaskList
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                Deadline = dto.Deadline,
                IsDone = dto.IsDone
            };
        }
    }
}
