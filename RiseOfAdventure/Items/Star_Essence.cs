using Terraria.ID;
using Terraria.ModLoader;
using RiseOfAdventure.Items;

namespace RiseOfAdventure.Items
{
	class Star_Essence : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star Essence");
			Tooltip.SetDefault("The essence of shiny stars in the night.");
			ItemID.Sets.ItemIconPulse[item.type] = true;
			ItemID.Sets.ItemNoGravity[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 20;
			item.maxStack = 999;
			item.rare = ItemRarityID.Blue;
		}
	}
}