﻿using ExamWeb_NguyenTanPhong.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_NguyenTanPhong.Controllers
{
    public class PhimController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PhimController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var dsPhim = _db.Phims.ToList();
            return View(dsPhim);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Phim phim)
        {
            if (ModelState.IsValid)
            {
                _db.Phims.Add(phim);
                _db.SaveChanges();
                TempData["success"] = "Da them thanh cong";
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }
        public IActionResult Update(int id)
        {
            var phim = _db.Phims.Find(id);
            if (phim == null)
            {
                return NotFound();
            }
            return View(phim);
        }
        // Xử lý cập nhật chủng loại
        [HttpPost]
        public IActionResult Update(Phim phim)
        {
            if (ModelState.IsValid) //kiem tra hop le
            {
                //cập nhật category vào table Categories
                _db.Phims.Update(phim);
                _db.SaveChanges();
                TempData["success"] = "Phim updated success";
                return RedirectToAction("Index");
            }
            return View();
        }
        //Hiển thị form xác nhận xóa chủng loại
        public IActionResult Delete(int id)
        {
            var phim = _db.Phims.FirstOrDefault(x => x.Id == id);
            if (phim == null)
            {
                return NotFound();
            }
            return View(phim);
        }
        // Xử lý xóa chủng loại
        public IActionResult DeleteConfirmed(int id)
        {
            var phim = _db.Phims.Find(id);
            if (phim == null)
            {
                return NotFound();
            }
            _db.Phims.Remove(phim);
            _db.SaveChanges();
            TempData["success"] = "Phim deleted success";
            return RedirectToAction("Index");
        }
    }
}
