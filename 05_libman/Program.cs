var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();
//静的ファイル
app.UseStaticFiles();
app.Run();


/*
 * libmanの使い方
 * �@wwwrootフォルダを作成
 * �Alibフォルダを作成
 * �Blibフォルダを右クリックして、追加、クライアント側のライブラリ
 * 
 */