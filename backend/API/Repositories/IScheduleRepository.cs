public interface IScheduleRepository
{
    Task<IEnumerable<Horario>> GetAllAsync();
    Task<Horario> GetByIdAsync(int id_horario);
    Task<Horario> CreateAsync(Horario newItem);
    Task UpdateAsync(Horario updatedItem);
    Task DeleteAsync(int id_horario);

    Task<IEnumerable<Grados>> GetAllGradosAsync();
    Task<Grados> GetGradoByIdAsync(int id_grados);
    Task<Grados> CreateGradoAsync(Grados newItem);
    Task UpdateGradoAsync(Grados updatedItem);
    Task DeleteGradoAsync(int id_grados);

    Task<IEnumerable<Grupos>> GetAllGruposAsync();
    Task<Grupos> GetGrupoByIdAsync(int id_grupo);
    Task<Grupos> CreateGrupoAsync(Grupos newItem);
    Task UpdateGrupoAsync(Grupos updatedItem);
    Task DeleteGrupoAsync(int id_grupo);

    Task<IEnumerable<HoraInicio>> GetAllHoraIniciosAsync();
    Task<HoraInicio> GetHoraInicioByIdAsync(int id_inicio);
    Task<HoraInicio> CreateHoraInicioAsync(HoraInicio newItem);
    Task UpdateHoraInicioAsync(HoraInicio updatedItem);
    Task DeleteHoraInicioAsync(int id_inicio);

    Task<IEnumerable<HoraFin>> GetAllHoraFinsAsync();
    Task<HoraFin> GetHoraFinByIdAsync(int id_fin);
    Task<HoraFin> CreateHoraFinAsync(HoraFin newItem);
    Task UpdateHoraFinAsync(HoraFin updatedItem);
    Task DeleteHoraFinAsync(int id_fin);

    Task<IEnumerable<Maestros>> GetAllMaestrosAsync();
    Task<Maestros> GetMaestroByIdAsync(int id_maestro);
    Task<Maestros> CreateMaestroAsync(Maestros newItem);
    Task UpdateMaestroAsync(Maestros updatedItem);
    Task DeleteMaestroAsync(int id_maestro);

    Task<IEnumerable<Materias>> GetAllMateriasAsync();
    Task<Materias> GetMateriaByIdAsync(int id_materia);
    Task<Materias> CreateMateriaAsync(Materias newItem);
    Task UpdateMateriaAsync(Materias updatedItem);
    Task DeleteMateriaAsync(int id_materia);
}
