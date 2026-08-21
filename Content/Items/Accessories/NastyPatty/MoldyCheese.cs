using System.Collections.Generic;
using static HendecamMod.Content.Items.Accessories.NastyPatty.NastyPattyAccessory;

namespace HendecamMod.Content.Items.Accessories.NastyPatty;

public class MoldyCheese : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 16;
        Item.height = 16;
        Item.value = Item.sellPrice(silver: 4000);
        Item.rare = ItemRarityID.Orange;
        Item.accessory = true;
    }

    public override void ModifyTooltips(List<TooltipLine> tooltips)
    {
        tooltips.Add(new TooltipLine(Mod, "Tooltip#1", "Grants 50 Defense, Doubled Armor Penetraton, 33% more Generic Damage, and much higher jump speed"));
        tooltips.Add(new TooltipLine(Mod, "Tooltip#1", "No longer gain effects from Minecarts, Weapon, Armor, or Accessory Buffs"));
    }

    public override void UpdateEquip(Player player)
    {
        player.GetModPlayer<NastyPenetration>().NastyEffect = true;
        player.GetModPlayer<NastyDefense>().NastyEffect = true;
        player.GetModPlayer<NastyDamage>().NastyEffect = true;
        player.GetModPlayer<NastyJump>().NastyEffect = true;
        player.buffImmune[BuffID.TitaniumStorm] = true;
        player.buffImmune[BuffID.StardustGuardianMinion] = true;
        player.buffImmune[BuffID.ShadowDodge] = true;
        player.buffImmune[BuffID.BeetleEndurance1] = true;
        player.buffImmune[BuffID.BeetleEndurance2] = true;
        player.buffImmune[BuffID.BeetleEndurance3] = true;
        player.buffImmune[BuffID.BeetleMight1] = true;
        player.buffImmune[BuffID.BeetleMight2] = true;
        player.buffImmune[BuffID.BeetleMight3] = true;
        player.buffImmune[BuffID.SolarShield1] = true;
        player.buffImmune[BuffID.SolarShield2] = true;
        player.buffImmune[BuffID.SolarShield3] = true;
        player.buffImmune[BuffID.LeafCrystal] = true;
        player.buffImmune[BuffID.NebulaUpDmg1] = true;
        player.buffImmune[BuffID.NebulaUpDmg2] = true;
        player.buffImmune[BuffID.NebulaUpDmg3] = true;
        player.buffImmune[BuffID.NebulaUpLife1] = true;
        player.buffImmune[BuffID.NebulaUpLife2] = true;
        player.buffImmune[BuffID.NebulaUpLife3] = true;
        player.buffImmune[BuffID.NebulaUpMana1] = true;
        player.buffImmune[BuffID.NebulaUpMana2] = true;
        player.buffImmune[BuffID.NebulaUpMana3] = true;
        player.buffImmune[BuffID.BallistaPanic] = true;
        player.buffImmune[BuffID.RapidHealing] = true;
        player.buffImmune[BuffID.ParryDamageBuff] = true;
        player.buffImmune[BuffID.SoulDrain] = true;
        player.buffImmune[BuffID.HeartyMeal] = true;
        player.buffImmune[BuffID.CoolWhipPlayerBuff] = true;
        player.buffImmune[BuffID.ScytheWhipPlayerBuff] = true;
        player.buffImmune[BuffID.SwordWhipPlayerBuff] = true;
        player.buffImmune[BuffID.ThornWhipPlayerBuff] = true;
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
        player.buffImmune[BuffID.Werewolf] = true;
        player.buffImmune[BuffID.Merfolk] = true;
        player.buffImmune[BuffID.IceBarrier] = true;
        player.buffImmune[BuffID.PaladinsShield] = true;
        player.buffImmune[BuffID.Panic] = true;
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe = CreateRecipe();
        recipe.AddIngredient<Disenchanter>();
        recipe.AddIngredient<Lunchly>();
        recipe.AddTile(TileID.TinkerersWorkbench);
        recipe.AddTile(TileID.AlchemyTable);
        recipe.Register();
    }
}