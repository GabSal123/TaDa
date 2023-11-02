namespace QuickMedik.Model
{
    public class Proffesional : User
    {
        public float Rating { get; private set; }

        public List<Service> Specialties { get; private set; }

        public string WorkspaceId { get; private set; }
        
        public List<Time> Times { get; private set; }

        public Location Location { get; private set; }

        public Proffesional(float rating, List<Service> specialties, string workspaceId, List<Time> times, Location location,
            string ID, string Name,string Surname,string Email,string Phone) :base(ID, Name,Surname,Email,Phone)
        {
            Rating = rating;
            Specialties = specialties;
            WorkspaceId = workspaceId;
            Times = times;
            Location = location;
        }
    }
}
