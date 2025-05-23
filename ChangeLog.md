# Changelog – AOMMExtended Mod
All notable changes to this project will be documented in this file.

## [1.0.0] – 2025-05-21
### Added
- Initial migration to AoMM's native `CombatPetEmblem` class architecture.
- Modular support for:
  - ✅ Vanilla + Extended emblems (Copper → Hellstone)
  - ✅ CalamityMod emblems (Sea Prism → Auric)
  - ✅ ThoriumMod emblems (Thorium → Illumite)
- Context-sensitive recipe registration for Calamity and Thorium emblems.
- Dynamic tooltips using AoMM's `CommonTooltip` and `MinionSlotsToCombatPet` system.
- Full `en-US.hjson` localization support with emblem display names and shared tooltip templates.

### Changed
- Refactored all emblem classes into three structured libraries:
  - `CombatPetEmblemLibrary.cs` (Vanilla)
  - `CombatPetEmblemLibrary_Calamity.cs`
  - `CombatPetEmblemLibrary_Thorium.cs`
- Updated `AOMMExtended.cs`:
  - Removed all `Mod.Call("RegisterCombatPetEmblem", ...)` calls
  - Replaced with mod presence checks for AoMM, Thorium, and Calamity
  - Logically grouped mod loading feedback with in-game messages

### Removed
- Legacy `Mod.Call` registration logic from `PostSetupContent`
- Static tooltip entries in localization file that were redundant with AoMM’s auto-tooltip system

---

## [Planned]
- Add Spanish and Portuguese localization support
- Add mod icon and Steam Workshop publishing setup
- Optional: Create compatibility patch for mod cross-emblem upgrade trees

