using _08_Proxy.Abstract;

namespace _08_Proxy.Concrete
{
    public class CreditManagerProxy : Credit
    {
        private CreditManager _creditManager;
        private int _cachedValue;

        public override int Calculate()
        {
            if (_creditManager == null)
            {
                _creditManager = new();
                _cachedValue = _creditManager.Calculate();
            }

            return _cachedValue;
        }
    }
}