namespace LAB6.Views.Shared.Components
{
    using Microsoft.AspNetCore.Mvc;

    public class NavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}
