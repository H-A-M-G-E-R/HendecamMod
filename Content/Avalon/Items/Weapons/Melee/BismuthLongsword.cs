using System.Collections.Generic;

namespace HendecamMod.Content.Avalon.Items.Weapons.Melee;

public class BismuthLongsword : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 36;
        Item.height = 36;

        Item.useStyle = ItemUseStyleID.Swing;
        Item.useTime = 25;
        Item.useAnimation = 25;
        Item.autoReuse = true;

        Item.DamageType = DamageClass.Melee;
        Item.damage = 18;
        Item.knockBack = 6;
        Item.ArmorPenetration = 5;
        Item.ChangePlayerDirectionOnShoot = true;
        Item.scale = 1.38f;

        Item.value = Item.buyPrice(gold: 1);
        Item.rare = ItemRarityID.White;
        Item.UseSound = SoundID.Item1;
        Item.useTurn = true;

        // If you want melee speed to only affect the swing speed of the weapon and not the shoot speed (not recommended)
        // Item.attackSpeedOnlyAffectsWeaponAnimation = true;

        // Normally shooting a projectile makes the player face the projectile, but if you don't want that (like the beam sword) use this line of code
        // Item.ChangePlayerDirectionOnShoot = false;
    }

    public override Color? GetAlpha(Color lightColor)
    {
        return Color.White;
    }

    public override void ModifyTooltips(List<TooltipLine> tooltips)
    {
        // Here we add a tooltipline that will later be removed, showcasing how to remove tooltips from an item
        var line = new TooltipLine(Mod, "Face", "It does 5 armor penetration");
        tooltips.Add(line);
        if (!ModLoader.TryGetMod("Avalon", out Mod Avalon))
        {
            line = new TooltipLine(Mod, "Face", "Avalon Compatibility Item")
            {
                OverrideColor = new Color(255, 255, 255)
            };
            tooltips.Add(line);
        }
    }

    public override void AddRecipes()
    {
        if (ModLoader.TryGetMod("Avalon", out Mod Avalon) && Avalon.TryFind("BismuthBar", out ModItem BismuthBar) && Avalon.TryFind("BismuthBroadsword", out ModItem BismuthBroadsword))
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(BismuthBar.Type, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
            recipe = CreateRecipe();
            recipe.AddIngredient(BismuthBroadsword.Type);
            recipe.AddIngredient(BismuthBar.Type, 4);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}