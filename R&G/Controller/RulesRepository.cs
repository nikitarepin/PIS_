using System;
using System.IO;
using RoadMapApp.Model;

namespace RoadMapApp.Repositories
{
    public class RulesRepository : IRulesRepository
    {
        private const string UserFilePath = "users.csv";

        public void SaveUser(User user)
        {
            using (StreamWriter writer = new StreamWriter(UserFilePath, true))
            {
                writer.WriteLine($"{user.Goal},{user.RegistrationDate}");
            }
        }
    }
}