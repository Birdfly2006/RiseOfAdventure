using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RiseOfAdventure.NPCs
{
	public class Giant_Clam : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Giant Clam");
			Main.npcFrameCount[npc.type] = 6;
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 35;
			npc.defense = 6;
			npc.lifeMax = 230;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath4;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 25;
			aiType = NPCID.Mimic;
			animationType = NPCID.Mimic;
			banner = Item.NPCtoBanner(NPCID.Mimic);
			bannerItem = Item.BannerToItem(banner);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.Ocean.Chance * 0.4f;
		}
	}
}
