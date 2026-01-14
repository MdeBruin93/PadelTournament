using Aspire.Hosting;
using Azure.Provisioning.ContainerRegistry;
using Projects;

var builder = DistributedApplication.CreateBuilder(args);

// Add (or reference) the registry
var padeltournamentAcr = builder.AddAzureContainerRegistry("padeltournament-acr");

builder.AddAzureContainerAppEnvironment("padeltournament-aca")
    .WithAzureContainerRegistry(padeltournamentAcr);

var web = builder.AddProject<PadelTournament_Web>("padeltournament-web");

if (builder.ExecutionContext.IsPublishMode)
{
    web
        .WithRoleAssignments(padeltournamentAcr, ContainerRegistryBuiltInRole.AcrPush)
        .WithReplicas(0);
}

builder.Build().Run();
