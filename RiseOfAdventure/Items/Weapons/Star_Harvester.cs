using Microsoft.Xna.Framework;
using RiseOfAdventure.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RiseOfAdventure.Items.Weapons
{
	public class Star_Harvester : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star Harvester");
			Tooltip.SetDefault("Makes magic missiles fall from the sky.");
		}

		public override void SetDefaults()
		{
			item.damage = 15;
			item.melee = true;
			item.width = 40;
			item.height = 70;
			item.useTime = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 20;
			item.knockBack = 6;
			item.value = 1000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<Star_Projectile>();
			item.shootSpeed = 8f;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
			float ceilingLimit = target.Y;
			if (ceilingLimit > player.Center.Y - 200f)
			{
				ceilingLimit = player.Center.Y - 200f;
			}
			for (int i = 0; i < 3; i++)
				position = player.Center + new Vector2((-(float)Main.rand.Next(0, 1) * player.direction), -600f);
			position.Y -= (100);
			Vector2 heading = target - position;
			if (heading.Y < 0f)
			{
				heading.Y *= -1f;
			}
			if (heading.Y < 20f)
			{
				heading.Y = 20f;
			}
			heading.Normalize();
			{
				heading *= new Vector2(speedX, speedY).Length();
				speedX = heading.X;
				speedY = heading.Y + Main.rand.Next(-40, 41) * 0.02f;
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage * 2, knockBack, player.whoAmI, 0f, ceilingLimit);
			}
			return false;
		}
	}
}