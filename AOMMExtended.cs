using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;

namespace AOMMExtended
{
	public class AOMMExtended : Mod
	{
		public override void PostSetupContent()
		{
			if (ModLoader.TryGetMod("AmuletOfManyMinions", out Mod aomm))
			{
				Logger.Info("[AOMMExtended] AoMM found — using calls to register new Emblems."); // Currently just testing this capability so using names that fit into existing tiers.
				
				// Decided to take these out, they are weaker then base level.
				// aomm.Call("RegisterCombatPetEmblem", "1.0", ModContent.ItemType<Items.CombatPetEmblems.CopperCombatPetEmblem>(), 0);
				// aomm.Call("RegisterCombatPetEmblem", "1.0", ModContent.ItemType<Items.CombatPetEmblems.TinCombatPetEmblem>(), 0);
				// aomm.Call("RegisterCombatPetEmblem", "1.0", ModContent.ItemType<Items.CombatPetEmblems.IronCombatPetEmblem>(), 0);
				// aomm.Call("RegisterCombatPetEmblem", "1.0", ModContent.ItemType<Items.CombatPetEmblems.LeadCombatPetEmblem>(), 0);
				
				aomm.Call("RegisterCombatPetEmblem", "1.0", ModContent.ItemType<Items.CombatPetEmblems.SilverCombatPetEmblem>(), 1);
				aomm.Call("RegisterCombatPetEmblem", "1.0", ModContent.ItemType<Items.CombatPetEmblems.TungstenCombatPetEmblem>(), 1);
				
				aomm.Call("RegisterCombatPetEmblem", "1.0", ModContent.ItemType<Items.CombatPetEmblems.FossilCombatPetEmblem>(), 2);
				aomm.Call("RegisterCombatPetEmblem", "1.0", ModContent.ItemType<Items.CombatPetEmblems.ObsidianCombatPetEmblem>(), 2);
				
				aomm.Call("RegisterCombatPetEmblem", "1.0", ModContent.ItemType<Items.CombatPetEmblems.BeeCombatPetEmblem>(), 3);
				aomm.Call("RegisterCombatPetEmblem", "1.0", ModContent.ItemType<Items.CombatPetEmblems.HellstoneCombatPetEmblem>(), 3);
				
				aomm.Call("RegisterCombatPetEmblem", "1.0", ModContent.ItemType<Items.CombatPetEmblems.SpiderCombatPetEmblem>(), 4);
				aomm.Call("RegisterCombatPetEmblem", "1.0", ModContent.ItemType<Items.CombatPetEmblems.BloodMoonCombatPetEmblem>(), 4);
				
				Terraria.Main.NewText("AOMM Extended: Combat Pet Emblems registered.", 50, 255, 130);

				if (ModLoader.HasMod("ThoriumMod"))
				{
					Logger.Info("[AOMMExtended] Thorium found — using calls to register Thorium emblems.");
					Terraria.Main.NewText("AOMM Extended: Thorium emblems registered.", 130, 255, 200);
				}

				if (ModLoader.HasMod("CalamityMod"))
				{
					Logger.Info("[AOMMExtended] Calamity found — using calls to register Calamity emblems.");
					Terraria.Main.NewText("AOMM Extended: Calamity emblems registered.", 130, 200, 255);
				}

				Logger.Info("[AOMMExtended] Emblem setup complete.");
			}
			else
			{
				Logger.Warn("[AOMMExtended] AmuletOfManyMinions not found — skipping emblem setup.");
				Terraria.Main.NewText("⚠ AoMM not loaded! Emblems will not function.", 255, 60, 60);
			}
		}
	}
}
