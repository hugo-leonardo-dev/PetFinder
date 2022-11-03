using PetFinder.Models;

namespace PetFinder.Repositorio
{
    public class PetRepositorio : IPetRepositorio
    {
        private readonly BancoContext _bancoContext;
        public PetRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }


        public PetModel ListarPorId(int id)
        {
            return _bancoContext.Pets.FirstOrDefault(x => x.Id == id);
        }

        public List<PetModel> Listar()
        {
            return _bancoContext.Pets.ToList();
        }


        public PetModel Criar(PetModel pet)
        {
            _bancoContext.Pets.Add(pet);
            _bancoContext.SaveChanges();
            return pet;
        }

        public PetModel Editar(PetModel pet)
        {
            PetModel petDB = ListarPorId(pet.Id);

            if (petDB == null) throw new System.Exception("Houve um erro");

            petDB.Tipo = pet.Tipo;
            petDB.Raça = pet.Raça;
            petDB.Nome = pet.Nome;
            petDB.DataNascimento = pet.DataNascimento;
            petDB.Cor = pet.Cor;
            petDB.Peso = pet.Peso;

            _bancoContext.Pets.Update(petDB);
            _bancoContext.SaveChanges();

            return petDB;
        }

        public bool Apagar (int id)
        {
            PetModel petDB = ListarPorId(id);

            if (petDB == null) throw new System.Exception("Houve um erro");

            _bancoContext.Pets.Remove(petDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
