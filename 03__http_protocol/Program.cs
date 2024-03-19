var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//★javascriptやcssなど「wwwroot」フォルダを使えるようにする
app.UseStaticFiles();


app.Run();
