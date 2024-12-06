using System.Collections.Generic;

namespace RoadMapApp.Model
{
    public class RoadMap
    {
        public List<RoadMapPoint> Points { get; set; } = new List<RoadMapPoint>();

        public void Initialize(User user)
        {
            Points.Clear();
            if (user.Goal == "Отметка в качестве участника Государственной программы переселения соотечественников")
            {
                Points.Add(new RoadMapPoint { Title = "Постановка на учет", IsCompleted = user.RegistrationDate.HasValue });
            }
            else if (user.Goal == "Компенсация расходов по найму жилья")
            {
                Points.Add(new RoadMapPoint { Title = "Постановка на учет", IsCompleted = user.RegistrationDate.HasValue });
                Points.Add(new RoadMapPoint { Title = "Получение компенсации" });
            }
        }
    }
}