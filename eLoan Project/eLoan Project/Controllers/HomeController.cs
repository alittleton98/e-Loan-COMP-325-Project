using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eLoan_Project.Models;
using eLoan_Project.Data;
using static eLoan_Project.Loan_Mgmt_Engine.eLoan_CRUD;

namespace eLoan_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("../eLoan_Views/Index");
        }

        public IActionResult Privacy()
        {
            return View("../eLoan_Views/Privacy");
        }

        public IActionResult Registration()
        {
            return View("../eLoan_Views/Registration");
        }
        public IActionResult UserHome(string firstName, string lastName)
        {
            firstName = "Drew";
            //pass first name to the UserHome view 
            ViewData["User First Name"] = firstName;
            return View("../eLoan_Views/UserHome");
        }
        public IActionResult LoanApp()
        {
            return View("../eLoan_Views/LoanApp");
        }

        public IActionResult SaveLoanApp(Application application)
        {

            //eLoanContext context = new;
          
            Application app = new Application();
            app.profile_ID = 1;
            app.loanState = "APP_SUBMITTED";
            app.additional_expense = application.additional_expense;
            app.last4ssn = application.last4ssn;
            app.employee_name = application.employee_name;
            app.monthly_salary = application.monthly_salary;
            app.rent_mortgage_expense = application.rent_mortgage_expense;
            app.additional_expense = application.additional_expense;
            app.amount_requested = application.amount_requested;
            app.tenure_in_months = application.tenure_in_months;
            DateTime today = DateTime.Today;
            app.application_date = today;

            //createApplicationEntry(context, app);

            //context.Database.EnsureCreated();
            //context.Add(application);
            //context.SaveChanges();

            //LoanMgmtEngine.DecisionMakingScript()
            return View("../eLoan_Views/LoanApp");
        }
        public IActionResult Account()
        {
            return View("../eLoan_Views/Account");
        }
        public IActionResult Loans()
        {
            return View("../eLoan_Views/Loans");
        }

        public IActionResult TestPage()
        {
            return View("../eLoan_Views/Test");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
