using System.Threading.Tasks;

namespace ServiceToConsume.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task CommitAsync();

        void Commit();
    }
}