using RoadMapApp.Model;
using RoadMapApp.Repositories;

namespace RoadMapApp.Services
{
    public class UserService : IUserService
    {
        private readonly IRulesRepository _rulesRepository;

        public UserService(IRulesRepository rulesRepository)
        {
            _rulesRepository = rulesRepository;
        }

        public void SaveUser(User user)
        {
            _rulesRepository.SaveUser(user);
        }
    }
}