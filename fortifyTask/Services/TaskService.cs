using fortifyTask.Dtos;
using fortifyTask.Models;
using fortifyTask.Repository.IRepository;
using fortifyTask.Services.IServices;

namespace fortifyTask.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepo _ItaskRepo;
        public TaskService(ITaskRepo ItaskRepo)
        {
           _ItaskRepo = ItaskRepo;
        }
        public async Task<TaskDTO> CreateTaskByService(TaskDTO taskDTO)
        {
            var createTask = new TaskModel
            {
                TaskName = taskDTO.taskname,
                TaskDate = DateTime.Now,
            };

            var inserted = await _ItaskRepo.AddTask(createTask);
            return taskDTO;
        }

        public Task<IEnumerable<TaskDTO>> GetAllTaskByService()
        {
            throw new NotImplementedException();

        }

        public Task<bool> updateTaskByService(TaskDTO taskDTO)
        {
            //var updateTask = new TaskModel
            //{
            //    TaskName = taskDTO.taskname,
            //    TaskDate = DateTime.Now
            //};

            //var updated = _ItaskRepo.UpdateTask(updateTask);
            //if (updated != null)
            //{
            //    return ";
            //}
            //else
            //{

            //}

            throw new NotImplementedException();
        }
    }
}
