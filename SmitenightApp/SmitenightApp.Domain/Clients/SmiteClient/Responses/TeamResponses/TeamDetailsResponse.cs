﻿namespace SmitenightApp.Domain.Clients.SmiteClient.Responses.TeamResponses
{
    public record class TeamDetailsResponse
    (
        string? AvatarUrl,
        string? Founder,
        string? FounderId,
        int Losses,
        string? Name,
        int Players,
        int Rating,
        string? Tag,
        int TeamId,
        int Wins,
        string? RetMsg
    );
}
