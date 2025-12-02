using fortifyTask.Models;

namespace fortifyTask.Repository.IRepository
{
    public interface ITaskRepo
    {
        Task<IEnumerable<TaskModel>> GetAllTask();
        Task<TaskModel> AddTask(TaskModel task);
        Task<TaskModel?> UpdateTask(int id, TaskModel task);
    }
}
