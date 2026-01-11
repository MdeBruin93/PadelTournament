var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PadelTournament_Web>("padeltournament-web");

builder.Build().Run();
