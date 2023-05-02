using voipmanager.BusinessObjects.Records;

namespace voipmanager.BusinessObjects.Interfaces
{
    public interface IDomainRepository
    {

        Task<IEnumerable<DomainRecord>> Get(int taskId);

        Task<IEnumerable<DomainRecord>> GetById(int domainId);

        Task<IEnumerable<TaskRecord>> Create(Task task);

        Task<IEnumerable<TaskRecord>> Update(Task task);

    }
}
