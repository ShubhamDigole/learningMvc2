using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApplication1.DAL;
using WebApplication1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class DataBinder : IModelBinder
    {


        /*  public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
          {
              HttpContext objContext = controllerContext.HttpContext;
              string firstName = objContext.Request.Form["FirstName"];
              string lastName = objContext.Request.Form["LastName"];
              stuClass user = new stuClass()
              {
                  FirstName = firstName,
                  LastName = lastName
              };

              return user;
          }*/
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            string firstName = bindingContext.HttpContext.Request.Form["FirstName"];
            string lastName = bindingContext.HttpContext.Request.Form["LastName"];

            stuClass user = new stuClass()
            {
                FirstName = firstName,
                LastName = lastName
            };

            bindingContext.Result = ModelBindingResult.Success(user);
            return Task.CompletedTask;
        }



    }
    public class DataController : Controller
    {
        classData data = null;
        //string val = Request.QueryString["TxtName"];
        public DataController(classData data)
        {
            this.data = data;
        }
        // GET: /<controller>/
        public IActionResult Load()
        {
            var users = new stuClass { FirstName = "shubham", LastName = "digole" };
            return View("Users", users);
        }

        public IActionResult AddUser()
        {
            return View("AddUser", new stuClass());
        }

        public IActionResult TestView()
        {
           
            UserModel u = getAllRecords();
            UserViewModel evm = new UserViewModel(u);     
            return View(evm);
        }

        public IActionResult getAllValues() //get respone in json format
        {
            List<stuClass> data = this.data.stuClasses.ToList<stuClass>();
            Thread.Sleep(2000); 
            return Json(data);
        }

       public UserModel getAllRecords()
        {
            UserModel user = new UserModel();
            user.Ussername = "shubham";
            user.Name = "shubham digole";
            user.Salary = 20000;
            user.DateOfBirth = new DateTime(1996, 10, 23);
            return user;
        }

        //  public IActionResult Submit([ModelBinder(BinderType = typeof(DataBinder))]stuClass obj)

        public IActionResult Submit()
        {
            //basic data sending
            stuClass obj = new stuClass();
            obj.FirstName = Request.Form["firstName"] ;
            obj.LastName = Request.Form["lastName"];
            
            if (ModelState.IsValid)
            {
                data.stuClasses.Add(obj);
                data.SaveChanges();
            }
            Thread.Sleep(1000);
            return Json(obj);

        }
       
    }


}
