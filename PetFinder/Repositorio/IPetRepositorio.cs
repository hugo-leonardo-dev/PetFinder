using PetFinder.Models;

namespace PetFinder.Repositorio
{
    public interface IPetRepositorio
    {
        List<PetModel> Listar();
        PetModel ListarPorId(int id);
        PetModel Criar(PetModel pet);
        PetModel Editar(PetModel pet);

        bool Apagar(int id);


    }
}
