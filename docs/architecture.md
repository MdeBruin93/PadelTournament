# Architecture

## Overview
PadelTournament follows a layered architecture with a clear separation
between UI, domain logic, and infrastructure.

### Main Components
- Web Host (Blazor Web App)
- WebAssembly Client
- ApiService
- Core (Domain)
- Infrastructure
- Aspire AppHost

## Frontend
Public-facing pages run fully client-side using WebAssembly.
Administrative functionality uses Blazor Interactive Server.

## Realtime Communication
Realtime updates are delivered via SignalR hubs.
Clients subscribe to tournament-, court-, and match-level groups.

## Scalability
- No server-side UI state for public viewers
- SignalR can scale out using a Redis backplane
- API services remain stateless

## Security
- Public endpoints are read-only
- Administrative endpoints require authentication and authorization
