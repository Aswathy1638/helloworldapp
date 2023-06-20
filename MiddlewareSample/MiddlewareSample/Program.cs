var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    // Existing code...

    app.Use(async (context, next) =>
    {
        // Log the request details
        var request = context.Request;
        var method = request.Method;
        var path = request.Path;
        Console.WriteLine($"Request: {method} {path}");

        // Call the next middleware in the pipeline
        await next.Invoke();

        // Any code after the next middleware will run after the response is generated
    });

    // Existing code...
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.UseAuthorization();

app.MapRazorPages();

app.Run();