namespace QuickMedik.Model
{
    public class Proffesional : User
    {
        public float Rating { get; private set; } //by default 0, turi sekti kiek zmoniu reitingu uzdejo ir funkcijos calculateRating()

        public List<Service> Specialties { get; private set; } //Pradzioje tuscias, todel konstruktoriuje nereikia. Prisiregistraves daktaras gales tik tada susirasyti visus specialties

        public string WorkspaceId { get; private set; } //idk ar registruojantis ar po registracijos sita pasirenka
        
        public List<Time> Times { get; private set; } //sito irgi nereikai konstruktoriuje, nes tik prisiregistraves gales 

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
