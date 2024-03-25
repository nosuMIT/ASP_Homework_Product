namespace ASP_Homework_Product
{
    public class InMemoryConstants : IConstants
    {
        public string userId = "001";

        string IConstants.UserId
        {
            get { return userId; }
        }
    }

    public interface IConstants
    {
        public string UserId { get; }
    }
}
