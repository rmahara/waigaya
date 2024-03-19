var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//��appSettings.json�̐ݒ�̎擾���@
app.MapGet("/", () => "ASPNETCORE_ENVIRONMENT_Test: " + app.Configuration.GetValue<string>("Test"));
//app.MapGet("/", () => "ASPNETCORE_ENVIRONMENT_Test: " + app.Configuration["Test"]);

//��json�̊K�w�\���̎Q�Ƃ̎d�� �R�����ŋ�؂�
//app.MapGet("/", () => "ASPNETCORE_ENVIRONMENT_Test: " + app.Configuration["Logging:LogLevel:Default"]);


//WebApplication.CreateBuilder(args);�ł���Ă邱�Ƃ����Z�b�g����

//���Ȃ݂�Development���̂ݎ��s����悤��Debug�I�ȐU�镑�����\
if (app.Environment.IsDevelopment()) 
{
    //�J����
    app.MapGet("/Dev/", () => "Development!!HOGEHOGE!!");
    //�Ⴆ�΁A�f�o�b�O���������[�U�t�����h���[�łȂ�stacktrace���b�Z�[�W��\������悤�ȋL�q�������ɏ������肷��B
}
if (app.Environment.IsProduction()) 
{
    //�{�Ԋ�
    app.MapGet("/Production/", () => "Production!!HOGEHOGE!!");
}
if (app.Environment.IsStaging()) 
{
    //�{�Ԋ��ɋ߂����؊�
}
if (app.Environment.IsEnvironment("Sample")) 
{
    app.MapGet("/Sample/", () => "Sample!!HOGEHOGE!!");
}

app.Run();
