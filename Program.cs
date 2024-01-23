using Amazon.Rekognition;
using InzynierkaApi.Context;
using InzynierkaApi.Repositories;
using InzynierkaApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICourseRepository,CourseRepository>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ITeacherRepository,TeacherRepository>();
builder.Services.AddScoped<IAttendanceRepository, AttendanceRepository>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();

builder.Services.AddScoped<FaceRecognitionService>(_ =>
{
    var similarityThreshold = float.Parse(builder.Configuration["FaceRecognition:SimilarityThreshold"]);
    var dbContext = _.GetRequiredService<AttendanceContext>();
    var awsAccesKey = builder.Configuration["AWS:AccessKey"];
    var awsSecretKey = builder.Configuration["AWS:SecretKey"];
    var attendanceRepository = _.GetRequiredService<IAttendanceRepository>();
    var studentRepository = _.GetRequiredService<IStudentRepository>();
    return new FaceRecognitionService(similarityThreshold, awsAccesKey, awsSecretKey, attendanceRepository, studentRepository);
});
builder.Services.AddScoped<AmazonRekognitionClient>(_ =>
{
    var awsAccessKey = builder.Configuration["AWS:AccessKey"];
    var awsSecretKey = builder.Configuration["AWS:SecretKey"];
    return new AmazonRekognitionClient(awsAccessKey, awsSecretKey, Amazon.RegionEndpoint.EUCentral1); // Replace YourRegion with your actual AWS region
});
// Db connectrion
var connection = string.Empty;
if (builder.Environment.IsDevelopment())
{
    builder.Configuration.AddEnvironmentVariables().AddJsonFile("appsettings.Development.json");
    connection = builder.Configuration.GetConnectionString("MYSQL_CONNECTIONSTRING");

}
else
{
    connection = Environment.GetEnvironmentVariable("MYSQL_CONNECTIONSTRING");
}

builder.Services.AddDbContext<AttendanceContext>(options =>
    options.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 23))));


var app = builder.Build();
app.UseCors("AllowAllOrigins");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();