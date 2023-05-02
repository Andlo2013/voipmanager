using voipmanager.BusinessObjects.Records;

namespace voipmanager.BusinessObjects.Interfaces
{
    public interface ITaskRepository
    {

        Task<IEnumerable<TaskRecord>> Get(int companyId);

        Task<IEnumerable<TaskRecord>> GetById(int taskId);

        Task<IEnumerable<TaskRecord>> Create(Task task);

        Task<IEnumerable<TaskRecord>> Update(Task task);

    }
}
