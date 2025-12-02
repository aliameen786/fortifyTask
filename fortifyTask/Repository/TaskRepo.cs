using fortifyTask.Models;
using fortifyTask.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace fortifyTask.Repository
{
    public class TaskRepo : ITaskRepo
    {
        private readonly ApplicationDbContext _context;

        public TaskRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TaskModel> AddTask(TaskModel task)
        {
            var newTask = new TaskModel
            {
                TaskName = task.TaskName,
                TaskDate = task.TaskDate
            };

            _context.TaskModels.Add(newTask);
            await _context.SaveChangesAsync();

            return newTask;
        }

        public async Task<IEnumerable<TaskModel>> GetAllTask()
        {
            return await _context.TaskModels.ToListAsync();
        }

        public async Task<TaskModel?> UpdateTask(int id, TaskModel task)
        {
            var existingTask = await _context.TaskModels.FindAsync(id);

            if (existingTask == null)
            {
                return null; 
            }

            existingTask.TaskName = task.TaskName;
            existingTask.TaskDate = task.TaskDate;

            await _context.SaveChangesAsync();
            return existingTask;
        }
    }

}
