using prova.Repositories;
using prova.Models;

namespace prova.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetUserInfo()
        {
            User user = new User();
            user.Name = "Erik Batista da Silva";
            user.Age = 20;
            user.bio = "Apaixonado por inovação e tecnologia, descobri que meu propósito é impactar a vida das pessoas através de soluções tecnológicas. Durante minha trajetória, participei de projetos para empresas como Uber, Alliance e SAP, desenvolvendo sistemas práticos com foco em eficiência e inovação. Atuei no BTG Pactual e na Implanta IT Solutions, onde reduzi significativamente o tempo de processos com IA e otimização de sistemas.";
            user.habilidade1 = "JavaScript";
            user.habilidade2 = "Python";
            user.habilidade3 = "C#";

            user.exp1 = "Desenvolvedor na empresa IMPLANTA IT Solutions";
            user.exp2 = "Desenvolvedor na empresa BTG Pactual";
            user.exp3 = "Analista de dados na empresa Itau Unibanco";

            user.linkedin = "https://www.linkedin.com/in/erik-batista-da-silva-455612215/edit/forms/summary/new/?profileFormEntryPoint=PROFILE_SECTION";
            user.github = "https://github.com/3R11K";

            await _userRepository.CreateUser(user);
            return await _userRepository.GetUser();
        }
        public async Task<User> UpdateUserInfo(User user)
        {
            return await _userRepository.UpdateUser(user);
        }

    }
}