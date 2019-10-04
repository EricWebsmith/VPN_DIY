using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VpnDiy.Web.Data;

namespace VpnDiy.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            
            return View(AwsCommandUtility.GetServers());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Start(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AwsCommandUtility.Start(id);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Stop(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AwsCommandUtility.Stop(id);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Whoami()
        {
            string whoami = AwsCommandUtility.Call("whoami", null);
            return Json(whoami);
        }

        public IActionResult Ec2()
        {
            string ec2 = AwsCommandUtility.Call("aws","ec2 describe-instances");
            return Json(ec2);
        }
    }
}
