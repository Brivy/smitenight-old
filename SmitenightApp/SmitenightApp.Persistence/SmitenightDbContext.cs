﻿using Microsoft.EntityFrameworkCore;
using SmitenightApp.Domain.Models.Abilities;
using SmitenightApp.Domain.Models.Gods;
using SmitenightApp.Domain.Models.Items;
using SmitenightApp.Domain.Models.Matches;
using SmitenightApp.Domain.Models.Players;
using SmitenightApp.Domain.Models.Smitenights;

namespace SmitenightApp.Persistence
{
    public class SmitenightDbContext : DbContext
    {
        public SmitenightDbContext()
        {

        }

        public SmitenightDbContext(DbContextOptions<SmitenightDbContext> options) : base(options)
        {

        }

        public DbSet<Ability> Abilities => Set<Ability>();
        public DbSet<AbilityRank> AbilityRanks => Set<AbilityRank>();
        public DbSet<AbilityTag> AbilityTags => Set<AbilityTag>();

        public DbSet<BasicAttackDescription> BasicAttackDescriptions => Set<BasicAttackDescription>();
        public DbSet<God> Gods => Set<God>();
        public DbSet<GodBan> GodBans => Set<GodBan>();
        public DbSet<GodSkin> GodSkins => Set<GodSkin>();

        public DbSet<Active> Actives => Set<Active>();
        public DbSet<ActivePurchase> ActivePurchases => Set<ActivePurchase>();
        public DbSet<Consumable> Consumables => Set<Consumable>();
        public DbSet<ConsumableDescription> ConsumableDescriptions => Set<ConsumableDescription>();
        public DbSet<Item> Items => Set<Item>();
        public DbSet<ItemDescription> ItemDescriptions => Set<ItemDescription>();
        public DbSet<ItemPurchase> ItemPurchases => Set<ItemPurchase>();

        public DbSet<Match> Matches => Set<Match>();
        public DbSet<MatchDetail> MatchDetails => Set<MatchDetail>();

        public DbSet<Player> Players => Set<Player>();
        public DbSet<PlayerNameAttempt> PlayerNameAttempts => Set<PlayerNameAttempt>();

        public DbSet<SmitenightMatch> SmitenightMatches => Set<SmitenightMatch>();
        public DbSet<Smitenight> Smitenights => Set<Smitenight>();
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SmitenightDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#if (DEBUG)
            optionsBuilder.EnableSensitiveDataLogging();
#endif
            base.OnConfiguring(optionsBuilder);
        }
    }
}
