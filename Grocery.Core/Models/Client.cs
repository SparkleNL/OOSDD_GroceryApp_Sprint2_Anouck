
namespace Grocery.Core.Models
{
    public partial class Client : Model
    {
        private string EmailAddress { get; set; }
        private string Password { get; set; }
        public Client(int id, string name, string emailAddress, string password) : base(id, name)
        {
            EmailAddress = emailAddress;
            Password = password;
        }
    }
}
