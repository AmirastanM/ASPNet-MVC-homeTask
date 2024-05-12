using ASPNET_MVC_ClassPractice.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net.Cache;

namespace ASPNET_MVC_ClassPractice.Controllers
{
    public class HomeController : Controller
    {
        //public string GetName()
        //{
        //    return "Esgerxan";
        //}

        //public string GetName(string name)
        //{
        //    return name;
        //}


        //public string Index()
        //{
        //    return null;
        //}

        //public int Index(int id)
        //{
        //    return 100;
        //}


        //public string Index(string name, string surname)
        //{
        //    return name + " " + surname;
        //}

        public IActionResult Index()
        {
            string text = "Welcome";
            List<string> students =  new() {"Emirastan", "Fexriyye", "Elmir", "Ilgar", "Nurlan"};
            HomeVM model = new()
            {
                Text = text,
                Students = students,
                Users = GetAllUsers()
            };
            return View(model);
        }


        private List<User> GetAllUsers()
        {
            return new List<User>
            {
                new User
                {
                    Id = 1,
                    Age = 100
                },

                new User
                {
                    Id = 2,
                    Age = 300
                },
                new User
                {
                    Id = 3,
                    Age = 200
                }
            }; 
        }


    }
}
