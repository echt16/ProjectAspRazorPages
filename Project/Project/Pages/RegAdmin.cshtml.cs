using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Models;

namespace Project.Pages
{
    public class RegAdminModel : PageModel
    {
        public QuestRoomContext context;
        public RegAdminModel(QuestRoomContext db)
        {
            context = db;
        }
        public void OnPost(string name, string login, string password)
        {
            if (name == null || login == null || password == null) return;
            User u = new User()
            {
                Name = name,
                Login = login,
                Password = password,
                Role = "Admin"
            };
            context.Users.Add(u);
            context.SaveChanges();
        }
    }
}
