using UnityEngine;
using Verse;

namespace GunNutChapterTwo
{
	internal class GNC2Settings : ModSettings
	{
		/// <summary>
		/// The settings our mod has.
		/// </summary>
		public bool enable_GN2_ASh12 = true;
		public bool enable_GN2_ASVAL = true;
		public bool enable_GN2_GM6 = true;
		public bool enable_GN2_G36 = true;
		public bool enable_GN2_HKGL = true;
		public bool enable_GN2_SSMG = true;
		public bool enable_GN2_M3E1 = true;
		public bool enable_GN2_SKS = true;
		public bool enable_GN2_NG5 = true;
		public bool enable_GN2_Neopup = true;		

		public bool enable_GN2_nicknames = true;

		public void ResetSavedDefs()
		{
			this.enable_GN2_ASh12 = true;
			this.enable_GN2_ASVAL = true;
			this.enable_GN2_GM6 = true;
			this.enable_GN2_G36 = true;
			this.enable_GN2_HKGL = true;
			this.enable_GN2_SSMG = true;
			this.enable_GN2_M3E1 = true;		
			this.enable_GN2_SKS = true;
			this.enable_GN2_NG5 = true;
			this.enable_GN2_Neopup = true;

			this.enable_GN2_nicknames = true;
		}

		/// <summary>
		/// The part that writes our settings to file. Note that saving is by ref.
		/// </summary>
		public override void ExposeData()
		{
			base.ExposeData();
			Scribe_Values.Look<bool>(ref this.enable_GN2_ASh12, "enable_GN2_ASh12", true, false);
			Scribe_Values.Look<bool>(ref this.enable_GN2_ASVAL, "enable_GN2_ASVAL", true, false);
			Scribe_Values.Look<bool>(ref this.enable_GN2_GM6, "enable_GN2_GM6", true, false);
			Scribe_Values.Look<bool>(ref this.enable_GN2_G36, "enable_GN2_G36", true, false);
			Scribe_Values.Look<bool>(ref this.enable_GN2_HKGL, "enable_GN2_HKGL", true, false);
			Scribe_Values.Look<bool>(ref this.enable_GN2_SSMG, "enable_GN2_SSMG", true, false);
			Scribe_Values.Look<bool>(ref this.enable_GN2_M3E1, "enable_GN2_M3E1", true, false);			
			Scribe_Values.Look<bool>(ref this.enable_GN2_SKS, "enable_GN2_SKS", true, false);
			Scribe_Values.Look<bool>(ref this.enable_GN2_NG5, "enable_GN2_NG5", true, false);			
			Scribe_Values.Look<bool>(ref this.enable_GN2_Neopup, "enable_GN2_Neopup", true, false);

			Scribe_Values.Look<bool>(ref this.enable_GN2_nicknames, "enable_GN2_nicknames", true, false);
		}

		public void DoSettingsWindowContents(Rect settingsCanvas)
		{
			Listing_Standard list = new Listing_Standard
			{
				ColumnWidth = (settingsCanvas.width - 17) / 2
			};

			list.Begin(settingsCanvas);

			Text.Font = GameFont.Medium;
			list.Label("settings_GN2_EnableHeader".Translate());
			list.GapLine();

			Text.Font = GameFont.Small;
			list.Label("settings_GN2_EnableDescription".Translate());
			list.Gap();

			list.CheckboxLabeled("enable_GN2_ASh12".Translate(), ref this.enable_GN2_ASh12, null);
			list.CheckboxLabeled("enable_GN2_ASVAL".Translate(), ref this.enable_GN2_ASVAL, null);
			list.CheckboxLabeled("enable_GN2_GM6".Translate(), ref this.enable_GN2_GM6, null);
			list.CheckboxLabeled("enable_GN2_G36".Translate(), ref this.enable_GN2_G36, null);
			list.CheckboxLabeled("enable_GN2_HKGL".Translate(), ref this.enable_GN2_HKGL, null);
			list.CheckboxLabeled("enable_GN2_SSMG".Translate(), ref this.enable_GN2_SSMG, null);
			list.CheckboxLabeled("enable_GN2_M3E1".Translate(), ref this.enable_GN2_M3E1, null);			
			list.CheckboxLabeled("enable_GN2_SKS".Translate(), ref this.enable_GN2_SKS, null);
			list.CheckboxLabeled("enable_GN2_NG5".Translate(), ref this.enable_GN2_NG5, null);			
			list.CheckboxLabeled("enable_GN2_Neopup".Translate(), ref this.enable_GN2_Neopup, null);			
			list.Gap();
			list.Gap();
			list.Gap();
			list.Gap();
			list.Gap();

			list.Label("settings_GN2_EndDescription".Translate());

			list.NewColumn();

			Text.Font = GameFont.Medium;
			list.Label("settings_GN2_EnableNickNameHeader".Translate());
			list.GapLine();

			Text.Font = GameFont.Small;
			list.Label("settings_GN2_EnableNickNameDescription".Translate());
			list.Gap();

			list.CheckboxLabeled("enable_GN2_nicknames".Translate(), ref this.enable_GN2_nicknames, null);

			list.End();
		}
	}
}