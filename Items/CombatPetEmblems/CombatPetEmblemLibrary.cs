using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using AmuletOfManyMinions.Projectiles.Minions.CombatPets.CombatPetEmblems;

namespace AOMMExtended.Items.CombatPetEmblems
{
	public abstract class ExtendedCombatPetEmblem : ModItem
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
	// Removed the Tier 0 Emblems, they are weaker or the same a Base level (No Emblem)
	
	//class CopperCombatPetEmblem : ExtendedCombatPetEmblem
	//{
	//	public override void SetDefaults()
	//	{
	//		base.SetDefaults();
	//		Item.value = Item.sellPrice(silver: 16);
	//		Item.damage = 4;
	//	}
	//	public override void AddRecipes() =>
	//		CreateRecipe().AddIngredient(ItemID.CopperBar, 12).AddTile(TileID.Anvils).Register();
	//}

	//class TinCombatPetEmblem : ExtendedCombatPetEmblem
	//{
	//	public override void SetDefaults()
	//	{
	//		base.SetDefaults();
	//		Item.value = Item.sellPrice(silver: 36);
	//		Item.damage = 4;
	//	}
	//	public override void AddRecipes() =>
	//		CreateRecipe().AddIngredient(ItemID.TinBar, 12).AddTile(TileID.Anvils).Register();
	//}

	//class IronCombatPetEmblem : ExtendedCombatPetEmblem
	//{
	//	public override void SetDefaults()
	//	{
	//		base.SetDefaults();
	//		Item.value = Item.sellPrice(silver: 35);
	//		Item.damage = 7;
	//	}
	//	public override void AddRecipes() =>
	//		CreateRecipe().AddIngredient(ItemID.IronBar, 12).AddTile(TileID.Anvils).Register();
	//}

	//class LeadCombatPetEmblem : ExtendedCombatPetEmblem
	//{
	//	public override void SetDefaults()
	//	{
	//		base.SetDefaults();
	//		Item.value = Item.sellPrice(silver: 40);
	//		Item.damage = 7;
	//	}
	//	public override void AddRecipes() =>
	//		CreateRecipe().AddIngredient(ItemID.LeadBar, 12).AddTile(TileID.Anvils).Register();
	//}

	class SilverCombatPetEmblem : ExtendedCombatPetEmblem
	{
		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.value = Item.sellPrice(silver: 50);
			Item.damage = 9;
		}
		public override void AddRecipes() =>
			CreateRecipe().AddIngredient(ItemID.SilverBar, 12).AddTile(TileID.Anvils).Register();
	}

	class TungstenCombatPetEmblem : ExtendedCombatPetEmblem
	{
		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.value = Item.sellPrice(silver: 50);
			Item.damage = 9;
		}
		public override void AddRecipes() =>
			CreateRecipe().AddIngredient(ItemID.TungstenBar, 12).AddTile(TileID.Anvils).Register();
	}

	class FossilCombatPetEmblem : ExtendedCombatPetEmblem
	{
		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.value = Item.sellPrice(silver: 50);
			Item.damage = 13;
		}
		public override void AddRecipes() =>
			CreateRecipe().AddIngredient(3380, 12).AddTile(TileID.Anvils).Register();
	}

	class ObsidianCombatPetEmblem : ExtendedCombatPetEmblem
	{
		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.value = Item.sellPrice(silver: 50);
			Item.damage = 13;
			Item.rare = ItemRarityID.LightRed;
		}
		public override void AddRecipes() =>
			CreateRecipe().AddIngredient(ItemID.Obsidian, 12).AddTile(TileID.Anvils).Register();
	}

	class BeeCombatPetEmblem : ExtendedCombatPetEmblem
	{
		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.value = Item.sellPrice(silver: 50);
			Item.damage = 17;
			Item.rare = ItemRarityID.Blue;
		}
	}

	class HellstoneCombatPetEmblem : ExtendedCombatPetEmblem
	{
		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.value = Item.sellPrice(silver: 50);
			Item.damage = 20;
			Item.rare = ItemRarityID.Orange;
		}
		public override void AddRecipes() =>
			CreateRecipe().AddIngredient(ItemID.HellstoneBar, 12).AddTile(TileID.Anvils).Register();
	}

	class SpiderCombatPetEmblem : ExtendedCombatPetEmblem
	{
		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.value = Item.sellPrice(silver: 50);
			Item.damage = 25;
			Item.rare = ItemRarityID.LightRed;
		}
		public override void AddRecipes() =>
			CreateRecipe().AddIngredient(ItemID.SpiderFang, 24).AddTile(TileID.MythrilAnvil).Register();
	}

	class BloodMoonCombatPetEmblem : ExtendedCombatPetEmblem
	{
		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.value = Item.sellPrice(silver: 50);
			Item.damage = 32;
			Item.rare = ItemRarityID.Blue;
		}
	}
}
