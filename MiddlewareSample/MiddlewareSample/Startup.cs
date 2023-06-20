public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
