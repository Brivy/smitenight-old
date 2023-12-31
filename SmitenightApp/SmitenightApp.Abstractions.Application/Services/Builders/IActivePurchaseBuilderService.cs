﻿using SmitenightApp.Domain.Clients.MatchClient;
using SmitenightApp.Domain.Models.Items;

namespace SmitenightApp.Abstractions.Application.Services.Builders;

public interface IActivePurchaseBuilderService
{
    Task<List<ActivePurchase>> BuildAsync(MatchDetailsResponse matchDetailsResponse, CancellationToken cancellationToken = default);
}