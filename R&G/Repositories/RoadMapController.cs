using RoadMapApp.Model;
using RoadMapApp.Services;
using RoadMapApp.Repositories;

namespace RoadMapApp.Controller
{
    public class RoadMapController
    {
        private readonly IUserService _userService;

        public RoadMapController(IUserService userService)
        {
            _userService = userService;
        }

        public void RegisterUser(User user)
        {
            _userService.SaveUser(user);
        }

        public RoadMap GetRoadMap(User user)
        {
            var roadMap = new RoadMap();
            roadMap.Initialize(user);
            return roadMap;
        }
    }
}