using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;
    public HomeController(FactoryContext db)
    {
      _db = db ;
    }
    [HttpGet("/")]
    public ActionResult Index()
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      List<Engineer> engineersModel = _db.Engineers.ToList();
      List<Machine> machinesModel = _db.Machines.ToList();
      model.Add("engineers", engineersModel);
      model.Add("machines", machinesModel);
      return View(model);
    }
  }
}
