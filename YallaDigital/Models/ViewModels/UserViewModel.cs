namespace YallaDigital.Models.ViewModels
{
    public class UserViewModel
    {
        public IEnumerable<ApplicationUser> Users { get; set; }
        public string SearchTerm { get; set; }
        public string SelectedRole { get; set; }
        public List<string> Roles { get; set; }
    }
}
