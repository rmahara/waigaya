var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//��javascript��css�Ȃǁuwwwroot�v�t�H���_���g����悤�ɂ���
app.UseStaticFiles();


app.Run();
