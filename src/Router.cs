namespace Router
{
    class Router
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", Application.Application.HelloWorld);

            app.Run();
        }
    }
}
