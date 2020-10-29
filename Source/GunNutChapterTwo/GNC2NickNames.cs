using Verse;

namespace GunNutChapterTwo
{
	[StaticConstructorOnStartup]
	public static class GNC2NickNames
	{
		static GNC2NickNames() => GNC2NickNames.EnableNickNames();

		public static void ChangeLabel(ThingDef def, string newLabel) => def.label = newLabel.Translate();

		public static void EnableNickNames()
		{
			bool value1 = GNC2Mod.settings.enable_GN2_nicknames;
			if (value1)
			{
				GNC2NickNames.ChangeLabel(ThingDef.Named("GN_AShTwelve"), "Label_GN2_ASh12_NN");
				GNC2NickNames.ChangeLabel(ThingDef.Named("GN_ASVAL"), "Label_GN2_ASVAL_NN");
				GNC2NickNames.ChangeLabel(ThingDef.Named("GN_GMSix"), "Label_GN2_GM6_NN");
				GNC2NickNames.ChangeLabel(ThingDef.Named("GN_GThirtySix"), "Label_GN2_G36_NN");
				GNC2NickNames.ChangeLabel(ThingDef.Named("GN_HKGL"), "Label_GN2_HKGL_NN");
				GNC2NickNames.ChangeLabel(ThingDef.Named("GN_SSMG"), "Label_GN2_SSMG_NN");
				GNC2NickNames.ChangeLabel(ThingDef.Named("GN_MThreeEOne"), "Label_GN2_M3E1_NN");
				GNC2NickNames.ChangeLabel(ThingDef.Named("GN_SKS"), "Label_GN2_SKS_NN");
				GNC2NickNames.ChangeLabel(ThingDef.Named("GN_NGFive"), "Label_GN2_NG5_NN");
				GNC2NickNames.ChangeLabel(ThingDef.Named("GN_Neopup"), "Label_GN2_Neopup_NN");			
			}
		}
	}
}