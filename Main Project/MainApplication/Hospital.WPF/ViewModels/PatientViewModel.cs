using Hospital.WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Mvvm;
using Prism.Common;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Hospital.WPF.ViewModels
{
    public partial class PatientViewModel : ObservableObject
    {
        private readonly IPatientService service;

        [ObservableProperty]
        private string patientName;

        [ObservableProperty]
        private ObservableCollection<Patient> patients;

        public ICommand SaveCommand { get; }

        public PatientViewModel(IPatientService _service)
        {
            service = _service;

            SaveCommand = new RelayCommand(_ => Save());

            LoadPatients();
        }

        private void Save()
        {
            service.AddPatient(new Patient
            {
                FullName = patientName
            });

            LoadPatients();
        }

        void LoadPatients()
        {
            patients = new ObservableCollection<Patient>(
                service.GetAll());
        }
    }
}

public interface IPatientService
{
    IEnumerable<Patient> GetAll();
    void AddPatient(Patient patient);
}
