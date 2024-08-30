var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.TestAspire>("testaspire");

builder.Build().Run();