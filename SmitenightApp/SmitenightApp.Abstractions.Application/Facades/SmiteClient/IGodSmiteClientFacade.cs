﻿using SmitenightApp.Domain.Clients.GodClient;
using SmitenightApp.Domain.Clients.SmiteClient;
using SmitenightApp.Domain.Enums.SmiteClient;

namespace SmitenightApp.Abstractions.Application.Facades.SmiteClient;

public interface IGodSmiteClientFacade
{
    Task<SmiteClientListResponse<GodsResponse>?> GetGodsAsync(LanguageCodeEnum languageCode, CancellationToken cancellationToken = default);
    Task<SmiteClientListResponse<GodLeaderbordResponse>?> GetGodLeaderbordAsync(int godId, GameModeQueueIdEnum gameModeQueueId, CancellationToken cancellationToken = default);
    Task<SmiteClientListResponse<GodAltAbilitiesResponse>?> GetGodAltAbilitiesAsync(CancellationToken cancellationToken = default);
    Task<SmiteClientListResponse<GodSkinsResponse>?> GetGodSkinsAsync(int godId, LanguageCodeEnum languageCode, CancellationToken cancellationToken = default);
}