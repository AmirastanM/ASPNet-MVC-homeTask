﻿using Homework.Models;
using Homework.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Homework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            HomeVM model = new HomeVM()
            {
                Students = GetAllStudents().OrderByDescending(u => u.Age).ToList(),
                Products = GetAllProducts(),
            };
            return View(model);
        }

        private List<Student> GetAllStudents()
        {
            return new List<Student>
            {
                new Student
                {
                    Name = "Ali",
                    Surname="Aliyev",
                    Email="ali@code.edu.az",
                    Age=18,
                    Phone=994552546
                },
                new Student
                {
                    Name = "Eldar",
                    Surname="Abbasov",
                    Email="eldar@code.edu.az",
                    Age=24,
                    Phone=548226821
                },
                new Student
                {
                    Name = "Rafik",
                    Surname="Mamedov",
                    Email="rafik@code.edu.az",
                    Age=34,
                    Phone=859632729
                },
                new Student
                {
                    Name = "Leyla",
                    Surname="Makhmudova",
                    Email="leyla@code.edu.az",
                    Age=25,
                    Phone=541663258
                },
                 new Student
                {
                    Name = "Elbrus",
                    Surname="Qasimov",
                    Email="elbrus@code.edu.az",
                    Age=36,
                    Phone=859632729
                },
                  new Student
                {
                    Name = "Ates",
                    Surname="Cabbarov",
                    Email="ates@code.edu.az",
                    Age=28,
                    Phone=859632729
                }
            };
        }
        private List<Product> GetAllProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Name="Glass",
                    Color="Black",
                    Price=5
                },
                 new Product
                {
                    Name="Helmet",
                    Color="White",
                    Price=15
                },
                  new Product
                {
                    Name="Shoes",
                    Color="Gray",
                    Price=55
                },
                   new Product
                {
                    Name="Suit",
                    Color="Blue",
                    Price=80
                },
            };
        }
    }
}
