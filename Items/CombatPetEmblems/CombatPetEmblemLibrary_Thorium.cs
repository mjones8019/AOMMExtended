using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using AmuletOfManyMinions.Projectiles.Minions.CombatPets.CombatPetEmblems;

namespace AOMMExtended.Items.CombatPetEmblems.Thorium
{
	public abstract class ThoriumModCombatPetEmblem : ModItem
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

	class ThoriumCombatPetEmblem : ThoriumModCombatPetEmblem
	{
		//public override int PetLevel => 1;
		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.damage = 10;
			Item.value = Item.sellPrice(silver: 220);
			Item.rare = ItemRarityID.Blue;
		}
		public override void AddRecipes()
		{
			if (ModLoader.HasMod("ThoriumMod"))
			{
				Mod thorium = ModLoader.GetMod("ThoriumMod");
				if (thorium != null)
				{
					CreateRecipe()
						.AddIngredient(thorium.Find<ModItem>("ThoriumBar").Type, 12)
						.AddTile(thorium.Find<ModTile>("ThoriumAnvil").Type)
						.Register();
				}
			}
		}
	}

	class AquaiteCombatPetEmblem : ThoriumModCombatPetEmblem
	{
		//public override int PetLevel => 2;
		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.damage = 14;
			Item.value = Item.sellPrice(silver: 159);
			Item.rare = ItemRarityID.Green;
		}
		public override void AddRecipes()
		{
			if (ModLoader.HasMod("ThoriumMod"))
			{
				Mod thorium = ModLoader.GetMod("ThoriumMod");
				if (thorium != null)
				{
					CreateRecipe()
						.AddIngredient(thorium.Find<ModItem>("AquaiteBar").Type, 12)
						.AddTile(TileID.Anvils)
						.Register();
				}
			}
		}
	}

	class IllumiteCombatPetEmblem : ThoriumModCombatPetEmblem
	{
		//public override int PetLevel => 6;
		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.damage = 48;
			Item.value = Item.sellPrice(silver: 440);
			Item.rare = ItemRarityID.Lime;
		}
		public override void AddRecipes()
		{
			if (ModLoader.HasMod("ThoriumMod"))
			{
				Mod thorium = ModLoader.GetMod("ThoriumMod");
				if (thorium != null)
				{
					CreateRecipe()
						.AddIngredient(thorium.Find<ModItem>("IllumiteIngot").Type, 12)
						.AddTile(thorium.Find<ModTile>("SoulForge").Type)
						.Register();
				}
			}
		}
	}
}
