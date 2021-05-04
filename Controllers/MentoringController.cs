using Corportal.Data;
using Corportal.Helper;
using Corportal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskDb = Corportal.Entities.TaskList;
using TaskDto = Corportal.Models.TaskList;

namespace Corportal.Controllers
{
    [Route("Mentoring")]
    public class MentoringController : Controller
    {
        private readonly ApplicationDbContext _appDBContext;

        public MentoringController(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("GiveTask")]
        [HttpGet]
        public IActionResult GiveTask()
        {
            return View();
        }

        [Route("GetData")]
        public ActionResult GetData()
        {
            List<TaskDto> taskList = _appDBContext.TaskList.ToList().Select(x => x.ToDto()).ToList();

            return Json(new { data = taskList });
        }


        [Route("Add")]
        [HttpGet]
        public ActionResult Add(int id = 0)
        {
            return View(new TaskList());
        }

        [Route("Edit/{id}")]
        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            var record = _appDBContext.TaskList.Where(x => x.Id == id).FirstOrDefault().ToDto();
            return View(record);

        }

        [Route("Add")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(TaskDto task)
        {
            if (ModelState.IsValid)
            {
                _appDBContext.TaskList.Add(task.ToEntity());
                await _appDBContext.SaveChangesAsync();
            }

            return Json(new { success = true, message = "Запись сохранена успешно" });
        }

        [Route("Edit/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TaskDto task)
        {
            if (ModelState.IsValid)
            {
                var record = _appDBContext.TaskList.Where(x => x.Id == task.Id).FirstOrDefault();
                record.Name = task.Name;
                record.Description = task.Description;
                record.Deadline = task.Deadline;
                record.IsDone = task.IsDone;
                _appDBContext.TaskList.Update(record);
                await _appDBContext.SaveChangesAsync();
            }
            return Json(new { success = true, message = "Запись изменена успешно" });
        }

        [Route("Delete/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var record = _appDBContext.TaskList.Where(x => x.Id == id).FirstOrDefault();
            _appDBContext.TaskList.Remove(record);
            await _appDBContext.SaveChangesAsync();
            return Json(new { success = true, message = "Запись удалена успешно" });
        }
    }
}
