using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoListApp.Entities.Concrete;
using ToDoListApp.Models;

namespace ToDoListApp.Controllers
{
    public class HomeController : Controller
    {

     
        private readonly ITaskService _taskService;
        
        public HomeController(ITaskService taskService)
        {
            _taskService = taskService;
        }
      
        public ActionResult Index()
        {
            ToDoListViewModel viewModel = new ToDoListViewModel();
            var taskList = _taskService.GetAll();
            viewModel.ToDoTasks = taskList;
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(ToDoListViewModel viewModel)
        {
            _taskService.Add(viewModel.ToDoTask);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(int Id)
        {
            var entity = _taskService.Get(Id);
            _taskService.Delete(entity);
            return RedirectToAction(nameof(Index));
        }
        
        public ActionResult Edit(int Id)
        {
            var entity = _taskService.Get(Id);
            return View(entity);
        }
        [HttpPost]
        public ActionResult Edit(ToDoTask entity)
        {
            _taskService.Update(entity);
            return View(entity);
        }

    }
}