using StewardMaster.Models;
using System;
using System.Web.Mvc;

namespace StewardMaster.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly LogRepository _logRepository;

        public HomeController()
        {
            _logRepository = new LogRepository();
        }

        public ActionResult Index()
        {
            var model = new StewardEnquiryModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(StewardEnquiryModel model)
        {
            CalculateStewardRequirements(model);
            ModelState.Clear();
            LogRequest(model);
            return View(model);
        }

        public ActionResult Audit()
        {
            var model = _logRepository.GetAllEntries();
            return View(model);
        }

        private void LogRequest(StewardEnquiryModel model)
        {
            var logEntry = new LogEntryModel()
            {
                NumberOfTickets = model.NumberOfTickets,
                Username = User.Identity.Name,
                RequestDateTime = DateTime.UtcNow
            };
            _logRepository.Save(logEntry);
        }

        private void CalculateStewardRequirements(StewardEnquiryModel model)
        {
            var stewards = model.NumberOfTickets / 50;
            var nonContractStewards = stewards - 5;
            var totalStewards = 5 + (nonContractStewards > 0 ? nonContractStewards : 0);

            model.ContractS1Count = totalStewards > 5 ? 5 : totalStewards;
            model.NonContractS1Count = totalStewards - 5 > 0 ? totalStewards - 5 : 0;

            var supervisors = totalStewards / 5;

            model.ContractS3Count = 1;
            model.NonContractS3Count = supervisors - 1;
        }
    }
}