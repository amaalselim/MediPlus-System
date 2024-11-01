﻿namespace Hospital_Management_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = nameof(UserRoles.Admin))]
    public class DashboardController : Controller
    {
        private readonly IDoctorService _IdoctorService;
        private readonly IPatientService _IpatientService;
        private readonly IDepartmentService _IdepartmentService;
        private readonly INurseService _InurseService;
        private readonly IAppointmentService _IappointmentService;
        private readonly IUnitOfWork _IunitOfWork;
        public DashboardController(IDoctorService IdoctorService, IPatientService IpatientService,
            IDepartmentService IdepartmentService, INurseService InurseService, IUnitOfWork IunitOfWork, IAppointmentService iappointmentService)
        {
            _IdepartmentService = IdepartmentService;
            _InurseService = InurseService;
            _IdoctorService = IdoctorService;
            _IpatientService = IpatientService;
            _IunitOfWork = IunitOfWork;
            _IappointmentService = iappointmentService;
        }
        public async Task<IActionResult> Index()
        {
            var patients = await _IpatientService.GetAllPatientsAsync();
            var doctors = await _IdoctorService.GetAllDoctorsAsync();
            var departments = await _IdepartmentService.GetAllDepartmentsAsync();
            var nurses = await _InurseService.GetAllNursesAsync();

            ViewBag.PatientCount = patients.Count();
            ViewBag.DoctorCount = doctors.Count();
            ViewBag.DepartmentCount = departments.Count();
            ViewBag.NurseCount = nurses.Count();
            return View();
        }
        public async Task<IActionResult> DoctorsPartial()
        {
			var doctors = await _IdoctorService.GetAllDoctorsAsync();
			var orderedDoctors = doctors.Take(6).ToList();
            return PartialView(orderedDoctors);
		}
    }
}
