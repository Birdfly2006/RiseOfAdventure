using System;
using Terraria.ID;
using Terraria.ModLoader;

namespace RiseOfAdventure.Items
{
	class Giant_Pearl : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Giant Pearl");
		}

		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 20;
			item.maxStack = 99;
			item.rare = ItemRarityID.Green;
		}
	}
}