using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace RiseOfAventure.Projectiles
{
    public class Stinger_SpearProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spear");
        }
        public override void SetDefaults()
        {
            projectile.width = 18;
            projectile.height = 18;
            projectile.aiStyle = 19;
            projectile.penetrate = -1;
            projectile.alpha = 0;
            projectile.hide = true;
            projectile.ownerHitCheck = true;
            projectile.melee = true;
            projectile.tileCollide = false;
            projectile.friendly = true;
        }


        public float movementFactor
        {
            get => projectile.ai[0];
            set => projectile.ai[0] = value;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            Vector2 ownerMountedCenter = player.RotatedRelativePoint(player.MountedCenter, true);
            projectile.direction = player.direction;
            player.heldProj = projectile.whoAmI;
            player.itemTime = player.itemAnimation;
            projectile.position.X = ownerMountedCenter.X - (float)(projectile.width / 2);
            projectile.position.Y = ownerMountedCenter.Y - (float)(projectile.height / 2);
            if (!player.frozen)
            {
                if (movementFactor == 0f)
                {
                    movementFactor = 3f;
                    projectile.netUpdate = true;
                }
                if (player.itemAnimation < player.itemAnimationMax / 3)
                {
                    movementFactor -= 2.4f;
                }
                else
                {
                    movementFactor += 2.1f;
                }
            }
            projectile.position += projectile.velocity * movementFactor;
            if (player.itemAnimation == 0)
            {
                projectile.Kill();
            }
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(135f);
            if (projectile.spriteDirection == -1)
            {
                projectile.rotation -= MathHelper.ToRadians(90f);
            }
        }
    }
}