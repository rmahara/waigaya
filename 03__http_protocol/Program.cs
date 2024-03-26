var builder = WebApplication.CreateBuilder(args);

// ControllersがViewsを呼び出すように変更
builder.Services.AddControllersWithViews();

var app = builder.Build();

//HTTPSの適応に必要な設定
app.UseHttpsRedirection();

//javascriptやcssなど静的ファイルの有効化
//「wwwroot」フォルダを使えるようにする
app.UseStaticFiles();

app.UseRouting();
//Controllerのルーティング設定
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
