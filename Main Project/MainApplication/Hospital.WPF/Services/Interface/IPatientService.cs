using Hospital.WPF.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.WPF.Services.Interface
{
    public interface IPatientService 
    { 
        Task<IEnumerable<PatientResponse>> GetAllAsync(); 
        Task<PatientResponse?> GetByIdAsync(Guid id); 
        Task<PatientResponse> CreateAsync(CreatePatientRequest request); 
        Task<PatientResponse> UpdateAsync(Guid id, UpdatePatientRequest request); 
        Task DeleteAsync(Guid id); 
        Task<IEnumerable<PatientResponse>> SearchAsync(string keyword); }
}
