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

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BollMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: /<controller>/
        ProductCon db = new ProductCon();
        public IActionResult Index()
        {
            var model = db.products.ToList();
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
        public async Task<IActionResult> Create(ProductModel model, IFormFile fileUpload)
        {
            
            if (fileUpload == null)
            {
                ModelState.AddModelError("errFileUpload", "The file upload field is required.");
                return View();
            }

            if (ModelState.IsValid)
            {
                string pathImgProduct = "/images/Product/";
                string pathSave = $"wwwroot{pathImgProduct}";
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
                model.coverImg = pathImgProduct + fileName;
                model.createDate = dateNow;
                model.modifyDate = dateNow;
                db.products.Add(model);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            ProductModel Pd = db.products.Find(id);
            db.products.Remove(Pd);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            ProductModel Pd = db.products.Find(id);
            return View(Pd);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProductModel model, IFormFile fileUpload)
        {
         
            // set old data
            db.products.Attach(model);
            ProductModel oldPd = new ProductCon().products.Find(model.id);
            model.coverImg = oldPd.coverImg;
            model.createDate = oldPd.createDate;
            oldPd = null;

            if (ModelState.IsValid)
            {
                if (fileUpload != null) 
                {
                    string pathImgProduct = "/images/Product/";
                    string pathSave = $"wwwroot{pathImgProduct}";
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
                    model.coverImg = pathImgProduct + fileName;
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
  