namespace Onion.Demo.EF
{
    public class DbContextFactory
    {
        public OnionContext Create()
        {
            return new OnionContext();
        }
    }
}
