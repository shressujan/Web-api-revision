namespace WebApplication.Models
{
    public class Admin: User
    {
        private int id;
        private int accessLevel;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int AccessLevel
        {
            get => accessLevel;
            set => accessLevel = value;
        }
    }
}