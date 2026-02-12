namespace NateParker.Controllers.Quilmes
{
    using Microsoft.AspNetCore.Mvc;
    using NateParker.Data;
    using ViewModels.Quilmes;

    public class QuilmesController : Controller
    {
        private readonly QuilmesDataContext _context;

        public IActionResult Player()
        {
            var viewModel = new PlayerViewModel(_context);
            return View(viewModel);
        }
    }
}
