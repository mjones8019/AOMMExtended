using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace AOMMExtended
{
    public class AOMMExtendedGlobalNPC : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            switch (npc.type)
            {
                case NPCID.QueenBee:
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.CombatPetEmblems.BeeCombatPetEmblem>(), 4));
                    break;

                case NPCID.BloodZombie:
                case NPCID.Drippler:
                    npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsHardmode(), ModContent.ItemType<Items.CombatPetEmblems.BloodMoonCombatPetEmblem>(), 50));
                    break;
            }
        }
    }
}