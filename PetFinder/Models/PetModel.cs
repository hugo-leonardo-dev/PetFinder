using System.ComponentModel.DataAnnotations;

namespace PetFinder.Models
{
    public class PetModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Informe o tipo do animal!")]
        public string Tipo { get; set; }

        [Required(ErrorMessage ="Informe a raça do animal!")]
        public string Raça { get; set; }
      
        [Required(ErrorMessage = "Informe o nome do animal!")]
        public string Nome { get; set; }
       
        [Required(ErrorMessage = "Informe a cor do animal!")]
        public string Cor{ get; set; }
       
        [Required(ErrorMessage = "Informe o peso do animal!")]
        public float Peso { get; set; }
        
        [Required(ErrorMessage = "Informe a data de nascimento do animal!")]
        public DateTime DataNascimento { get; set; }
        


    }
}
