using Microsoft.EntityFrameworkCore;

public class ScheduleRepository : IScheduleRepository
{
    private readonly ScheduleSystemContext _context;

    public ScheduleRepository(ScheduleSystemContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Horario>> GetAllAsync()
    {
        return await _context.Horarios
            .Include(h => h.Maestros)
            .Include(h => h.Materias)
            .Include(h => h.Grados)
            .Include(h => h.Grupos)
            .Include(h => h.HoraInicio)
            .Include(h => h.HoraFin)
            .ToListAsync();
    }

    public async Task<Horario> GetByIdAsync(int id_horario)
    {
        return await _context.Horarios
            .Include(h => h.Maestros)
            .Include(h => h.Materias)
            .Include(h => h.Grados)
            .Include(h => h.Grupos)
            .Include(h => h.HoraInicio)
            .Include(h => h.HoraFin)
            .FirstOrDefaultAsync(h => h.id_horario == id_horario);
    }

    public async Task<Horario> CreateAsync(Horario newItem)
    {
        _context.Horarios.Add(newItem);
        await _context.SaveChangesAsync();
        return newItem;
    }

    public async Task UpdateAsync(Horario updatedItem)
    {
        _context.Entry(updatedItem).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id_horario)
    {
        var item = await _context.Horarios.FindAsync(id_horario);
        if (item != null)
        {
            _context.Horarios.Remove(item);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Grados>> GetAllGradosAsync()
    {
        return await _context.Grados.ToListAsync();
    }

    public async Task<Grados> GetGradoByIdAsync(int id_grados)
    {
        return await _context.Grados.FindAsync(id_grados);
    }

    public async Task<Grados> CreateGradoAsync(Grados newItem)
    {
        _context.Grados.Add(newItem);
        await _context.SaveChangesAsync();
        return newItem;
    }

    public async Task UpdateGradoAsync(Grados updatedItem)
    {
        _context.Entry(updatedItem).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteGradoAsync(int id_grados)
    {
        var item = await _context.Grados.FindAsync(id_grados);
        if (item != null)
        {
            _context.Grados.Remove(item);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Grupos>> GetAllGruposAsync()
    {
        return await _context.Grupos.ToListAsync();
    }

    public async Task<Grupos> GetGrupoByIdAsync(int id_grupo)
    {
        return await _context.Grupos.FindAsync(id_grupo);
    }

    public async Task<Grupos> CreateGrupoAsync(Grupos newItem)
    {
        _context.Grupos.Add(newItem);
        await _context.SaveChangesAsync();
        return newItem;
    }

    public async Task UpdateGrupoAsync(Grupos updatedItem)
    {
        _context.Entry(updatedItem).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteGrupoAsync(int id_grupo)
    {
        var item = await _context.Grupos.FindAsync(id_grupo);
        if (item != null)
        {
            _context.Grupos.Remove(item);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<HoraInicio>> GetAllHoraIniciosAsync()
    {
        return await _context.HoraInicios.ToListAsync();
    }

    public async Task<HoraInicio> GetHoraInicioByIdAsync(int id_inicio)
    {
        return await _context.HoraInicios.FindAsync(id_inicio);
    }

    public async Task<HoraInicio> CreateHoraInicioAsync(HoraInicio newItem)
    {
        _context.HoraInicios.Add(newItem);
        await _context.SaveChangesAsync();
        return newItem;
    }

    public async Task UpdateHoraInicioAsync(HoraInicio updatedItem)
    {
        _context.Entry(updatedItem).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteHoraInicioAsync(int id_inicio)
    {
        var item = await _context.HoraInicios.FindAsync(id_inicio);
        if (item != null)
        {
            _context.HoraInicios.Remove(item);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<HoraFin>> GetAllHoraFinsAsync()
    {
        return await _context.HoraFins.ToListAsync();
    }

    public async Task<HoraFin> GetHoraFinByIdAsync(int id_fin)
    {
        return await _context.HoraFins.FindAsync(id_fin);
    }

    public async Task<HoraFin> CreateHoraFinAsync(HoraFin newItem)
    {
        _context.HoraFins.Add(newItem);
        await _context.SaveChangesAsync();
        return newItem;
    }

    public async Task UpdateHoraFinAsync(HoraFin updatedItem)
    {
        _context.Entry(updatedItem).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteHoraFinAsync(int id_fin)
    {
        var item = await _context.HoraFins.FindAsync(id_fin);
        if (item != null)
        {
            _context.HoraFins.Remove(item);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Maestros>> GetAllMaestrosAsync()
    {
        return await _context.Maestros.ToListAsync();
    }

    public async Task<Maestros> GetMaestroByIdAsync(int id_maestro)
    {
        return await _context.Maestros.FindAsync(id_maestro);
    }

    public async Task<Maestros> CreateMaestroAsync(Maestros newItem)
    {
        _context.Maestros.Add(newItem);
        await _context.SaveChangesAsync();
        return newItem;
    }

    public async Task UpdateMaestroAsync(Maestros updatedItem)
    {
        _context.Entry(updatedItem).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteMaestroAsync(int id_maestro)
    {
        var item = await _context.Maestros.FindAsync(id_maestro);
        if (item != null)
        {
            _context.Maestros.Remove(item);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Materias>> GetAllMateriasAsync()
    {
        return await _context.Materias.ToListAsync();
    }

    public async Task<Materias> GetMateriaByIdAsync(int id_materia)
    {
        return await _context.Materias.FindAsync(id_materia);
    }

    public async Task<Materias> CreateMateriaAsync(Materias newItem)
    {
        _context.Materias.Add(newItem);
        await _context.SaveChangesAsync();
        return newItem;
    }

    public async Task UpdateMateriaAsync(Materias updatedItem)
    {
        _context.Entry(updatedItem).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteMateriaAsync(int id_materia)
    {
        var item = await _context.Materias.FindAsync(id_materia);
        if (item != null)
        {
            _context.Materias.Remove(item);
            await _context.SaveChangesAsync();
        }
    }
}
