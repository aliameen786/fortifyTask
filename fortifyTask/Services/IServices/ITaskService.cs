using fortifyTask.Dtos;

namespace fortifyTask.Services.IServices
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskDTO>> GetAllTaskByService();
        Task<TaskDTO> CreateTaskByService(TaskDTO taskDTO);
        Task<bool> updateTaskByService(TaskDTO taskDTO);
    }
}
