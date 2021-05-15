using Terraria.ID;
using Terraria.ModLoader;

namespace RiseOfAdventure.Items.Weapons
{
	public class Kings_Katana : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("King's Katana");
			Tooltip.SetDefault("An old katana that was made to protect kings...");
		}

		public override void SetDefaults() 
		{
			item.damage = 14;
			item.melee = true;
			item.width = 40;
			item.height = 70;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 1000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}