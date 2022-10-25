using _02_AbstractFactory.Abstract;

namespace _02_AbstractFactory
{
    public class ProductManager
    {
        private readonly CCCFactory _cCCFactory;
        private readonly Logger _logger;
        private readonly Cacher _cacher;

        public ProductManager(CCCFactory cCCFactory)
        {
            _cCCFactory = cCCFactory;
            _logger = _cCCFactory.CreateLogger();
            _cacher = _cCCFactory.CreateCaching();
        }

        public void GetAll()
        {
            _logger.Log("Log");
            _cacher.Cache("Data");
            Console.WriteLine("Ürünler Listelendi");
        }
    }
}