namespace Models
{
    public class User
    {
        private int id;
        private string name;
        private string username;
        private string pass_word;
        private string role;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Pass_word { get => pass_word; set => pass_word = value; }
        public string Role { get => role; set => role = value; }
        public User(int id, string name, string username, string pass_word, string role)
        {
            this.id = id;
            this.name = name;
            this.username = username;
            this.pass_word = pass_word; 
            this.role = role;
        }
    }
}
