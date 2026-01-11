using Projects;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<PadelTournament_Web>("padeltournament-web");

builder.Build().Run();
