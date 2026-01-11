# PadelTournament

PadelTournament is an open-source platform for tracking and publishing padel
tournament scores in real time.

## Purpose
The project is designed to support both small club tournaments and large-scale
open tournaments with many concurrent viewers.

## Core Principles
- Real-time score updates
- Horizontal scalability
- Cloud-agnostic architecture
- Open-source first

## Architecture Overview
- Public scoreboard: Blazor WebAssembly
- Admin / referee UI: Blazor Server
- Backend: Minimal API + SignalR
- Orchestration: .NET Aspire

See `docs/architecture.md` for full details.

## Running locally

```bash
dotnet restore
dotnet run --project src/PadelTournament.AppHost
```

## License
This project is licensed under the MIT License. See the LICENSE file for details.
