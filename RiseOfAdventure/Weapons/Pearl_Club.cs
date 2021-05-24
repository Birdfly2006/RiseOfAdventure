using Mono.Cecil;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RiseOfAdventure.Items.Weapons
{
    public class Pearl_Club : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pearl Club");
            Tooltip.SetDefault("Has great knockback.");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.melee = true;
            item.width = 40;
            item.height = 70;
            item.useTime = 40;
            item.knockBack = 24;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.autoReuse = false;
            item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Giant_Pearl>(), 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}