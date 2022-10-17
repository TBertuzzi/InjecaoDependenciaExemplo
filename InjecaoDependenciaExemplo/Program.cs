using InjecaoDependenciaExemplo;
using InjecaoDependenciaExemplo.Interfaces;
using InjecaoDependenciaExemplo.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IExemploTransient, Exemplo>();
builder.Services.AddScoped<IExemploScoped, Exemplo>();
builder.Services.AddSingleton<IExemploSingleton, Exemplo>();
builder.Services.AddSingleton<IExemploSingletonInstance>(new Exemplo(Guid.Empty));
builder.Services.AddTransient<ExemploService, ExemploService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
