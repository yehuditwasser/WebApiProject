namespace ex02
{
    public class TaskMiddleware
    {
        private readonly RequestDelegate request;

        public TaskMiddleware(RequestDelegate request)
        {
            this.request = request;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            //await httpContext.Request.consoleWriteline(httpContext.Request.Method.ToString());

            await request(httpContext);
            await httpContext.Response.WriteAsync(httpContext.Request.Method.ToString());
        }
    }
}
