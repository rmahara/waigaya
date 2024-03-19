//この文章はMinimalAPIと言います。
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//https://localhost:7025/ のURLを叩いたときに、Hello world!をGetメソッドで返す
app.MapGet("/", () => "Hello World!");
//以下は上と同じである明示的に指定
app.MapGet("/2/", (HttpContext context) => context.Response.WriteAsync("Hello World!"));

//マップを増やすこともできる。
app.MapGet("/Test/", () => "Test!!");
app.MapGet("/Hoge/", () => "Hoge!!");

//パラメータもbindできる。
app.MapGet("/Student/{id}", (int id) => $"[{id}] の生徒です");

app.MapPost("/Update/{id}", (int id) => $"[{id}] の生徒の更新が成功しました!!");

app.MapDelete("/Delete/{id}", (int id) => $"[{id}] の生徒を削除しました。");

//HTMLを返してみる
string html = @$"
<!DOCTYPE html>
<html lang=""ja"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>わいがや会 2024/3/27</title>
</head>
<body>
    <h1>Hello World!!</h1>
    <p>今日の勉強会はいかがですか？</p>
</body>
</html>
";

app.MapGet("/html", (HttpContext context) => {
    context.Response.WriteAsync(html);  
});

//ちゃんとレスポンスにtext/htmlを指定する
//ただし、最近はブラウザが優秀なので、勝手に上のようにHTMLとして判断して表示してくれる
app.MapGet("/html2", (HttpContext context) => {
    context.Response.ContentType = "text/html";
    context.Response.WriteAsync(html);
});

app.Run();

/***
 * 【QA】
 * Q. MapGetとか結局使わないでしょ？
 * A. 最近はMicroServiceやら流行ってます。
 * 最小限の構成で、小さいアプリを作るときには、MVCフレームワークなんて不要で、全て手書きで書くこともあるかもよ？
 * それに、Controllerを使うにしても、EndPointの仕組みを知っておけば、少しだけとっつきやすくなる。
 */
