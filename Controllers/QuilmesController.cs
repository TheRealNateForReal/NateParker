namespace NateParker.Controllers.Quilmes
{
    using Microsoft.AspNetCore.Mvc;
    using NateParker.Data;
    using ViewModels.Quilmes;

    public class QuilmesController(QuilmesDataContext context) : Controller
    {
        private readonly QuilmesDataContext _context = context;

        public IActionResult Player()
        {
            var viewModel = new RosterViewModel(_context);
            return View(viewModel);
        }
    }
}
