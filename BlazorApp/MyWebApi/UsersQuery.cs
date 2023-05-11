namespace MyWebApi
{
    public class UsersQuery
    {
        [GraphQLName("users")]
        [UsePaging(IncludeTotalCount = true)]
        public IEnumerable<User>  GetAllUsers()
        {
            yield return new User()
            {
                Name = "rob"
            };
        }
    }

    public class User
    {
        public string Name { get; set; }
    }
}
