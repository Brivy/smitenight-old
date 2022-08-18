﻿namespace SmitenightApp.Domain.Clients.SmiteClient.Responses.OtherResponses
{
    public record class MotdResponse
    (
        string? Description,
        string? GameMode,
        string? MaxPlayers,
        string? Name,
        string? RetMsg,
        string? StartDateTime,
        string? Team1GodsCsv,
        string? Team2GodsCsv,
        string? Title
    );
}
