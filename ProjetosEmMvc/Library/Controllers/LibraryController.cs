using Microsoft.AspNetCore.Mvc;
using Library.Data;
using Library.Models;
using System.Linq;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LibraryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var livros = _db.Livros.ToList();
            return View(livros);
        }

        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public IActionResult CreateBook(LivrosEntity livros)
        {
            if (ModelState.IsValid)
            {
                _db.Add(livros);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(livros);
        }

        public IActionResult Update()
        {
            return View();
        }


        // public IActionResult Delete(int id)
        // {
        //     var livro = _db.Livros.Find(id);
        //     if (livro == null)
        //     {
        //         return NotFound();
        //     }
        //     return View(livro);
        // }

        // [HttpPost, ActionName("Delete")]
        // public IActionResult DeleteConfirmed(int id)
        // {
        //     var livro = _db.Livros.Find(id);
        //     if (livro == null)
        //     {
        //         return NotFound();
        //     }
        //     _db.Livros.Remove(livro);
        //     _db.SaveChanges();
        //     return RedirectToAction("Index");
        // }

        // public IActionResult Update(int id)
        // {
        //     var livro = _db.Livros.Find(id);
        //     if (livro == null)
        //     {
        //         return NotFound();
        //     }
        //     return View(livro);
        // }

        // [HttpPost]
        // public IActionResult UpdateBook(LivrosEntity livros)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _db.Update(livros);
        //         _db.SaveChanges();
        //         return RedirectToAction("Index");
        //     }
        //     return View(livros);
        // }

        // protected override void Dispose(bool disposing)
        // {
        //     if (disposing)
        //     {
        //         _db.Dispose();
        //     }
        //     base.Dispose(disposing);
        // }
    }
}
