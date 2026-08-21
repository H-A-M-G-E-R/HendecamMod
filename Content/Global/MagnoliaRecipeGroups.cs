using Terraria.Localization;

namespace HendecamMod.Content.Global;

public class MagnoliaRecipeGroups : ModSystem
{
    public override void AddRecipeGroups()

    {
        RecipeGroup group = RecipeGroup.Register(
            nameof(ItemID.DemoniteBar),
            "ItemName.DemoniteBar",
            ItemID.DemoniteBar, ItemID.CrimtaneBar
        );
    }
}