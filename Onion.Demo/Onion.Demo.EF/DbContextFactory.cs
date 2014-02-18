namespace Onion.Demo.EF
{
    internal class DbContextFactory
    {
        public OnionContext Create()
        {
            return new OnionContext();
        }
    }
}
