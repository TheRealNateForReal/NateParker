namespace NateParker.Controllers.Quilmes
{
    using Microsoft.AspNetCore.Mvc;
    using NateParker.Data;
    using System.Data.SqlClient;
    using ViewModels.Quilmes;

    public class QuilmesController : Controller
    {
        private readonly QuilmesDataContext _context;
        // Constructor injection
        public QuilmesController(QuilmesDataContext context)
        {
            _context = context;
        }

        public IActionResult Player()
        {
            var viewModel = new PlayerViewModel(_context);
            return View(viewModel);
        }
    }
}
