using PetFinder.Enums;

namespace PetFinder.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public PerfilEnum Perfil { get; set; }
    }
}
