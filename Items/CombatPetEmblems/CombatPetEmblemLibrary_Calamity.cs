using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using AmuletOfManyMinions.Projectiles.Minions.CombatPets.CombatPetEmblems;

namespace AOMMExtended.Items.CombatPetEmblems.Calamity
{
	public abstract class CalamityModCombatPetEmblem : ModItem
	{
		public override void SetDefaults()
		{
			Item.noMelee = true;
			Item.DamageType = DamageClass.Summon;
			Item.shoot = ProjectileID.None;
			Item.knockBack = 1f;
		}
		
		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			base.ModifyTooltips(tooltips);
		}
	}

	class SeaPrismCombatPetEmblem : CalamityModCombatPetEmblem
	{
		//public override int PetLevel => 1;
		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.damage = 11;
			Item.value = Item.sellPrice(silver: 110);
			Item.rare = ItemRarityID.Green;
		}
		public override void AddRecipes()
		{
			if (ModLoader.HasMod("CalamityMod"))
			{
				Mod calamity = ModLoader.GetMod("CalamityMod");
				if (calamity != null)
				{
					CreateRecipe()
						.AddIngredient(calamity.Find<ModItem>("SeaPrism").Type, 12)
						.AddTile(TileID.Anvils)
						.Register();
				}
			}
		}
	}

	class AerialiteCombatPetEmblem : CalamityModCombatPetEmblem
	{
		//public override int PetLevel => 2;
		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.damage = 17;
			Item.value = Item.sellPrice(silver: 330);
			Item.rare = ItemRarityID.Orange;
		}
		public override void AddRecipes()
		{
			if (ModLoader.HasMod("CalamityMod"))
			{
				Mod calamity = ModLoader.GetMod("CalamityMod");
				if (calamity != null)
				{
					CreateRecipe()
						.AddIngredient(calamity.Find<ModItem>("AerialiteBar").Type, 12)
						.AddTile(TileID.Anvils)
						.Register();
				}
			}
		}
	}

	class CryonicCombatPetEmblem : CalamityModCombatPetEmblem
	{
		//public override int PetLevel => 4;
		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.damage = 24;
			Item.value = Item.sellPrice(silver: 660);
			Item.rare = ItemRarityID.Pink;
		}
		public override void AddRecipes()
		{
			if (ModLoader.HasMod("CalamityMod"))
			{
				Mod calamity = ModLoader.GetMod("CalamityMod");
				if (calamity != null)
				{
					CreateRecipe()
						.AddIngredient(calamity.Find<ModItem>("CryonicBar").Type, 12)
						.AddTile(TileID.MythrilAnvil)
						.Register();
				}
			}
		}
	}

	class AstralCombatPetEmblem : CalamityModCombatPetEmblem
	{
		//public override int PetLevel => 8;
		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.damage = 100;
			Item.value = Item.sellPrice(silver: 1320);
			Item.rare = ItemRarityID.Cyan;
		}
		public override void AddRecipes()
		{
			if (ModLoader.HasMod("CalamityMod") && ModLoader.HasMod("AmuletOfManyMinions"))
			{
				Mod calamity = ModLoader.GetMod("CalamityMod");
				Mod aomm = ModLoader.GetMod("AmuletOfManyMinions");
				if (calamity != null && aomm != null)
				{
					CreateRecipe()
						.AddIngredient(calamity.Find<ModItem>("AstralBar").Type, 12)
						.AddIngredient(aomm.Find<ModItem>("CelestialCombatPetEmblem").Type, 1)
						.AddTile(TileID.LunarCraftingStation)
						.Register();
				}
			}
		}
	}

	class ExodiumCombatPetEmblem : CalamityModCombatPetEmblem
	{
		//public override int PetLevel => 8;
		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.damage = 120;
			Item.value = Item.sellPrice(silver: 1760);
			Item.rare = ItemRarityID.Red;
		}
		public override void AddRecipes()
		{
			if (ModLoader.HasMod("CalamityMod"))
			{
				Mod calamity = ModLoader.GetMod("CalamityMod");
				if (calamity != null)
				{
					CreateRecipe()
						.AddIngredient(calamity.Find<ModItem>("ExodiumCluster").Type, 12)
						.AddIngredient(ModContent.ItemType<AstralCombatPetEmblem>())
						.AddTile(TileID.LunarCraftingStation)
						.Register();
				}
			}
		}
	}

	class UelibloomCombatPetEmblem : CalamityModCombatPetEmblem
	{
		//public override int PetLevel => 8;
		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.damage = 140;
			Item.value = Item.sellPrice(silver: 5500);
			Item.rare = ItemRarityID.White;
		}
		public override void AddRecipes()
		{
			if (ModLoader.HasMod("CalamityMod"))
			{
				Mod calamity = ModLoader.GetMod("CalamityMod");
				if (calamity != null)
				{
					CreateRecipe()
						.AddIngredient(calamity.Find<ModItem>("UelibloomBar").Type, 12)
						.AddIngredient(ModContent.ItemType<ExodiumCombatPetEmblem>())
						.AddTile(TileID.LunarCraftingStation)
						.Register();
				}
			}
		}
	}

	class AuricCombatPetEmblem : CalamityModCombatPetEmblem
	{
		//public override int PetLevel => 8;
		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.damage = 160;
			Item.value = Item.sellPrice(silver: 6600);
			Item.rare = ItemRarityID.White;
		}
		public override void AddRecipes()
		{
			if (ModLoader.HasMod("CalamityMod"))
			{
				Mod calamity = ModLoader.GetMod("CalamityMod");
				if (calamity != null)
				{
					CreateRecipe()
						.AddIngredient(calamity.Find<ModItem>("AuricBar").Type, 12)
						.AddIngredient(ModContent.ItemType<UelibloomCombatPetEmblem>())
						.AddTile(calamity.Find<ModTile>("CosmicAnvil").Type)
						.Register();
				}
			}
		}
	}
}