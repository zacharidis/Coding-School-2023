using CoffeeShop.EF.Repository;
using CoffeeShop.Model;
using CoffeeShop.Web.Models.CustomerDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace CoffeeShop.Web.Controllers
{
    public class CustomerController : Controller
    {
        // Constructor & prop
        private readonly IEntityRepo<Customer> _customerRepo;
        public CustomerController(IEntityRepo<Customer> customerRepo) { 
        
         _customerRepo= customerRepo;
        
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            var customers = _customerRepo.GetAll();
            return View(model: customers);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();

            }



            var selectedCustomer = _customerRepo.GetById(id);
            if (selectedCustomer == null)
            {
                return NotFound();  
            }

            return View(model:selectedCustomer);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            var toBeAdded = new Customer(customer.Code, customer.Description);       

           
            _customerRepo.Add(toBeAdded);
            return RedirectToAction("Index");

        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {

            var editCustomer = _customerRepo.GetById(id);
            if (editCustomer == null) { return NotFound(); }

   


            return View(model:editCustomer);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbCustomer = _customerRepo.GetById(id); 

            if (dbCustomer == null) { return NotFound(); }

         
            return View(model : dbCustomer);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
