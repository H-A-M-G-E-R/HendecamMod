using HendecamMod.Content.DamageClasses;
using HendecamMod.Content.Items.Weapons.Other;
using HendecamMod.Content.Projectiles;
using HendecamMod.Content.Tiles.Furniture;
using System.Collections.Generic;
using Terraria.DataStructures;

namespace HendecamMod.Content.Items;

public class TheMeltdown : ModItem
{
    public override void SetDefaults()
    {
        // This method quickly sets the whip's properties.
        // Mouse over to see its parameters.
        Item.DefaultToWhip(ProjectileType<AstaWhip>(), 33, 9, 4.25f);
        Item.rare = ItemRarityID.Red;
        Item.damage = 499;
        Item.useTime = 42;
        Item.useAnimation = 42;
        Item.knockBack = 15;
        Item.ArmorPenetration = 35;
        Item.width = 14;
        Item.height = 14;
        Item.value = 19500000;
        Item.DamageType = GetInstance<MeleeSummonDamage>();
    }

    public override void ModifyTooltips(List<TooltipLine> tooltips)
    {
        // Here we add a tooltipline that will later be removed, showcasing how to remove tooltips from an item
        var line = new TooltipLine(Mod, "Face", "Causes an instant explosion upon hitting an enemy");
        tooltips.Add(line);

        line = new TooltipLine(Mod, "Face", "'I'm a strong independent summoner player, i don't need my minions to commit war crimes for me!'")
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

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.FireWhip);
        recipe.AddIngredient<ChainReaction>();
        recipe.AddIngredient<FissionDrive>();
        recipe.AddTile<CultistCyclotronPlaced>();

        recipe.Register();
    }

    // Makes the whip receive melee prefixes
    public override bool MeleePrefix()
    {
        return true;
    }
}