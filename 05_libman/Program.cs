var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();
//�ÓI�t�@�C��
app.UseStaticFiles();
app.Run();


/*
 * libman�̎g����
 * �@wwwroot�t�H���_���쐬
 * �Alib�t�H���_���쐬
 * �Blib�t�H���_���E�N���b�N���āA�ǉ��A�N���C�A���g���̃��C�u����
 * 
 */