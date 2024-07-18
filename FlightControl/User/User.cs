using FlightControl.Rank;

namespace FlightControl.User;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public Role role { get; set; }
    public Ranks rank { get; set; }
}