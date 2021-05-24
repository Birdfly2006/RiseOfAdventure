using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.ComponentModel;

namespace RiseOfAdventure.Projectiles
{
	public class Star_Projectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star Projectile");
		}

		public override void SetDefaults()
		{
			projectile.width = 8;
			projectile.height = 8;
			projectile.aiStyle = 28;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.light = 1f;
			projectile.rotation += 0.7f * (float)projectile.direction;

			if (Main.rand.Next(5) == 0) // only spawn 20% of the time
			{
				int choice = Main.rand.Next(1); // choose a random number: 0, 1, or 2
				if (choice == 15) // use that number to select dustID: 15, 57, or 58
				{
					choice = 15;
				}
				else if (choice == 1)
				{
					choice = 57;
				}
				else
				{
					choice = 58;
				}
				// Spawn the dust
				Dust.NewDust(projectile.position, projectile.width, projectile.height, choice, projectile.velocity.X * 0.25f, projectile.velocity.Y * 0.25f, 150, default, 0.7f);
			}
		}
	}
}