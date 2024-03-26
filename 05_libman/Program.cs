var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();
//静的ファイル
app.UseStaticFiles();
app.Run();


/*
 * libmanの使い方
 * ①wwwrootフォルダを作成
 * ②libフォルダを作成
 * ③libフォルダを右クリックして、追加、クライアント側のライブラリ
 * 
 */