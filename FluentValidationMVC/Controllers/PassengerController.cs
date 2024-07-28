using FluentValidationMVC.Entity;
using FluentValidationMVC.Models;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationMVC.Controllers
{
    public class PassengerController : Controller
    {
        public IActionResult Index()
        {
            if (DataBase.Passengers.Count == 0)
            {
                Passenger passenger = new Passenger()
                {
                    Gender = Gender.Male,
                    FirstName = "Ahmet",
                    LastName = "Cunda",
                    TicketNumber = 101
                };

                Passenger passenger2 = new Passenger()
                {
                    Gender = Gender.Male,
                    FirstName = "Mehmet",
                    LastName = "Aksoy",
                    TicketNumber = 102
                };
                DataBase.Passengers.Add(passenger);
                DataBase.Passengers.Add(passenger2);
            }
            return View(DataBase.Passengers.Adapt<List<PassengerListVM>>());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Passenger model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            DataBase.Passengers.Add(model.Adapt<Passenger>());
            return RedirectToAction("Index");
        }
        public IActionResult Update(Guid id)
        {
            var updateModel = DataBase.Passengers.FirstOrDefault(x => x.Id == id);
            if (updateModel != null)
            {

                return View();

            }
            return View(updateModel);
        }
        [HttpPost]
        public IActionResult Update(UpdateVM model)
        {
            if (ModelState.IsValid)
            {
                var upDateModel = DataBase.Passengers.FirstOrDefault(x => x.Id == model.Id);

                if (upDateModel == null)
                {
                    return View();
                }
                upDateModel.FirstName = model.FirstName;
                upDateModel.LastName = model.LastName;
                upDateModel.TicketNumber = Convert.ToInt32(model.TicketNumber);
                return RedirectToAction("Index");

            }

            return View(model);
        }
        public IActionResult Delete(Guid id)
        {
            var deleteModel = DataBase.Passengers.FirstOrDefault(x => x.Id == id);
            if (deleteModel != null)
            {
                DataBase.Passengers.Remove(deleteModel);
               return  RedirectToAction("Index"); 

            }
            return View();



        }
    }
}
