using Terraria.ID;
using Terraria.ModLoader;

namespace RiseOfAdventure.Items
{
	class Nova_Ingot : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nova Ingot");
			Tooltip.SetDefault("This metal shines bright like the stars at night.");
		}

		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 20;
			item.maxStack = 99;
			item.rare = ItemRarityID.Green;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.AddIngredient(ItemID.Star, 1);
			recipe.AddIngredient(ModContent.ItemType<Star_Essence>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}