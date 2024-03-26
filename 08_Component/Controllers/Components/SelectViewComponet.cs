using Microsoft.AspNetCore.Mvc;

namespace _08_Component.Controllers.Components
{
    public class SelectViewComponet: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string id, string title, List<Kvp> options, bool isDisalbled) 
        {
            return View(new KvpSelectResponse()
            {
                HtmlId = id,
                IsDisabled = isDisalbled,
                SelectItems = options,
                Title = title,
            });
        }
    }

    public class KvpSelectResponse
    {
        public string HtmlId { get; set; }
        public string Title { get; set; }
        public List<Kvp> SelectItems { get; set; }
        public bool IsDisabled { get; set; }
    }

    public class Kvp
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
