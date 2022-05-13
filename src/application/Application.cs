using MySql.Data.MySqlClient;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace Application
{
    class Application
    {
        public static async Task HelloWorld(HttpContext context)
        {
            var connection = new MySqlConnection(
                "Host=localhost;Port=33060;User=user;Password=password;Database=db;SslMode=None"
            );
            var compiler = new MySqlCompiler();
            var users = new XQuery(connection, compiler).From("users").Get<User>();
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Id}, {user.Name}");
            }
            await context.Response.WriteAsync("Hello, World!");
        }
    }

    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public User(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

