using AutoMapper;
using Hospital.WPF.DTOs;
using Hospital.WPF.Models;
using Hospital.WPF.Services.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.WPF.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<PatientService> _logger;
        public PatientService(
            IPatientRepository repository,
            IMapper mapper,
            ILogger<PatientService> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<IEnumerable<PatientResponse>> GetAllAsync()
        {
            _logger.LogInformation("Retrieving all patients.");
            var patients = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<PatientResponse>>(patients);
        }
        public async Task<PatientResponse?> GetByIdAsync(Guid id)
        {
            var patient = await _repository.GetByIdAsync(id);
            if (patient == null) throw new NotFoundException("Patient not found.");
            return _mapper.Map<PatientResponse>(patient);
        }
        public async Task<PatientResponse> CreateAsync(CreatePatientRequest request)
        {
            var emailExists = await _repository.GetByEmailAsync(request.Email);
            if (emailExists != null) throw new ValidationException("Email already exists.");
            var patient = _mapper.Map<Patient>(request);
            patient.PatientNumber = GeneratePatientNumber();
            await _repository.AddAsync(patient); await _repository.SaveChangesAsync();
            return _mapper.Map<PatientResponse>(patient);
        }
        public async Task<PatientResponse> UpdateAsync(Guid id, UpdatePatientRequest request)
        {
            var patient = await _repository.GetByIdAsync(id);
            if (patient == null) throw new NotFoundException("Patient not found.");
            _mapper.Map(request, patient); await _repository.UpdateAsync(patient);
            await _repository.SaveChangesAsync();
            return _mapper.Map<PatientResponse>(patient);
        }
        public async Task DeleteAsync(Guid id)
        {
            var exists = await _repository.ExistsAsync(id);
            if (!exists) throw new NotFoundException("Patient not found.");
            await _repository.DeleteAsync(id); await _repository.SaveChangesAsync();
        }
        public async Task<IEnumerable<PatientResponse>> SearchAsync(string keyword)
        {
            var patients = await _repository.SearchAsync(keyword);
            return _mapper.Map<IEnumerable<PatientResponse>>(patients);
        }
        private static string GeneratePatientNumber()
        {
            return $"PAT-{DateTime.UtcNow:yyyyMMddHHmmssfff}";
        }

        public IEnumerable<Patient> GetAll()
        {
            throw new NotImplementedException();
        }

        public void AddPatient(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
