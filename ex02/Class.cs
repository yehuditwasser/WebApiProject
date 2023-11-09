namespace ex02
{
    public static class MiddlewareExtentionMethod
    {
        public static IApplicationBuilder UseTaskMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TaskMiddleware>();
        }
    }
}
