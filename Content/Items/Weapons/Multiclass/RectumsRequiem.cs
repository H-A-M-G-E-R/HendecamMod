using HendecamMod.Common.Systems;
using HendecamMod.Content.Buffs;
using HendecamMod.Content.DamageClasses;
using HendecamMod.Content.Projectiles;
using System.Collections.Generic;
using Terraria.Localization;
using Terraria.DataStructures;

namespace HendecamMod.Content.Items.Weapons.Multiclass;

public class RectumsRequiem : ModItem
{
    public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(DildoWhipBuff.TagDamage);

    public override void SetDefaults()
    {
        // This method quickly sets the whip's properties.
        // Mouse over to see its parameters.
        Item.DefaultToWhip(ProjectileType<BeadsNDick>(), 20, 2, 7);
        Item.rare = ItemRarityID.Pink;
        Item.damage = 45;
        Item.useTime = 23;
        Item.useAnimation = 23;
        Item.knockBack = 7;
        Item.width = 14;
        Item.height = 14;
        Item.value = Item.buyPrice(silver: 2500);
        Item.DamageType = GetInstance<SummonStupidDamage>();
    }
    public float LobotometerCost = 7f;
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
        var line = new TooltipLine(Mod, "Face", "10 summon tag damage");
        tooltips.Add(line);
        line = new TooltipLine(Mod, "Face", "Uses 7 Braincells")
        {
            Color = new Color(255, 255, 255)
        };
        tooltips.Add(line);
        line = new TooltipLine(Mod, "Face", "Extra good at penetration ;)")
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

    // Makes the whip receive melee prefixes
    public override bool MeleePrefix()
    {
        return true;
    }
}