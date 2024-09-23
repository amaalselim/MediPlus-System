﻿namespace HospitalSystem.Application.Services
{
    public class MedicalRecordService : IMedicalRecordService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MedicalRecordService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddMedicalRecordAsync(MedicalRecord MedicalRecord)
        {
            await _unitOfWork._recordRepository.AddEntityAsync(MedicalRecord);
        }

        public async Task<MedicalRecord> GetMedicalRecordByIdAsync(int id)
        {
            return await _unitOfWork._recordRepository.GetEntityByIdAsync(id);
        }

        public async Task<IEnumerable<MedicalRecord>> GetAllMedicalRecordsAsync()
        {
            return await _unitOfWork._recordRepository.GetAllEntityAsync();
        }

        public async Task UpdateMedicalRecordAsync(MedicalRecord MedicalRecord)
        {
             await _unitOfWork._recordRepository.UpdateEntityAsync(MedicalRecord);
        }

        public async Task DeleteMedicalRecordAsync(int id)
        {
            await _unitOfWork._recordRepository.DeleteEntityAsync(id);
        }
    }
}