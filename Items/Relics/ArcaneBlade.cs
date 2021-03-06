using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ApacchiisClassesMod2.Items.Relics
{
	public class ArcaneBlade : ModItem
	{
        public string desc = "Hitting enemies with melee weapons restores 8% of the damage dealt as mana (max 20) [0.5s Cooldown]\n" +
                             "Increases max mana by 5%\n" +
                             "Increases melee damage by 2%";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault($"[{Language.GetTextValue("Mods.ApacchiisClassesMod2.RelicPrefix")}] Arcane Blade");
            Tooltip.SetDefault(desc);
            Terraria.GameContent.Creative.CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 30;
            Item.accessory = true;
			Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.rare = ItemRarityID.Quest;

            Item.GetGlobalItem<ACMGlobalItem>().isRelic = true;
            Item.GetGlobalItem<ACMGlobalItem>().desc = desc;
        }

        public override void UpdateVanity(Player player)
        {
            var acmPlayer = player.GetModPlayer<ACMPlayer>();
            acmPlayer.hasRelic = true;
            acmPlayer.hasArcaneBlade = true;
            acmPlayer.manaMult += .05f;
            player.GetDamage(DamageClass.Melee) += .02f;

            base.UpdateVanity(player);
        }
        public override bool CanEquipAccessory(Player player, int slot, bool modded)
        {
            if (player.GetModPlayer<ACMPlayer>().hasRelic == true)
                return false;

            if (!modded)
                return false;

            return base.CanEquipAccessory(player, slot, modded);
        }
    }
}

