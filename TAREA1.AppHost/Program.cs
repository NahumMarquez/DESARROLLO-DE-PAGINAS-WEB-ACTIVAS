var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.TAREA1>("tarea1");

builder.Build().Run();
