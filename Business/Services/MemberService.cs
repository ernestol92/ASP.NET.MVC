using Business.DTOs;
using Business.Interfaces.Services;
using Data.Entities;
using Data.Interfaces.IRepository;

namespace Business.Services;

public class MemberService : IMemberService
{


    private readonly IMemberRepository _memberRepository;

    public MemberService(IMemberRepository memberRepository)
    {
        _memberRepository = memberRepository;
    }

    public async Task<MemberEntity?> CreateMemberAsync(MemberDto dto)
    {
        var entity = new MemberEntity
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Email = dto.Email,
            PhoneNumber = dto.PhoneNumber,
            Role = dto.Role,
            Address = dto.Address,
            DateOfBirth = dto.DateOfBirth
        };
        return await _memberRepository.CreateAsync(entity);
    }

    public async Task<bool> DeleteMemberAsync(int id)
    {
        return await _memberRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<MemberEntity>> GetAllMembersAsync()
    {
        return await _memberRepository.GetAllAsync();
    }

    public async Task<MemberEntity?> UpdateMemberAsync(int id, MemberDto dto)
    {
        var entity = new MemberEntity
        {
            Id = id,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Email = dto.Email,
            PhoneNumber = dto.PhoneNumber,
            Role = dto.Role,
            Address = dto.Address,
            DateOfBirth = dto.DateOfBirth
        };
        return await _memberRepository.UpdateAsync(id, entity);
    }
}
