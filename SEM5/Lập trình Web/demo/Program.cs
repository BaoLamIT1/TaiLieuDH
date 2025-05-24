var builder = WebApplication.CreateBuilder(args);

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
    //name: "default",    // Name can be changed 
    //pattern: "{controller=Home}/{action=Index}/{id?}"); // truy cập vào Home -> Index
        // khuôn dạng của URL gồm 3 thành phần bên trong {}, 3 thànhkhuôn dạng của URL gồm 3 thành phần bên trong {}, 3 thànhphần tương ứng với controller và action và id
    //vd: pattern: "{controller=MyController1}/{action=Add}/{id?}");   // truy cập vào MyController1 -> Add
     name: "blog",
     pattern: "blog/{*article}",   // cấu hình "blog/{*....}" 
     defaults: new { controller = "Home", action = "Index" });
     app.MapControllerRoute(name: "default",
     pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
