using Microsoft.EntityFrameworkCore;
using Data.Contexts;
using Business.Services;
using Business.Interfaces.Services;
using Data.Interfaces.IRepository;
using Data.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IMemberService, MemberService>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IStatusService, StatusService>();
builder.Services.AddScoped<IMemberRepository, MemberRepository>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<IStatusRepository, StatusRepository>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapStaticAssets();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Members}/{action=teammembers}/{id?}")
    .WithStaticAssets();

app.Run();
