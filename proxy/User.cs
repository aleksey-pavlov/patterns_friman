namespace proxy
{
    public class User : IUser
    {
        private UserRole role { get; set; }

        public User(UserRole role)
        {
            this.role = role;
        }

        public UserRole GetRole()
        {
            return role;
        }
    }
}