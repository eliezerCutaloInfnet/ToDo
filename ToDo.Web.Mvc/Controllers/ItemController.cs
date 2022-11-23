using Microsoft.AspNetCore.Mvc;
using ToDo.Application.Dtos.Item;
using ToDo.Application.Interfaces;

namespace ToDo.Web.Mvc.Controllers
{
    public class ItemController : Controller
    {
        protected IItemAppService service;

        public ItemController(IItemAppService service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            var items = await service.GetItemsAsync();

            return View(items);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Description")] CreateItemRequestDto createItemModel)
        {
            if (ModelState.IsValid)
            {
                await service.CreateItemAsync(createItemModel);
                return RedirectToAction(nameof(Index));
            }  

            return View(createItemModel);
        }
    }
}
