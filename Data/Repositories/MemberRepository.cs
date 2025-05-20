using Data.Contexts;
using Data.Entities;
using Data.Interfaces.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Data.Repositories;

public class MemberRepository : IMemberRepository
{
    private readonly AppDbContext _context;
    private readonly DbSet<MemberEntity> _dbSet;
    public MemberRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = context.Set<MemberEntity>();
    }
    public async Task<MemberEntity> CreateAsync(MemberEntity memberEntity)
    {
        if (memberEntity == null) { return null!; }
        try
        {
            await _dbSet.AddAsync(memberEntity);
            await _context.SaveChangesAsync();
            return memberEntity;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error creating member: {ex.Message}");
            return null!;
        }
    }
    public async Task<IEnumerable<MemberEntity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }
    public async Task<MemberEntity> UpdateAsync(int id, MemberEntity memberEntity)
    {
        if (memberEntity == null) { return null!; }
        try
        {
            var existingMember = await _dbSet.FindAsync(id);
            if (existingMember == null) { return null!; }
            _context.Entry(existingMember).CurrentValues.SetValues(memberEntity);
            await _context.SaveChangesAsync();
            return existingMember;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error updating member: {ex.Message}");
            return null!;
        }
    }
    public async Task<bool> DeleteAsync(int id)
    {
        try
        {
            var existingMember = await _dbSet.FindAsync(id);
            if (existingMember == null) return false;
            _dbSet.Remove(existingMember);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error deleting member: {ex.Message}");
            return false;
        }
    }
}
