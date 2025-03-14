using Microsoft.EntityFrameworkCore;

public class FondoHistoricoRepository : IFondoHistoricoRepository
{
    private readonly ApplicationDbContext _context;

    public FondoHistoricoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<FondoHistorico>> GetAllAsync(FondoHistoricoQuery query)
    {
        var queryable = _context.FondoHistorico.AsQueryable();

        if (!string.IsNullOrEmpty(query.SearchTerm))
        {
            queryable = queryable.Where(f => f.TEMA.Contains(query.SearchTerm) || f.ASUNTO.Contains(query.SearchTerm));
        }

        return await queryable
            .Skip((query.PageNumber - 1) * query.PageSize)
            .Take(query.PageSize)
            .ToListAsync();
    }

    public async Task<FondoHistorico> GetByIdAsync(int fhid)
    {
        return await _context.FondoHistorico.FindAsync(fhid);
    }

    public async Task<FondoHistorico> CreateAsync(FondoHistorico newItem)
    {
        _context.FondoHistorico.Add(newItem);
        await _context.SaveChangesAsync();
        return newItem;
    }

    public async Task UpdateAsync(FondoHistorico updatedItem)
    {
        _context.Entry(updatedItem).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int fhid)
    {
        var item = await _context.FondoHistorico.FindAsync(fhid);
        if (item != null)
        {
            _context.FondoHistorico.Remove(item);
            await _context.SaveChangesAsync();
        }
    }
}
