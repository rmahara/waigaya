var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//★appSettings.jsonの設定の取得方法
//　launchSettings.jsonの設定（ASPNETCORE_ENVIRONMENT）を切り替えて、動作確認する。
app.MapGet("/", () => "ASPNETCORE_ENVIRONMENT_Test: " + app.Configuration.GetValue<string>("Test"));
//app.MapGet("/", () => "ASPNETCORE_ENVIRONMENT_Test: " + app.Configuration["Test"]);

//★jsonの階層構造の参照の仕方 コロンで区切る
//app.MapGet("/", () => "ASPNETCORE_ENVIRONMENT_Test: " + app.Configuration["Logging:LogLevel:Default"]);


//WebApplication.CreateBuilder(args);でやってることをリセットする

//ちなみにDevelopment環境のみ実行するようなDebug的な振る舞いも可能
if (app.Environment.IsDevelopment()) 
{
    //開発環境
    app.MapGet("/Dev/", () => "Development!!HOGEHOGE!!");
    //例えば、デバッグ環境だけユーザフレンドリーでないstacktraceメッセージを表示するような記述をここに書いたりする。
}
if (app.Environment.IsProduction()) 
{
    //本番環境
    app.MapGet("/Production/", () => "Production!!HOGEHOGE!!");
}
if (app.Environment.IsStaging()) 
{
    //本番環境に近い検証環境
}
if (app.Environment.IsEnvironment("Sample")) 
{
    app.MapGet("/Sample/", () => "Sample!!HOGEHOGE!!");
}

app.Run();
