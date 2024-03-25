namespace ASP_Homework_Product
{
    public class InMemoryConstants : IConstants
    {
        public string UserId = "FirstUser";
        public string GetUserId
        {
            get { return UserId; }
        }
    }

    public interface IConstants
    {
        public string GetUserId { get; }
    }
}
