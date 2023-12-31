﻿using SmitenightApp.Domain.Enums.Items;
using SmitenightApp.Domain.Interfaces;

namespace SmitenightApp.Domain.Models.Items
{
    public class Item : IEntity
    {
        public int Id { get; set; }
        public int SmiteId { get; set; }
        public int? RootItemId { get; set; }
        public int? ChildItemId { get; set; }

        public bool Enabled { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool Glyph { get; set; }
        public ItemTierEnum ItemTier { get; set; }
        public int Price { get; set; }
        public RestrictedRolesEnum RestrictedRoles { get; set; }
        public string? SecondaryDescription { get; set; }
        public string? ShortDescription { get; set; }
        public bool StartingItem { get; set; }
        public string ItemIconUrl { get; set; } = null!;

        #region Navigation

        public Item? RootItem { get; set; }
        public Item? ChildItem { get; set; }

        public List<ItemDescription> ItemDescriptions { get; set; }
        public List<ItemPurchase> ItemPurchases { get; set; }

        #endregion

        public Item()
        {
            ItemDescriptions = new List<ItemDescription>();
            ItemPurchases = new List<ItemPurchase>();
        }
    }
}
