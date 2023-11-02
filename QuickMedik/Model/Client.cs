namespace QuickMedik.Model
{
    public class Client : User
    {
        public List<Time> Reservations { private set; get; }

        public Client(List<Time> reservations, string ID, string Name, string Surname,string Email, string Phone):base(ID,Name,Surname,Email,Phone)
        {
            Reservations = reservations;
        }
        public void AddReservations(Time reservation) 
        {
            Reservations.Add(reservation);
        }
    }
}
