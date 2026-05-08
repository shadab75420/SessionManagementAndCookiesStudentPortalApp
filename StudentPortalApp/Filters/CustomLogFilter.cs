using Microsoft.AspNetCore.Mvc.Filters;

namespace StudentPortalApp.Filters
{
    public class CustomLogFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Action Executing");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("Action Executed");
        }
    }
}