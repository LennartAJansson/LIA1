namespace Start1.Model
{
    public record PersonOutput(int Id, string Firstname, string Lastname, string Email);
    public record PersonInput(string Firstname, string Lastname, string Email);
}
