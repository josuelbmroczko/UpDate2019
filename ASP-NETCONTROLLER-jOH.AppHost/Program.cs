var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ASP_NETCONTROLLER_jOH>("asp-netcontroller-joh");

builder.Build().Run();
