﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YashvisBooks.DataAccess.Repository.IRepository;
using YashvisBooks.Models;
using YashvisBooks.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;

namespace YashvisBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)        // get action method for Upsert
        {
            ProductVM productVM = new ProductVM()
            {
                Product = new Product(),
                CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()

                }),
                CoverTypeList = _unitOfWork.CoverType.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
            };      // using YashvisBooks.Models;
            if (id == null)
            {
                // this for the create
                return View(productVM);
            }
            productVM.Product = _unitOfWork.Product.Get(id.GetValueOrDefault());
            if (productVM.Product == null)
            {
                // this is for the edit
                return NotFound();
            }
            return View(productVM);

        }

        //use HTTP POST to deine the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Upsert(ProductVM productVM)
        {
            if (ModelState.IsValid)
            {
                string webRootPath = _hostEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(webRootPath, @"images\products");
                    var extension = Path.GetExtension(files[0].FileName);

                    if (productVM.Product.ImageUrl != null)
                    {
                        // this is an edit and we need to remove old image
                        var imagePath = Path.Combine(webRootPath, productVM.Product.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(imagePath))
                        {
                            System.IO.File.Delete(imagePath);
                        }
                    }
                    using (var filesStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        files[0].CopyTo(filesStreams);
                    }
                    productVM.Product.ImageUrl = @"\images\products\" + fileName + extension;
                }
                else
                {
                    // update when they do not change the image
                    if (productVM.Product.Id != 0)
                    {
                        Product objFromDb = _unitOfWork.Product.Get(productVM.Product.Id);
                        productVM.Product.ImageUrl = objFromDb.ImageUrl;
                    }
                }

                if (productVM.Product.Id == 0)
                {
                    _unitOfWork.Product.Add(productVM.Product);
                }
                else
                {
                    _unitOfWork.Product.Update(productVM.Product);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                productVM.CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                });
                productVM.CoverTypeList = _unitOfWork.CoverType.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                });
                if (productVM.Product.Id != 0)
                {
                    productVM.Product = _unitOfWork.Product.Get(productVM.Product.Id);
                }
            }
            return View(productVM);
        }

        //API calls here
        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            //return NotFound();
            var allObj = _unitOfWork.Product.GetAll(includeProperties:"Category, Covertype");
            return Json(new { data = allObj });
        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Product.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            string webRootPath = _hostEnvironment.WebRootPath;
            var imagePath = Path.Combine(webRootPath, objFromDb.ImageUrl.TrimStart('\\'));
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }
            _unitOfWork.Product.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}
