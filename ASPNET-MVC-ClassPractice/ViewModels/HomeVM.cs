using System.Reflection.Metadata.Ecma335;

namespace ASPNET_MVC_ClassPractice.ViewModels
{
    public class HomeVM
    {
        public string Text { get; set; }
        public List<string> Students { get; set; }
        public List<User> Users { get; set; }
    }
}
