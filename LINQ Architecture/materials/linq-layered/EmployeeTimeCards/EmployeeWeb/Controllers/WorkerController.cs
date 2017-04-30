using System;
using System.Linq;
using System.Web.Mvc;
using EmployeeData.Custom;
using EmployeeData.Extensions;
using EmployeeDomain;
using EmployeeDomain.Custom;

namespace EmployeeWeb.Controllers
{
    public class WorkerController : Controller
    {       
        public WorkerController()
            :this(new SqlUnitOfWork())
        {
            
        }

        public WorkerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.Employees;
        }

        //
        // GET: /Worker/

        public ViewResult Index()
        {
                var model = _repository.FindAll()
                    .OrderBy(e => e.HireDate)                    
                    .Take(10).ToList();


                return View(model);
        }


        protected override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            _unitOfWork.Dispose();
        }

        //
        // GET: /Worker/Details/5

        public ViewResult Details(int id)
        {
            var model = _unitOfWork.Employees.FindById(id);

            return View(model);
        }

        //
        // GET: /Worker/Create

        public ViewResult Create()
        {
            return View();
        } 

        //
        // POST: /Worker/Create

        [HttpPost]
        public ActionResult Create([Bind(Exclude="Id")] Employee newEmployee)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(newEmployee);                
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }

            return View(newEmployee);
        }
        
        //
        // GET: /Worker/Edit/5
 
        public ViewResult Edit(int id)
        {
            var model = _repository.FindById(id);
            return View(model);
        }

        //
        // POST: /Worker/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var model = _repository.FindById(id);
            TryUpdateModel(model, new[] { "Name", "HireDate" });
            if (ModelState.IsValid)
            {
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Employee> _repository;
    }
}
