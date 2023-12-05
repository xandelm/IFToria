using IFToria.Data;
using IFToria.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<AlunoDbContext>(options => {
    options.UseSqlite("Data Source=main.db");
});
builder.Services.AddDbContext<CoordenadorDbContext>(options => {
    options.UseSqlite("Data Source=main.db");
});
builder.Services.AddDbContext<TutoriaDbContext>(options => {
    options.UseSqlite("Data Source=main.db");
});
builder.Services.AddScoped<AlunoService>();
builder.Services.AddScoped<CoordenadorService>();
builder.Services.AddScoped<TutoriaService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
