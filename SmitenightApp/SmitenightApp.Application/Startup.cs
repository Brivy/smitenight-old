﻿using Microsoft.Extensions.DependencyInjection;
using SmitenightApp.Abstractions.Application.Facades.SmiteClient;
using SmitenightApp.Abstractions.Application.Services.Builders;
using SmitenightApp.Abstractions.Application.Services.Cache;
using SmitenightApp.Abstractions.Application.Services.Common;
using SmitenightApp.Abstractions.Application.Services.Gods;
using SmitenightApp.Abstractions.Application.Services.Maintenance;
using SmitenightApp.Abstractions.Application.Services.Matches;
using SmitenightApp.Abstractions.Application.Services.Players;
using SmitenightApp.Abstractions.Application.Services.Smitenights;
using SmitenightApp.Application.Facades.SmiteClient;
using SmitenightApp.Application.Services.Builders;
using SmitenightApp.Application.Services.Cache;
using SmitenightApp.Application.Services.Common;
using SmitenightApp.Application.Services.Gods;
using SmitenightApp.Application.Services.Maintenance;
using SmitenightApp.Application.Services.Matches;
using SmitenightApp.Application.Services.Players;
using SmitenightApp.Application.Services.Smitenights;

namespace SmitenightApp.Application
{
    public static class Startup
    {
        public static void ConfigureServices(IServiceCollection serviceCollection)
        {
            #region Facades

            serviceCollection.AddScoped<IGodSmiteClientFacade, GodSmiteClientFacade>();
            serviceCollection.AddScoped<IItemSmiteClientFacade, ItemSmiteClientFacade>();
            serviceCollection.AddScoped<ILeagueSmiteClientFacade, LeagueSmiteClientFacade>();
            serviceCollection.AddScoped<IMatchSmiteClientFacade, MatchSmiteClientFacade>();
            serviceCollection.AddScoped<IOtherSmiteClientFacade, OtherSmiteClientFacade>();
            serviceCollection.AddScoped<IPlayerSmiteClientFacade, PlayerSmiteClientFacade>();
            serviceCollection.AddScoped<IRetrievePlayerSmiteClientFacade, RetrievePlayerSmiteClientFacade>();
            serviceCollection.AddScoped<ISystemSmiteClientFacade, SystemSmiteClientFacade>();
            serviceCollection.AddScoped<ITeamSmiteClientFacade, TeamSmiteClientFacade>();

            #endregion

            #region Services

            // Builder services
            serviceCollection.AddScoped<IActivePurchaseBuilderService, ActivePurchaseBuilderService>();
            serviceCollection.AddScoped<IGodBanBuilderService, GodBanBuilderService>();
            serviceCollection.AddScoped<IGodBuilderService, GodBuilderService>();
            serviceCollection.AddScoped<IItemBuilderService, ItemBuilderService>();
            serviceCollection.AddScoped<IItemPurchaseBuilderService, ItemPurchaseBuilderService>();
            serviceCollection.AddScoped<IMatchBuilderService, MatchBuilderService>();
            serviceCollection.AddScoped<IMatchDetailBuilderService, MatchDetailBuilderService>();
            serviceCollection.AddScoped<IPlayerBuilderService, PlayerBuilderService>();
            serviceCollection.AddScoped<ISmitenightBuilderService, SmitenightBuilderService>();

            // Cache services
            serviceCollection.AddScoped<ISmiteSessionCacheService, SmiteSessionCacheService>();

            // Common services
            serviceCollection.AddSingleton<IClock, Clock>();

            // Maintenance services
            serviceCollection.AddScoped<IMaintainSmitenight, MaintainSmitenight>();
            serviceCollection.AddScoped<IMaintainItemsService, MaintainItemsService>();
            serviceCollection.AddScoped<IMaintainGodsService, MaintainGodsService>();

            // Matches services
            serviceCollection.AddScoped<IImportMatchService, ImportMatchService>();

            // Player services
            serviceCollection.AddScoped<IPlayerService, PlayerService>();
            serviceCollection.AddScoped<IPlayerNameAttemptService, PlayerNameAttemptService>();

            // Smitenight services
            serviceCollection.AddScoped<ISmitenightService, SmitenightService>();

            // God services
            serviceCollection.AddScoped<IGodService, GodService>();

            #endregion
        }
    }
}
