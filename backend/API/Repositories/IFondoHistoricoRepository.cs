public interface IFondoHistoricoRepository
{
    Task<IEnumerable<FondoHistorico>> GetAllAsync(FondoHistoricoQuery query);
    Task<FondoHistorico> GetByIdAsync(int fhid);
    Task<FondoHistorico> CreateAsync(FondoHistorico newItem);
    Task UpdateAsync(FondoHistorico updatedItem);
    Task DeleteAsync(int fhid);
}
