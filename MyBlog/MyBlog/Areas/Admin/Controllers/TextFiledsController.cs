using Microsoft.AspNetCore.Mvc;
using MyBlog.Domain;
using MyBlog.Domain.Entities;
using MyBlog.Service;

namespace MyBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextFiledsController : Controller
    {
        private readonly DataManager dataManager;
        public TextFiledsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Edit(string codeWord)
        {
            var entity = dataManager.TextFields.GetTextFieldByCodeWord(codeWord);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(TextField model)
        {
            if (ModelState.IsValid)
            {
                dataManager.TextFields.SaveTextField(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
    }
}