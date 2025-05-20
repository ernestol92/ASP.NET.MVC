using Business.DTOs;
using Data.Entities;

namespace Business.Interfaces.Services
{
    public interface IMemberService
    {
        Task<IEnumerable<MemberEntity>> GetAllMembersAsync();
        Task<MemberEntity?> CreateMemberAsync(MemberDto dto);
        Task<MemberEntity?> UpdateMemberAsync(int id, MemberDto dto);
        Task<bool> DeleteMemberAsync(int id);
    }
}
