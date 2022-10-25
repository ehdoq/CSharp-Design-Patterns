using _16_State.Classes;

namespace _16_State.Interfaces
{
    public interface IState
    {
        void DoAction(Context context);
    }
}