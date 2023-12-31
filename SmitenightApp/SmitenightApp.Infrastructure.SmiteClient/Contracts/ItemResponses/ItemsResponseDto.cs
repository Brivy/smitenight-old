﻿using System.Text.Json.Serialization;

namespace SmitenightApp.Infrastructure.SmiteClient.Contracts.ItemResponses
{
    public record class ItemsResponseDto
    {
        [JsonPropertyName("ActiveFlag")] public string? ActiveFlag { get; set; }
        [JsonPropertyName("ChildItemId")] public int ChildItemId { get; set; }
        [JsonPropertyName("DeviceName")] public string? DeviceName { get; set; }
        [JsonPropertyName("Glyph")] public string? Glyph { get; set; }
        [JsonPropertyName("IconId")] public int IconId { get; set; }
        [JsonPropertyName("ItemDescription")] public ItemDescriptionDto? ItemDescription { get; set; }
        [JsonPropertyName("ItemId")] public int ItemId { get; set; }
        [JsonPropertyName("ItemTier")] public int ItemTier { get; set; }
        [JsonPropertyName("Price")] public int Price { get; set; }
        [JsonPropertyName("RestrictedRoles")] public string? RestrictedRoles { get; set; }
        [JsonPropertyName("RootItemId")] public int RootItemId { get; set; }
        [JsonPropertyName("ShortDesc")] public string? ShortDesc { get; set; }
        [JsonPropertyName("StartingItem")] public bool StartingItem { get; set; }
        [JsonPropertyName("Type")] public string? Type { get; set; }
        [JsonPropertyName("itemIcon_URL")] public string? ItemIconUrl { get; set; }
        [JsonPropertyName("ret_msg")] public string? RetMsg { get; set; }
    }

    public record class ItemDescriptionDto
    {
        [JsonPropertyName("Description")] public string? Description { get; set; }
        [JsonPropertyName("Menuitems")] public MenuItemDto[]? MenuItems { get; set; }
        [JsonPropertyName("SecondaryDescription")] public string? SecondaryDescription { get; set; }
    }

    public record class MenuItemDto
    {
        [JsonPropertyName("Description")] public string? Description { get; set; }
        [JsonPropertyName("Value")] public string? Value { get; set; }
    }
}
