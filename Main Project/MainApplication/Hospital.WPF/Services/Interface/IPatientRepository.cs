using Hospital.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.WPF.Services.Interface
{
    public interface IPatientRepository
    {
        Task<IEnumerable<Patient>> GetAllAsync();
        Task<Patient?> GetByIdAsync(Guid id);
        Task<Patient?> GetByPatientNumberAsync(string patientNumber);
        Task<Patient?> GetByEmailAsync(string email);
        Task AddAsync(Patient patient);
        Task UpdateAsync(Patient patient);
        Task DeleteAsync(Guid id);
        Task<IEnumerable<Patient>> SearchAsync(string keyword);
        Task<bool> ExistsAsync(Guid id);
        Task SaveChangesAsync();
    }
}
