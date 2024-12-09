using Yedidim.Core.Entities;

namespace Yedidim
{
    public class Volunteer
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Pwd { get; set; }
        public string Phone { get; set; }
        public List<CallFromPeople> callFromPeople { get; set; }

    }
}
