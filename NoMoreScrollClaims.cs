using Eco.Gameplay.Items;
using Eco.Gameplay.Players;

namespace Eco.Mods.TechTree
{
    public partial class AdvancedBakingSkillScroll : SkillScroll<AdvancedBakingSkill, AdvancedBakingSkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class AdvancedCookingSkillScroll : SkillScroll<AdvancedCookingSkill, AdvancedCookingSkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class AdvancedMasonrySkillScroll : SkillScroll<AdvancedMasonrySkill, AdvancedMasonrySkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class AdvancedSmeltingSkillScroll : SkillScroll<AdvancedSmeltingSkill, AdvancedSmeltingSkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class ButcherySkillScroll : SkillScroll<ButcherySkill, ButcherySkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class BasicEngineeringSkillScroll : SkillScroll<BasicEngineeringSkill, BasicEngineeringSkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class BakingSkillScroll : SkillScroll<BakingSkill, BakingSkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class CarpentrySkillScroll : SkillScroll<CarpentrySkill, CarpentrySkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if(itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class CompositesSkillScroll : SkillScroll<CompositesSkill, CompositesSkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class CookingSkillScroll : SkillScroll<CookingSkill, CookingSkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class CuttingEdgeCookingSkillScroll : SkillScroll<CuttingEdgeCookingSkill, CuttingEdgeCookingSkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class ElectronicsSkillScroll : SkillScroll<ElectronicsSkill, ElectronicsSkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class FertilizersSkillScroll : SkillScroll<FertilizersSkill, FertilizersSkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class FarmingSkillScroll : SkillScroll<FarmingSkill, FarmingSkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class GlassworkingSkillScroll : SkillScroll<GlassworkingSkill, GlassworkingSkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class IndustrySkillScroll : SkillScroll<IndustrySkill, IndustrySkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class MasonrySkillScroll : SkillScroll<MasonrySkill, MasonrySkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class MechanicsSkillScroll : SkillScroll<MechanicsSkill, MechanicsSkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class MillingSkillScroll : SkillScroll<MillingSkill, MillingSkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class OilDrillingSkillScroll : SkillScroll<OilDrillingSkill, OilDrillingSkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class PaperMillingSkillScroll : SkillScroll<PaperMillingSkill, PaperMillingSkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class PotterySkillScroll : SkillScroll<PotterySkill, PotterySkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class SmeltingSkillScroll : SkillScroll<SmeltingSkill, SmeltingSkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }

    public partial class TailoringSkillScroll : SkillScroll<TailoringSkill, TailoringSkillBook>
    {
        public override void OnUsed(Player player, ItemStack itemStack)
        {
            int originalStackSize = itemStack.Quantity;
            base.OnUsed(player, itemStack);
            if (itemStack.Quantity < originalStackSize)
                player.User.Inventory.TryRemoveItems<PropertyClaimItem>(5);
        }
    }
}