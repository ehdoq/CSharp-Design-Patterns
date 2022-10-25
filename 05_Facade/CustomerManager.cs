namespace _05_Facade
{
    public class CustomerManager : CCCFacade
    {
        private readonly CCCFacade _cCCFacade;

        public CustomerManager()
        {
            _cCCFacade = new();
        }

        public void Save()
        {
            _cCCFacade._logging.Log();
            _cCCFacade._caching.Cache();
            _cCCFacade._authorization.Authorize();
            _cCCFacade._validation.Validate();

            Console.WriteLine("\nKaydedildi.");
        }
    }
}