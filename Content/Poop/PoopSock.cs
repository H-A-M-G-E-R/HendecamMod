using HendecamMod.Common.Systems;
using HendecamMod.Content.DamageClasses;
using System.Collections.Generic;
using Terraria.DataStructures;

namespace HendecamMod.Content.Poop;

public class PoopSock : ModItem
{
    public override void SetDefaults()
    {
        // This method quickly sets the whip's properties.
        // Mouse over to see its parameters.
        Item.DefaultToWhip(ProjectileType<SockPoop>(), 20, 2, 7);
        Item.rare = ItemRarityID.White;
        Item.damage = 11;
        Item.useTime = 20;
        Item.useAnimation = 20;
        Item.knockBack = 2;
        Item.width = 14;
        Item.height = 14;
        Item.value = 1;
        Item.DamageType = GetInstance<SummonStupidDamage>();
    }
    public float LobotometerCost = 3f;
    public override bool? UseItem(Player player)
    {
        if (player.whoAmI == Main.myPlayer)
        {
            player.GetModPlayer<LobotometerPlayer>()
                  .AddLobotometer(LobotometerCost);
        }
        return base.UseItem(player);
    }
    public override void ModifyTooltips(List<TooltipLine> tooltips)
    {
        // Here we add a tooltipline that will later be removed, showcasing how to remove tooltips from an item
        var line = new TooltipLine(Mod, "Face", "3 summon tag damage");
        tooltips.Add(line);
        line = new TooltipLine(Mod, "Face", "Makes the user stinky")
        {
            Color = new Color(255, 255, 255)
        };
        tooltips.Add(line);
        line = new TooltipLine(Mod, "Face", "Uses 3 Braincells")
        {
            Color = new Color(255, 255, 255)
        };
        tooltips.Add(line);
        line = new TooltipLine(Mod, "Face", "Represents the average Summoner player (until whipstacking gets removed in 1.4.5)")
        {
            Color = new Color(255, 255, 255)
        };
        tooltips.Add(line);

        
    }

    public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
    {
        player.AddBuff(BuffID.Stinky, 61);
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
        recipe.AddIngredient(ItemID.PoopBlock, 4);
        recipe.AddIngredient(ItemID.Silk, 4);
        recipe.Register();
    }

    // Makes the whip receive melee prefixes
    public override bool MeleePrefix()
    {
        return true;
    }
}