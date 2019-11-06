using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BollMVC.Models;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BollMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: /<controller>/
        MyEmployee db = new MyEmployee();
        public IActionResult Index()
        {
            var model = db.Employee.ToList();
            return View(model);
        }

        public string Welcome(string name, string id)
        {
            return $"Hello, Your name's {name}. Your ID is {id}.";
        }
          public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmployeeData model, IFormFile fileUpload)
        {
            

            if (fileUpload == null)
            {
                ModelState.AddModelError("errFileUpload", "The file upload field is required.");
                return View();
            }

            if (ModelState.IsValid)
            {
                string pathImgProfile = "/images/Proflie/";
                string pathSave = $"wwwroot{pathImgProfile}";
                if (!Directory.Exists(pathSave))
                {
                    Directory.CreateDirectory(pathSave);
                }
                string extFile = Path.GetExtension(fileUpload.FileName);
                string fileName = DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + extFile;
                var path = Path.Combine(Directory.GetCurrentDirectory(), pathSave, fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await fileUpload.CopyToAsync(stream);
                }

                DateTime dateNow = DateTime.Now;
                model.coverImg = pathImgProfile + fileName;
                model.createDate = dateNow;
                model.modifyDate = dateNow;
                db.Employee.Add(model);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            EmployeeData Employee = db.Employee.Find(id);
            db.Employee.Remove(Employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            EmployeeData Employee = db.Employee.Find(id);
            return View(Employee);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeData model, IFormFile fileUpload)
        {
            

            // set old data
            db.Employee.Attach(model);
            EmployeeData oldEmployee = new MyEmployee().Employee.Find(model.id);
            model.coverImg = oldEmployee.coverImg;
            model.createDate = oldEmployee.createDate;
            oldEmployee = null;

            if (ModelState.IsValid)
            {
                if (fileUpload != null) 
                {
                    string pathImgProfile = "/images/Profile/";
                    string pathSave = $"wwwroot{pathImgProfile}";
                    if (!Directory.Exists(pathSave))
                    {
                        Directory.CreateDirectory(pathSave);
                    }
                    string extFile = Path.GetExtension(fileUpload.FileName);
                    string fileName = DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + extFile;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), pathSave, fileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await fileUpload.CopyToAsync(stream);
                    }
                    model.coverImg = pathImgProfile + fileName;
                }

                model.modifyDate = DateTime.Now;
                db.Entry(model).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
  