using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Managers.Interfaces;
using AutoMapper;
using ContactManagement.Models;

namespace ContactManagement.Controllers
{
    public class ContactController : Controller
    {
        IContactBusinessManager _buzManager;
        public ContactController(IContactBusinessManager buzManager)
        {
            _buzManager = buzManager;
        }

        public ActionResult Index()
        {
            var result = Mapper.Map<IEnumerable<ContactViewModel>>(_buzManager.GetAllContacts());
            ContactsListViewModel model = new ContactsListViewModel
            {
                Contacts = result
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult CreateUpdate(int? id)
        {
            ContactViewModel model = new ContactViewModel();
            if (id == null)
            {
                model.Status = true;
                ViewBag.Action = "Create";
                
            }
            else
            {
                ViewBag.Action = "Edit";
                model = Mapper.Map<ContactViewModel>(_buzManager.GetContactById(id.Value));
                if (model != null)
                {
                    ViewBag.Message = "No matched record found";
                }
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult CreateUpdate(ContactViewModel input)
        {
            if (ModelState.IsValid)
            {
                _buzManager.InsertUpdateContact(Mapper.Map<Business.Entities.Contact>(input));
                return RedirectToAction("Index");
            }
            return View(input);
        }

        public ActionResult Delete(int id)
        {
            _buzManager.DeleteContact(id);
            return RedirectToAction("Index");
        }
    }
}