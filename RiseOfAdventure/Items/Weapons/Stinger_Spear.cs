using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RiseOfAdventure.Items.Weapons
{
	public class Stinger_Spear : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stinger Spear");
			Tooltip.SetDefault("");
		}
		
		public override void SetDefaults()
		{
			item.damage = 40;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAnimation = 18;
			item.useTime = 24;
			item.shootSpeed = 3.7f;
			item.knockBack = 6.5f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = ItemRarityID.Pink;
			item.value = Item.sellPrice(silver: 10);

			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.autoReuse = true;

			item.UseSound = SoundID.Item1;
			item.shoot = ModContent.ProjectileType<Projectiles.Stinger_SpearProjectile>();
		}

		public override bool CanUseItem(Player player)
		{

			return player.ownedProjectileCounts[item.shoot] < 1;
		}
	}
}