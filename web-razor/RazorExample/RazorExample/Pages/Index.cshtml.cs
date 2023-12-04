using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorExample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public int RandomNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            RandomNumber = r.Next();
        }

        public void OnPost(string firstName, string lastName, string id)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            RandomNumber = r.Next();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }
    }
}