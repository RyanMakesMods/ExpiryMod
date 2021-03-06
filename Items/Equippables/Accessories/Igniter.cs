using Terraria;
using Terraria.ModLoader;
using ExpiryMode.Global_;
using ExpiryMode.Mod_;
using Terraria.ID;
using ExpiryMode.Items.Weapons.ExpiryExclusive;
using ExpiryMode.Items.Weapons.Guns;

namespace ExpiryMode.Items.Equippables.Accessories
{
    public class Igniter : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Igniter");
			Tooltip.SetDefault("Makes you fire blunderbusses faster\nHide visual to stop all recoil\n'I am SPEED!'");
		}
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.value = 61283;
            item.accessory = true;
            item.rare = ExpiryRarity.Expiry;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<InfiniteSuffPlayer>().igniter = true;
            if (hideVisual)
            {
                player.GetModPlayer<InfiniteSuffPlayer>().igniterNoVisual = true;
            }
            if (item.type == ModContent.ItemType<SlimyBlunderbuss>() || item.type == ModContent.ItemType<Blunderbuss>())
            {
                // Use later?????
            }
        }
    }
}