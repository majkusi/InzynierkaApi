using Amazon.Rekognition;
using InzynierkaApi.Context;
using InzynierkaApi.Repositories;
using InzynierkaApi.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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
builder.Services.AddScoped<LoginService>();
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
// Login service 
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "your-issuer",
        ValidAudience = "your-audience",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("awsf7r6546g67s5edf765a76d5gf76as789sdfb6sd7fszd"))
    };
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

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
