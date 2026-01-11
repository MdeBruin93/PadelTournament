# GitHub Copilot Instructions

This file provides architectural and coding guidance for GitHub Copilot.
Copilot should treat this file as authoritative project context.

---

## Project Overview
Project name: **PadelTournament**

An open-source, cloud-agnostic platform for real-time padel tournament scoring.

Key goals:
- Real-time updates
- High scalability for public viewers
- Clean separation of concerns
- Open-source friendly dependencies only

---

## Architecture Rules (VERY IMPORTANT)

### Layered Architecture
The solution is strictly layered:

- **Web / Web.Client** → UI only
- **ApiService** → Application + realtime orchestration
- **Core** → Domain logic ONLY
- **Infrastructure** → Persistence & integrations
- **Contracts** → DTOs, Commands, Events

### Dependency Rules
Copilot MUST NOT generate code that violates these rules:

- Core MUST NOT reference:
  - ASP.NET Core
  - SignalR
  - EF Core
  - UI frameworks
- Contracts MUST remain stable and backward-compatible
- UI projects MUST NOT contain business rules
- Infrastructure MUST NOT leak into Core

---

## Frontend Rules

### Rendering Model
- Public UI → Blazor WebAssembly (`InteractiveWebAssembly`)
- Admin UI → Blazor Server (`InteractiveServer`)

### UI Libraries
- Public UI: **Bootstrap only**
- Admin UI: **MudBlazor only**
- Do NOT mix UI libraries in the same surface

---

## Realtime Rules

- All realtime communication uses **SignalR**
- SignalR Hubs live in `ApiService`
- Clients subscribe using group-based routing:
  - `tournament:{id}`
  - `court:{id}`
  - `match:{id}`
- Events MUST use Contracts project types

---

## Coding Style

- C# nullable reference types enabled
- Prefer explicit types over `var` in public APIs
- Use records for DTOs and events
- Avoid static state

---

## Testing Expectations

When generating code, Copilot SHOULD:
- Suggest unit tests for Core logic
- Suggest integration tests for ApiService endpoints
- Avoid UI tests unless explicitly requested

---

## Open Source & Licensing

- Only permissive licenses allowed (MIT, Apache-2.0, BSD)
- Do NOT suggest commercial UI libraries
- Do NOT introduce vendor lock-in APIs

---

## When in doubt
If architectural uncertainty exists:
- Prefer simplicity
- Keep Core pure
- Keep Contracts explicit
