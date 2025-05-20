using Data.Entities;

namespace Data.Interfaces.IRepository
{
    public interface IMemberRepository
    {
        Task<MemberEntity> CreateAsync(MemberEntity memberEntity);
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<MemberEntity>> GetAllAsync();
        Task<MemberEntity> UpdateAsync(int id, MemberEntity memberEntity);
    }
}