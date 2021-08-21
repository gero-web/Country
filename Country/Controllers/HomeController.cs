using Country.Data;
using Country.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Country.Models.SerializerModel;
using Microsoft.EntityFrameworkCore;

namespace Country.Controllers
{
    public class HomeController : Controller
    {
      
        private readonly CountryDBContext _context;

        public HomeController(CountryDBContext context)
        {
            _context = context;

        }

        public  IActionResult Index()
        {
           
            
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> OneCountry(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                ModelState.AddModelError("","Название страны не должно быть пустым!");
                return View("Index");
            }    

            var model = await API.GetData(name);

            if(model == null)
            {
                ModelState.AddModelError("", "Данной страны нет");
                return View("Index");
            }
            return View(model);
        }

        public IActionResult OnSave(SerializerCountry data)
        {
            var saveData = new SaveData(_context);
            saveData.Save(data);

            return View("Index");
        }

        public IActionResult AllCountry()
        {
            _context.Countrys.Load();
            var model = _context.Countrys.Include(region=> region.Region)
                .Include(capital => capital.Capital).ToList();
            return View(model);
        }

       

       
    }
}
