using HendecamMod.Content.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendecamMod.Common.Systems
{
    public class RecipeGroupEdits : ModSystem
    {
        public override void AddRecipeGroups()
        {
            RecipeGroup group = RecipeGroups.Wood;
            group.ValidItems.Add(ModContent.ItemType<PoorMahogany>());
            group.ValidItems.Add(ModContent.ItemType<Pykrete>());
        }
    }
}