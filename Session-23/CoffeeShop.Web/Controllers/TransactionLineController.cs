using CoffeeShop.EF.Repository;
using CoffeeShop.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Web.Controllers
{
    public class TransactionLineController : Controller
    {


        private readonly IEntityRepo<TransactionLine> _tlRepo;
        public TransactionLineController(IEntityRepo<TransactionLine> tlRepo) {
        
            _tlRepo= tlRepo;
        }

        // GET: TransactionLineController
        public ActionResult Index()
        {
            var tls = _tlRepo.GetAll();

            return View(model:tls);
        }

        // GET: TransactionLineController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TransactionLineController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransactionLineController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: TransactionLineController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TransactionLineController/Edit/5
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

        // GET: TransactionLineController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TransactionLineController/Delete/5
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
