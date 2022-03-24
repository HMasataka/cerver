namespace Application
{
    class Func
    {
        public static async Task HelloWorld(HttpContext context)
        {
            await context.Response.WriteAsync("Hello, World!");
        }
    }
}
