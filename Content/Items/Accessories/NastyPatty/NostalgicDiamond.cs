using System.Collections.Generic;
using static HendecamMod.Content.Items.Accessories.NastyPatty.NastyPattyAccessory;

namespace HendecamMod.Content.Items.Accessories.NastyPatty;

public class NostalgicDiamond : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 16;
        Item.height = 16;
        Item.value = Item.sellPrice(silver: 500);
        Item.rare = ItemRarityID.Orange;
        Item.accessory = true;
    }

    public override void ModifyTooltips(List<TooltipLine> tooltips)
    {
        var line = new TooltipLine(Mod, "Face", "Grants much higher jump speed, at the cost of Minecarts");
        tooltips.Add(line);
    }

    public override void UpdateEquip(Player player)
    {
        player.GetModPlayer<NastyJump>().NastyEffect = true;
        player.buffImmune[BuffID.Minecart] = true;
        player.buffImmune[BuffID.MinecartLegacyUnused] = true;
        player.buffImmune[BuffID.MinecartMech] = true;
        player.buffImmune[BuffID.MinecartMechLegacyUnused] = true;
        player.buffImmune[BuffID.MinecartWood] = true;
        player.buffImmune[BuffID.MinecartWoodLegacyUnused] = true;
        player.buffImmune[BuffID.AmberMinecart] = true;
        player.buffImmune[BuffID.AmberMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.AmethystMinecart] = true;
        player.buffImmune[BuffID.AmethystMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.BeeMinecart] = true;
        player.buffImmune[BuffID.BeeMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.BeetleMinecart] = true;
        player.buffImmune[BuffID.BeetleMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.CoffinMinecart] = true;
        player.buffImmune[BuffID.CoffinMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.DesertMinecart] = true;
        player.buffImmune[BuffID.DesertMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.DiamondMinecart] = true;
        player.buffImmune[BuffID.DiamondMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.DiggingMoleMinecart] = true;
        player.buffImmune[BuffID.DiggingMoleMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.EmeraldMinecart] = true;
        player.buffImmune[BuffID.EmeraldMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.FartMinecart] = true;
        player.buffImmune[BuffID.FartMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.FishMinecart] = true;
        player.buffImmune[BuffID.FishMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.HellMinecart] = true;
        player.buffImmune[BuffID.HellMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.LadybugMinecart] = true;
        player.buffImmune[BuffID.LadybugMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.MeowmereMinecart] = true;
        player.buffImmune[BuffID.MeowmereMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.PartyMinecart] = true;
        player.buffImmune[BuffID.PartyMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.PigronMinecart] = true;
        player.buffImmune[BuffID.PigronMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.PirateMinecart] = true;
        player.buffImmune[BuffID.PirateMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.RubyMinecart] = true;
        player.buffImmune[BuffID.RubyMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.SapphireMinecart] = true;
        player.buffImmune[BuffID.SapphireMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.ShroomMinecart] = true;
        player.buffImmune[BuffID.ShroomMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.SteampunkMinecart] = true;
        player.buffImmune[BuffID.SteampunkMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.SunflowerMinecart] = true;
        player.buffImmune[BuffID.SunflowerMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.TerraFartMinecart] = true;
        player.buffImmune[BuffID.TerraFartMinecartLegacyUnused] = true;
        player.buffImmune[BuffID.TopazMinecart] = true;
        player.buffImmune[BuffID.TopazMinecartLegacyUnused] = true;
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.DiamondMinecart);
        recipe.AddTile(TileID.HeavyWorkBench);
        recipe.Register();
    }
}