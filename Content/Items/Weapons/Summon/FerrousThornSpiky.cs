using System.Collections.Generic;
using HendecamMod.Content.Projectiles;
using Terraria.GameContent.ItemDropRules;
using Terraria.DataStructures;

namespace HendecamMod.Content.Items.Weapons.Summon;

public class FerrousThornSpiky : ModItem
{
    public override void SetDefaults()
    {
        // This method quickly sets the whip's properties.
        // Mouse over to see its parameters.
        Item.DefaultToWhip(ProjectileType<FerroWhipSpiky>(), 33, 9, 5f, 33);
        Item.rare = ItemRarityID.LightRed;
        Item.damage = 72;
        Item.useTime = 33;
        Item.useAnimation = 33;
        Item.knockBack = 7f;
        Item.ArmorPenetration = 15;
        Item.width = 18;
        Item.height = 18;
        Item.value = 390000;
    }

    public override void ModifyTooltips(List<TooltipLine> tooltips)
    {
        // Here we add a tooltipline that will later be removed, showcasing how to remove tooltips from an item
        var line = new TooltipLine(Mod, "Face", "9 summon tag damage");
        tooltips.Add(line);

        line = new TooltipLine(Mod, "Face", "Right click in the inventory to swap variants")
        {
            Color = new Color(255, 255, 255)
        };
        tooltips.Add(line);
        line = new TooltipLine(Mod, "Face", "Spiky variant: Higher direct damage and +15 armor penetration, but lower speed and tag damage")
        {
            Color = new Color(255, 255, 255)
        };
        tooltips.Add(line);
    }

    public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
    {
        // This gives some visual variance on how fast the whip swinging animation plays out.
        // This has no effect on the actual collision.
        float swingDirection = 0.6f + (0.4f * Main.rand.NextFloat());
        // 1/3 of the time, swing the whip from the bottom to top instead of from top to bottom.
        // The Dark Harvest is the only whip that doesn't have the chance of swinging from the bottom up.
        if (Main.rand.NextBool(3))
        {
            swingDirection *= -2.5f;
        }
        // Set swingDirection to 1f for the pre-1.4.5 behavior.

        Projectile.NewProjectile(source, position, velocity, type, damage, knockback, player.whoAmI, 0f, swingDirection);
        return false; // Return false because we've already spawned the projectile.
    }

    public override bool CanRightClick()
    {
        return true;
    }

    public override void ModifyItemLoot(ItemLoot itemLoot)
    {
        itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemType<FerrousThornSmooth>()));
    }

    public override void AddRecipes()
    {
        Recipe
            recipe = CreateRecipe();
        recipe.AddRecipeGroup("IronBar", 15);
        recipe.AddIngredient<CrudeOil>(35);
        recipe.AddIngredient<RefinedOil>(35);
        recipe.AddTile(TileID.MythrilAnvil);

        recipe.Register();
    }

    // Makes the whip receive melee prefixes
    public override bool MeleePrefix()
    {
        return true;
    }
}