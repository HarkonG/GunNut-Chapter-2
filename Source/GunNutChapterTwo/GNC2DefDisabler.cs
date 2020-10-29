using RimWorld;
using System.Collections.Generic;
using Verse;

namespace GunNutChapterTwo
{
	[StaticConstructorOnStartup]
	public static class GNC2DefDisabler
	{
		static GNC2DefDisabler() => GNC2DefDisabler.DefDisablerList();

		public static void DefDisablerList()
		{
			bool value1 = !GNC2Mod.settings.enable_GN2_ASh12;
			if (value1)
			{
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_AShTwelve"));
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_Bullet_AShTwelve"));
			}

			bool value2 = !GNC2Mod.settings.enable_GN2_ASVAL;
			if (value2)
			{
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_ASVAL"));
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_Bullet_ASVAL"));
			}

			bool value3 = !GNC2Mod.settings.enable_GN2_GM6;
			if (value3)
			{
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_GMSix"));
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_Bullet_GMSix"));
			}

			bool value10 = !GNC2Mod.settings.enable_GN2_G36;
			if (value10)
			{
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_GThirtySix"));
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_Bullet_GThirtySix"));
			}

			bool value4 = !GNC2Mod.settings.enable_GN2_HKGL;
			if (value4)
			{
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_HKGL"));
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_Bullet_HKGL"));
			}

			bool value6 = !GNC2Mod.settings.enable_GN2_SSMG;
			if (value6)
			{
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_SSMG"));
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_Bullet_SSMG"));
			}

			bool value5 = !GNC2Mod.settings.enable_GN2_M3E1;
			if (value5)
			{
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_MThreeEOne"));
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_Bullet_MThreeEOne"));
			}		

			bool value7 = !GNC2Mod.settings.enable_GN2_SKS;
			if (value7)
			{
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_SKS"));
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_Bullet_SKS"));
			}

			bool value8 = !GNC2Mod.settings.enable_GN2_NG5;
			if (value8)
			{
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_NGFive"));
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_Bullet_NGFive"));
			}		

			bool value11 = !GNC2Mod.settings.enable_GN2_Neopup;
			if (value11)
			{
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_Neopup"));
				GNC2DefDisabler.DisableDef(ThingDef.Named("GN_Bullet_Neopup"));
			}
		}

		public static void DisableDef(ThingDef def)
		{
			List<ResearchProjectDef> researchPrerequisites = def.researchPrerequisites;

			if (researchPrerequisites != null)
			{
				researchPrerequisites.Clear();
			}

			List<string> weaponTags = def.weaponTags;

			if (weaponTags != null)
			{
				weaponTags.Clear();
			}

			def.deepCommonality = 0f;

			def.generateCommonality = 0f;

			def.tradeability = Tradeability.None;

			List<ThingCategoryDef> thingCategories = def.thingCategories;

			if (thingCategories != null)
			{
				thingCategories.Clear();
			}

			List<ThingCategoryDef> thingCategories2 = def.thingCategories;

			if (thingCategories2 != null)
			{
				thingCategories2.Add(ThingCategoryDefOf.Chunks);
			}

			foreach (RecipeDef recipeDef in DefDatabase<RecipeDef>.AllDefsListForReading)
			{
				bool value1 = recipeDef.ProducedThingDef == def;
				if (value1)
				{
					List<ThingDef> recipeUsers = recipeDef.recipeUsers;
					if (recipeUsers != null)
					{
						recipeUsers.Clear();
					}
					List<ResearchProjectDef> researchPrerequisites2 = recipeDef.researchPrerequisites;
					if (researchPrerequisites2 != null)
					{
						researchPrerequisites2.Clear();
					}
					recipeDef.researchPrerequisite = null;
				}
			}

			bool value2 = DefDatabase<ThingDef>.AllDefsListForReading.Contains(def);

			if (value2)
			{
				DefDatabase<ThingDef>.AllDefsListForReading.Remove(def);
			}
		}
	}
}