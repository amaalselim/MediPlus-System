﻿using HospitalSystem.Application.IServices;
using HospitalSystem.Application.Services;
using Microsoft.AspNetCore.Authorization;

namespace Hospital_Management_Project.Areas.Doctors.Controllers{

    [Area("Doctors")]
    //[Authorize(Roles ="Doctor")]
    public class MedicalRecordController : Controller
    {
        private readonly IMedicalRecordService _medicalRecordService;
        private readonly IPatientService _patientService;
        private readonly IAppointmentService _appointmentService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IImageService _fileService;

        public MedicalRecordController(IMedicalRecordService medicalRecordService, IImageService fileService, IPatientService patientService , IAppointmentService appointmentService , UserManager<IdentityUser> userManager)
        {
            _medicalRecordService = medicalRecordService;
            _patientService = patientService;
            _appointmentService = appointmentService;
            _userManager = userManager;
            _fileService = fileService;
            
            
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var doctorId = "453737d3-1891-4db0-be30-94a52f0ad18b";

            var patients = await _appointmentService.GetPatientsByDoctorAsync(doctorId);
            return View(patients);
        }

        [HttpGet]
        public async Task<IActionResult> RecordsByPatient(string id)
        {
            List<MedicalRecord> records = await _medicalRecordService.GetMedicalRecordsByPatientIdAsync(id);
            ViewBag.PatientId = id;
            return View(records);
        }

        [HttpGet]
        public async Task<IActionResult> Create(string patientId)
        {
            var patient = await _patientService.GetPatientByIdAsync(patientId);
            if (patient == null) return NotFound();

            var user = await _userManager.GetUserAsync(User);

            MedicalRecord record = new MedicalRecord()
            {
                PatientID = patientId.ToString(),
                Patient = patient,
                DateOfEntry = DateTime.Now,
                DoctorID = "453737d3-1891-4db0-be30-94a52f0ad18b"
            };

            return View(record);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MedicalRecord record, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null && file.Length > 0)
                {
                    var path = @"DiagnosisDocument";
                    string FilePath = await _fileService.SaveImageAsync(file, path);
                    record.DiagnosisDocument = FilePath;
                }

                await _medicalRecordService.AddMedicalRecordAsync(record);
                return RedirectToAction("Index");
            }
            return View(record);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            MedicalRecord record = await _medicalRecordService.GetMedicalRecordAndPatientDetails(id);
            if (record == null) return NotFound();

            return View(record);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(MedicalRecord record, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null && file.Length > 0)
                {
                    var path = @"DiagnosisDocument";
                    string FilePath = await _fileService.SaveImageAsync(file, path);
                    record.DiagnosisDocument = FilePath;
                }

                await _medicalRecordService.UpdateMedicalRecordAsync(record);
                return RedirectToAction("Index", new { patientId = record.PatientID });
            }
            return View(record);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _medicalRecordService.DeleteMedicalRecordAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            MedicalRecord? record = await _medicalRecordService.GetMedicalRecordAndPatientDetails(id);
            return View(record);
        }
    }
}
