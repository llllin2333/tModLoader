﻿namespace Terraria.ModLoader.Default.Patreon
{
	class dinidini_Head : PatreonItem
	{
		public override string PatreonName => "dinidini";
		public override PatreonItemType PatreonEquipType => PatreonItemType.Head;

		public override void SetDefaults()
		{
			base.SetDefaults();
			item.width = 28;
			item.height = 20;
		}
	}

	class dinidini_Body : PatreonItem
	{
		public override string PatreonName => "dinidini";
		public override PatreonItemType PatreonEquipType => PatreonItemType.Body;

		public override void SetDefaults()
		{
			base.SetDefaults();
			item.width = 28;
			item.height = 24;
		}
	}

	class dinidini_Legs : PatreonItem
	{
		public override string PatreonName => "dinidini";
		public override PatreonItemType PatreonEquipType => PatreonItemType.Legs;

		public override void SetDefaults()
		{
			base.SetDefaults();
			item.width = 22;
			item.height = 18;
		}
	}

	class dinidini_Wings : PatreonItem
	{
		public override string PatreonName => "dinidini";
		public override PatreonItemType PatreonEquipType => PatreonItemType.Wings;

		public override void SetDefaults()
		{
			base.SetDefaults();
			item.vanity = false;
			item.width = 24;
			item.height = 8;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 150;
		}
	}
}
