namespace Drelanium.DesignPatterns.Behavioral.Chain_Of_Responsibility
{
    public class MonkeyHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Banana")
            {
                return $"Monkey: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}