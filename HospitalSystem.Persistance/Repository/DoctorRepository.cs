﻿

namespace HospitalSystem.Persistance.Repository
{
        public class DoctorRepository:IDoctorRepository
        {
       
            private readonly ApplicationDbContext _context;

            public DoctorRepository(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task AddEntityAsync(Doctor entity)
            {
                _context.Doctors.Add(entity);
                await _context.SaveChangesAsync();
            }

            public async Task<IEnumerable<Doctor>> GetAllEntityAsync()
            {
                return await _context.Doctors.ToListAsync();
            }

            public async Task<Doctor?> GetEntityByIdAsync(string id)
            {
                return await _context.Doctors.FindAsync(id);
            }

            public async Task UpdateEntityAsync(Doctor entity)
            {
                _context.Doctors.Update(entity);
                await _context.SaveChangesAsync();
            }

            public async Task DeleteEntityAsync(string id)
            {
                var Doctor = await GetEntityByIdAsync(id);
                if (Doctor != null)
                {
                    _context.Doctors.Remove(Doctor);
                    await _context.SaveChangesAsync();
                }
            }

		    public async Task<List<Doctor>> GetByDepartmentId(string Id)
		    {
			    return await _context.Doctors.Where(x=>x.DepartmentId==Id && x.Status==true).ToListAsync();
            
		    }

		
	}
}
