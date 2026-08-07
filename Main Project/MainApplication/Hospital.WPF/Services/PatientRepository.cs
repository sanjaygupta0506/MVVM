using Hospital.WPF.Data;
using Hospital.WPF.Models;
using Hospital.WPF.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.WPF.Services
{
    public class PatientRepository : IPatientRepository
    {
        private readonly HospitalPatientDbContext _context;
        public PatientRepository(HospitalPatientDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Patient>> GetAllAsync()
        {
            return await _context.Patients
                .AsNoTracking()
                .OrderBy(p => p.FullName)
                .ToListAsync();
        }
        public async Task<Patient?> GetByIdAsync(Guid id)
        {
            return await _context.Patients
                .FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<Patient?> GetByPatientNumberAsync(string patientNumber)
        {
            return await _context.Patients
                .FirstOrDefaultAsync(x => x.PatientNumber == patientNumber);
        }
        public async Task<Patient?> GetByEmailAsync(string email)
        {
            return await _context.Patients
                .FirstOrDefaultAsync(x => x.Email == email);
        }
        public async Task AddAsync(Patient patient)
        {
            await _context.Patients.AddAsync(patient);
        }
        public Task UpdateAsync(Patient patient)
        {
            _context.Patients.Update(patient);
            return Task.CompletedTask;
        }
        public async Task DeleteAsync(Guid id)
        {
            var patient = await GetByIdAsync(id);
            if (patient is null)
                return;
            patient.IsDeleted = true;
            _context.Patients.Update(patient);
        }
        public async Task<IEnumerable<Patient>> SearchAsync(string keyword)
        {
            keyword = keyword.ToLower();
            return await _context.Patients
                .Where(p =>
                p.FullName.ToLower().Contains(keyword) ||
                p.PatientNumber.ToLower().Contains(keyword) ||
                p.PhoneNumber.Contains(keyword)).AsNoTracking().ToListAsync();
        }
        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.Patients.AnyAsync(x => x.Id == id);
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
