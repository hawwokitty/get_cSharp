namespace FriendFace
{
    internal class LoggedInUser(string email, string password)
    {
        public string Email { get; private set; } = email;
        private string Password { get; set; } = password;
    }
}
