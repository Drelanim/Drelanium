namespace Drelanium.DesignPatterns.Behavioral.Chain_Of_Responsibility
{
    public class SquirrelHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Nut")
            {
                return $"Squirrel: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}

//Output

//Chain: Monkey > Squirrel > Dog

//Client: Who wants a Nut?
//   Squirrel: I'll eat the Nut.
//Client: Who wants a Banana?
//   Monkey: I'll eat the Banana.
//Client: Who wants a Cup of coffee?
//   Cup of coffee was left untouched.

//Subchain: Squirrel > Dog

//Client: Who wants a Nut?
//   Squirrel: I'll eat the Nut.
//Client: Who wants a Banana?
//   Banana was left untouched.
//Client: Who wants a Cup of coffee?
//   Cup of coffee was left untouched.