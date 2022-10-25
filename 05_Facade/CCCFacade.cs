using _05_Facade.Concrete;
using _05_Facade.Interfaces;

namespace _05_Facade
{
    public class CCCFacade
    {
        public readonly ILogging _logging;
        public readonly ICaching _caching;
        public readonly IAuthorization _authorization;
        public readonly IValidation _validation;

        public CCCFacade()
        {
            _logging = new Logging();
            _caching = new Caching();
            _authorization = new Authorization();
            _validation = new Validation();
        }
    }
}