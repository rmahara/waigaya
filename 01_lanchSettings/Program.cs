//���̕��͂�MinimalAPI�ƌ����܂��B
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//https://localhost:7025/ ��URL��@�����Ƃ��ɁAHello world!��Get���\�b�h�ŕԂ�
app.MapGet("/", () => "Hello World!");
//�ȉ��͏�Ɠ����ł��閾���I�Ɏw��
app.MapGet("/2/", (HttpContext context) => context.Response.WriteAsync("Hello World!"));

//�}�b�v�𑝂₷���Ƃ��ł���B
app.MapGet("/Test/", () => "Test!!");
app.MapGet("/Hoge/", () => "Hoge!!");

//�p�����[�^��bind�ł���B
app.MapGet("/Student/{id}", (int id) => $"[{id}] �̐��k�ł�");

app.MapPost("/Update/{id}", (int id) => $"[{id}] �̐��k�̍X�V���������܂���!!");

app.MapDelete("/Delete/{id}", (int id) => $"[{id}] �̐��k���폜���܂����B");

//HTML��Ԃ��Ă݂�
string html = @$"
<!DOCTYPE html>
<html lang=""ja"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>�킢����� 2024/3/27</title>
</head>
<body>
    <h1>Hello World!!</h1>
    <p>�����̕׋���͂������ł����H</p>
</body>
</html>
";

app.MapGet("/html", (HttpContext context) => {
    context.Response.WriteAsync(html);  
});

//�����ƃ��X�|���X��text/html���w�肷��
//�������A�ŋ߂̓u���E�U���D�G�Ȃ̂ŁA����ɏ�̂悤��HTML�Ƃ��Ĕ��f���ĕ\�����Ă����
app.MapGet("/html2", (HttpContext context) => {
    context.Response.ContentType = "text/html";
    context.Response.WriteAsync(html);
});

app.Run();

/***
 * �yQA�z
 * Q. MapGet�Ƃ����ǎg��Ȃ��ł���H
 * A. �ŋ߂�MicroService��痬�s���Ă܂��B
 * �ŏ����̍\���ŁA�������A�v�������Ƃ��ɂ́AMVC�t���[�����[�N�Ȃ�ĕs�v�ŁA�S�Ď菑���ŏ������Ƃ����邩����H
 * ����ɁAController���g���ɂ��Ă��AEndPoint�̎d�g�݂�m���Ă����΁A���������Ƃ����₷���Ȃ�B
 */
