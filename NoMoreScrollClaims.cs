using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using System.Linq;

namespace Eco.Mods.TechTree
{
    public partial class AdvancedBakingSkillScroll : SkillScroll<AdvancedBakingSkill, AdvancedBakingSkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class AdvancedCookingSkillScroll : SkillScroll<AdvancedCookingSkill, AdvancedCookingSkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class AdvancedMasonrySkillScroll : SkillScroll<AdvancedMasonrySkill, AdvancedMasonrySkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class AdvancedSmeltingSkillScroll : SkillScroll<AdvancedSmeltingSkill, AdvancedSmeltingSkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class ButcherySkillScroll : SkillScroll<ButcherySkill, ButcherySkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class BasicEngineeringSkillScroll : SkillScroll<BasicEngineeringSkill, BasicEngineeringSkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class BakingSkillScroll : SkillScroll<BakingSkill, BakingSkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class CarpentrySkillScroll : SkillScroll<CarpentrySkill, CarpentrySkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class CompositesSkillScroll : SkillScroll<CompositesSkill, CompositesSkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class CookingSkillScroll : SkillScroll<CookingSkill, CookingSkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class CuttingEdgeCookingSkillScroll : SkillScroll<CuttingEdgeCookingSkill, CuttingEdgeCookingSkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class ElectronicsSkillScroll : SkillScroll<ElectronicsSkill, ElectronicsSkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class FertilizersSkillScroll : SkillScroll<FertilizersSkill, FertilizersSkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class FarmingSkillScroll : SkillScroll<FarmingSkill, FarmingSkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class GlassworkingSkillScroll : SkillScroll<GlassworkingSkill, GlassworkingSkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class IndustrySkillScroll : SkillScroll<IndustrySkill, IndustrySkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class MasonrySkillScroll : SkillScroll<MasonrySkill, MasonrySkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class MechanicsSkillScroll : SkillScroll<MechanicsSkill, MechanicsSkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class MillingSkillScroll : SkillScroll<MillingSkill, MillingSkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class OilDrillingSkillScroll : SkillScroll<OilDrillingSkill, OilDrillingSkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class PaperMillingSkillScroll : SkillScroll<PaperMillingSkill, PaperMillingSkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class PotterySkillScroll : SkillScroll<PotterySkill, PotterySkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class SmeltingSkillScroll : SkillScroll<SmeltingSkill, SmeltingSkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }

    public partial class TailoringSkillScroll : SkillScroll<TailoringSkill, TailoringSkillBook>
    {
        public override string OnUsed(Player player, ItemStack itemStack)
        {
            if (player.User.Skillset.HasSkill(this.SkillType))
            {
                player.ErrorLoc($"You already know {this.Skill}.");
            }
            else
            {
                using (var changes = InventoryChangeSet.New(new Inventory[] { player.User.Inventory, itemStack.Parent }.Distinct(), player.User))
                {
                    changes.ModifyStack(itemStack, -1);
                    var res = changes.TryApply();
                    if (res.Success)
                        player.User.Skillset.LearnSkillAndNotify(this.Skill);
                    else
                    {
                        player.ErrorLoc($"Could not learn {this.Skill}: {res.Message}");
                    }
                }
            }
            return string.Empty;
        }
    }
}
