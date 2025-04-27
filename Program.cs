using Supabase;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<Supabase.Client>(provider =>
{
    string Url = "https://strhgrynpbwxqonocsyd.supabase.co";
    string Key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InN0cmhncnlucGJ3eHFvbm9jc3lkIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDU3NjAwNTIsImV4cCI6MjA2MTMzNjA1Mn0._ztDIrGzHd1mQkHqY2dwt6_uQLrI3GQwYK45HDEXMA0"; // Replace with your Supabase API key
    return new Supabase.Client(Url, Key);
});

builder.Services.AddScoped<MovieService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
