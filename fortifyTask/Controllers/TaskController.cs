using fortifyTask.Models;
using fortifyTask.Repository;
using fortifyTask.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fortifyTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepo _taskRepo;

        public TaskController(ITaskRepo taskRepo)
        {
            _taskRepo = taskRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<TaskModel>> GetAllTask()
        {
            return await _taskRepo.GetAllTask();
        }

        [HttpPost]
        public async Task<ActionResult<TaskModel>> CreateTask(TaskModel model)
        {
            var createdTask = await _taskRepo.AddTask(model);
            return Ok(createdTask);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTask(int id, TaskModel model)
        {
            var updatedTask = await _taskRepo.UpdateTask(id, model);

            if (updatedTask == null)
            {
                return NotFound("Task not found");
            }

            return Ok(updatedTask);
        }
    }

}
