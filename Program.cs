using Login_Program_By_Middleware_in_Aspnet_c_sharp.CustomLoginMiddleware;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.UseLoginMiddleware();
app.Run();
