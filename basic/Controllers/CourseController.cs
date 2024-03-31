using basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace basic.Controllers;

public class CourseController : Controller
{
    public IActionResult Index()
    {
        var kurs = new Course();

        kurs.ID=1;
        kurs.Title="Aspnet core kursu";
        kurs.Description="Güzel kurs";

        return View(kurs);
    }
     public IActionResult List()
    {
        var kurlsar = new List<Course>()
        {
            new Course() {ID=1,Title="aspnet kursu",Description="güzel bir kurs olmuş"},
            new Course() {ID=2,Title="react kursu",Description="normal bir kurs olmuş"},
            new Course() {ID=3,Title="php kursu",Description="güzel bir kurs olmuş"},
        };
        return View("CourseList",kurlsar);
    }
}