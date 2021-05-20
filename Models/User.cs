namespace WebApplication.Models
{
    public class User
    {
        private string name;
        private int age;
        private string gender;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string Gender
        {
            get => gender;
            set => gender = value;
        }
    }
}