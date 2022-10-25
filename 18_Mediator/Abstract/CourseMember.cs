using _18_Mediator.Concrete;

namespace _18_Mediator.Abstract
{
    public abstract class CourseMember
    {
        protected Mediator Mediator;

        protected CourseMember(Mediator mediator)
        {
            Mediator = mediator;
        }
    }
}