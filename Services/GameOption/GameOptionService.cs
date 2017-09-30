using System.Collections.Generic;
using System.Linq;
using Domain;
using Domain.Card;
using Domain.Character;
using Domain.Zombie;
using Domain.Zombie.Standard;

namespace Services.GameOption
{
    public class GameOptionService : IGameOptionService
    {
        #region Create all Characters
        private List<Domain.Character.Character> CreateAllCharacters()
        {
            var list = new List<Domain.Character.Character>();

            //ADAM
            list.Add(new Domain.Character.Character
            {
                Name = "Adam",
                Tags = new List<TagEnum>
                {
                    TagEnum.Collector,
                    TagEnum.MeleeWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_ADAM,
                BoardImage = "/Library;component/Image/Board/Adam.jpg",
                Image = "/Library;component/Image/Character/Adam.jpg",
                IdImage = "/Library;component/Image/IdImage/Adam.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Plus1MeleeDie
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1CombatDie,
                    OrangePower2 = PowerEnum.Webbing,
                    RedPower1 = PowerEnum.Plus1CombatAction,
                    RedPower2 = PowerEnum.Plus1CombatDieResult,
                    RedPower3 = PowerEnum.Hoard
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.AngryNeighbors
            });

            list.Add(new Domain.Character.Character
            {
                Name = "AdamZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.MeleeWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_ADAM,
                BoardImage = "/Library;component/Image/Board/AdamZombie.jpg",
                Image = "/Library;component/Image/Character/AdamZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/AdamZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Plus1MeleeDie
                        },
                    YellowPower = PowerEnum.Plus1MeleeAction,
                    OrangePower1 = PowerEnum.Plus1CombatDie,
                    OrangePower2 = PowerEnum.Regeneration,
                    RedPower1 = PowerEnum.Plus1CombatDieResult,
                    RedPower2 = PowerEnum.Hoard,
                    RedPower3 = PowerEnum.ZombieLink
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.AngryNeighbors
            });

            //AMY
            list.Add(new Domain.Character.Character
            {
                Name = "Amy",
                Tags = new List<TagEnum>
                {
                    TagEnum.Runner,
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_ADAM,
                BoardImage = "/Library;component/Image/Board/Amy.jpg",
                Image = "/Library;component/Image/Character/Amy.jpg",
                IdImage = "/Library;component/Image/IdImage/Amy.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Plus1MoveAction
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1CombatAction,
                    OrangePower2 = PowerEnum.Plus1MoveAction,
                    RedPower1 = PowerEnum.Plus1CombatDieResult,
                    RedPower2 = PowerEnum.Plus1CombatDie,
                    RedPower3 = PowerEnum.Medic
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.Season1
            });

            list.Add(new Domain.Character.Character
            {
                Name = "AmyZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.Runner,
                    TagEnum.Discreet,
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_AMY,
                BoardImage = "/Library;component/Image/Board/AmyZombie.jpg",
                Image = "/Library;component/Image/Character/AmyZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/AmyZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Plus1MoveAction
                    },
                    YellowPower = PowerEnum.Plus1RangedAction,
                    OrangePower1 = PowerEnum.Plus1MoveAction,
                    OrangePower2 = PowerEnum.Rotten,
                    RedPower1 = PowerEnum.Plus1CombatDieResult,
                    RedPower2 = PowerEnum.Medic,
                    RedPower3 = PowerEnum.LowProfile
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.Season1
            });

            //BEAR
            list.Add(new Domain.Character.Character
            {
                Name = "Bear",
                Tags = new List<TagEnum>
                {
                    TagEnum.Protective,
                    TagEnum.MeleeWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_BEAR,
                BoardImage = "/Library;component/Image/Board/Bear.jpg",
                Image = "/Library;component/Image/Character/Bear.jpg",
                IdImage = "/Library;component/Image/IdImage/Bear.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Shove
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1MeleeAction,
                    OrangePower2 = PowerEnum.Plus1MeleeDieResult,
                    RedPower1 = PowerEnum.Plus1MeleeDamage,
                    RedPower2 = PowerEnum.Plus1CombatDie,
                    RedPower3 = PowerEnum.Lifesaver
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            list.Add(new Domain.Character.Character
            {
                Name = "BearZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.MeleeWarrior,
                    TagEnum.Protective
                },
                LongDescription = TranslationsService.DESCRIPTION_BEAR,
                BoardImage = "/Library;component/Image/Board/BearZombie.jpg",
                Image = "/Library;component/Image/Character/BearZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/BearZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Shove
                    },
                    YellowPower = PowerEnum.Plus1MeleeAction,
                    OrangePower1 = PowerEnum.Plus1MeleeDieResult,
                    OrangePower2 = PowerEnum.Barbarian,
                    RedPower1 = PowerEnum.Plus1MeleeDamage,
                    RedPower2 = PowerEnum.MeleeBloodlust,
                    RedPower3 = PowerEnum.Lifesaver
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            //BELLE
            list.Add(new Domain.Character.Character
            {
                Name = "Belle",
                Tags = new List<TagEnum>
                {
                    TagEnum.Runner,
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_BELLE,
                BoardImage = "/Library;component/Image/Board/Belle.jpg",
                Image = "/Library;component/Image/Character/Belle.jpg",
                IdImage = "/Library;component/Image/IdImage/Belle.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Plus1MoveAction
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1MeleeAction,
                    OrangePower2 = PowerEnum.Plus1RangedDieResult,
                    RedPower1 = PowerEnum.Plus1MoveAction,
                    RedPower2 = PowerEnum.Plus1CombatDie,
                    RedPower3 = PowerEnum.Ambidextrous
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.PrisonOutBreak
            });

            list.Add(new Domain.Character.Character
            {
                Name = "BelleZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_BELLE,
                BoardImage = "/Library;component/Image/Board/BelleZombie.jpg",
                Image = "/Library;component/Image/Character/BelleZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/BelleZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Plus1MoveAction
                    },
                    YellowPower = PowerEnum.Plus1RangedAction,
                    OrangePower1 = PowerEnum.Plus1RangedDieResult,
                    OrangePower2 = PowerEnum.ZombieLink,
                    RedPower1 = PowerEnum.Plus1CombatDie,
                    RedPower2 = PowerEnum.Ambidextrous,
                    RedPower3 = PowerEnum.Regeneration
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.PrisonOutBreak
            });

            //Cathy
            list.Add(new Domain.Character.Character
            {
                Name = "Cathy",
                Tags = new List<TagEnum>
                {
                    TagEnum.Runner,
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_CATHY,
                BoardImage = "/Library;component/Image/Board/Cathy.jpg",
                Image = "/Library;component/Image/Character/Cathy.jpg",
                IdImage = "/Library;component/Image/IdImage/Cathy.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Sprint
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1MeleeAction,
                    OrangePower2 = PowerEnum.Jump,
                    RedPower1 = PowerEnum.Plus1CombatDieResult,
                    RedPower2 = PowerEnum.CombatBloodlust,
                    RedPower3 = PowerEnum.Lifesaver
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            list.Add(new Domain.Character.Character
            {
                Name = "CathyZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.MeleeWarrior,
                    TagEnum.Runner
                },
                LongDescription = TranslationsService.DESCRIPTION_CATHY,
                BoardImage = "/Library;component/Image/Board/CathyZombie.jpg",
                Image = "/Library;component/Image/Character/CathyZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/CathyZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Sprint
                    },
                    YellowPower = PowerEnum.Plus1MeleeAction,
                    OrangePower1 = PowerEnum.Jump,
                    OrangePower2 = PowerEnum.ReaperMelee,
                    RedPower1 = PowerEnum.Plus1CombatDieResult,
                    RedPower2 = PowerEnum.CombatBloodlust,
                    RedPower3 = PowerEnum.DreadnoughtWalker
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            //Dan
            list.Add(new Domain.Character.Character
            {
                Name = "Dan",
                Tags = new List<TagEnum>
                {
                    TagEnum.Runner,
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_DAN,
                BoardImage = "/Library;component/Image/Board/Dan.jpg",
                Image = "/Library;component/Image/Character/Dan.jpg",
                IdImage = "/Library;component/Image/IdImage/Dan.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Lifesaver,
                        PowerEnum.FastRoping
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1MoveAction,
                    OrangePower2 = PowerEnum.Jump,
                    RedPower1 = PowerEnum.Plus1MeleeDamage,
                    RedPower2 = PowerEnum.Plus1CombatAction,
                    RedPower3 = PowerEnum.Tactician
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            list.Add(new Domain.Character.Character
            {
                Name = "DanZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.MeleeWarrior,
                    TagEnum.Runner
                },
                LongDescription = TranslationsService.DESCRIPTION_DAN,
                BoardImage = "/Library;component/Image/Board/DanZombie.jpg",
                Image = "/Library;component/Image/Character/DanZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/DanZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Lifesaver,
                        PowerEnum.FastRoping
                    },
                    YellowPower = PowerEnum.Plus1MeleeAction,
                    OrangePower1 = PowerEnum.DreadnoughtWalker,
                    OrangePower2 = PowerEnum.Jump,
                    RedPower1 = PowerEnum.Plus1MeleeDamage,
                    RedPower2 = PowerEnum.Regeneration,
                    RedPower3 = PowerEnum.Tactician
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            //Derek
            list.Add(new Domain.Character.Character
            {
                Name = "Derek",
                Tags = new List<TagEnum>
                {
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_DEREK,
                BoardImage = "/Library;component/Image/Board/Derek.jpg",
                Image = "/Library;component/Image/Character/Derek.jpg",
                IdImage = "/Library;component/Image/IdImage/Derek.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Plus1Range,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1MeleeAction,
                    OrangePower2 = PowerEnum.ToxicImmunity,
                    RedPower1 = PowerEnum.Plus1MoveAction,
                    RedPower2 = PowerEnum.Plus1CombatDieResult,
                    RedPower3 = PowerEnum.Slippery
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.ToxicCityMall
            });

            list.Add(new Domain.Character.Character
            {
                Name = "DerekZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_DEREK,
                BoardImage = "/Library;component/Image/Board/DerekZombie.jpg",
                Image = "/Library;component/Image/Character/DerekZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/DerekZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Plus1Range
                    },
                    YellowPower = PowerEnum.Plus1MeleeAction,
                    OrangePower1 = PowerEnum.ToxicImmunity,
                    OrangePower2 = PowerEnum.Regeneration,
                    RedPower1 = PowerEnum.Plus1CombatDieResult,
                    RedPower2 = PowerEnum.Slippery,
                    RedPower3 = PowerEnum.ZombieLink
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.ToxicCityMall
            });

            //Doug
            list.Add(new Domain.Character.Character
            {
                Name = "Doug",
                Tags = new List<TagEnum>
                {
                    TagEnum.RangedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_DOUG,
                BoardImage = "/Library;component/Image/Board/Doug.jpg",
                Image = "/Library;component/Image/Character/Doug.jpg",
                IdImage = "/Library;component/Image/IdImage/Doug.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.MatchingSet,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1CombatAction,
                    OrangePower2 = PowerEnum.Plus1RangedDie,
                    RedPower1 = PowerEnum.Plus1CombatDieResult,
                    RedPower2 = PowerEnum.Ambidextrous,
                    RedPower3 = PowerEnum.Slippery
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.Season1
            });

            list.Add(new Domain.Character.Character
            {
                Name = "DougZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.RangedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_DOUG,
                BoardImage = "/Library;component/Image/Board/DougZombie.jpg",
                Image = "/Library;component/Image/Character/DougZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/DougZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.MatchingSet
                    },
                    YellowPower = PowerEnum.Plus1SearchAction,
                    OrangePower1 = PowerEnum.Plus1RangedDie,
                    OrangePower2 = PowerEnum.CollectorRunner,
                    RedPower1 = PowerEnum.Plus1CombatDieResult,
                    RedPower2 = PowerEnum.Ambidextrous,
                    RedPower3 = PowerEnum.ZombieLink
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.Season1
            });

            //Elsa
            list.Add(new Domain.Character.Character
            {
                Name = "Elsa",
                Tags = new List<TagEnum>
                {
                    TagEnum.Discreet,
                    TagEnum.Runner,
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_ELSA,
                BoardImage = "/Library;component/Image/Board/Elsa.jpg",
                Image = "/Library;component/Image/Character/Elsa.jpg",
                IdImage = "/Library;component/Image/IdImage/Elsa.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.BreakIn,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1RangedAction,
                    OrangePower2 = PowerEnum.Slippery,
                    RedPower1 = PowerEnum.Plus1CombatAction,
                    RedPower2 = PowerEnum.Plus1MoveAction,
                    RedPower3 = PowerEnum.TwoZonesPerMove
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.ToxicCityMall
            });

            list.Add(new Domain.Character.Character
            {
                Name = "ElsaZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.Discreet,
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_ELSA,
                BoardImage = "/Library;component/Image/Board/ElsaZombie.jpg",
                Image = "/Library;component/Image/Character/ElsaZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/ElsaZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.BreakIn
                    },
                    YellowPower = PowerEnum.Plus1RangedAction,
                    OrangePower1 = PowerEnum.Slippery,
                    OrangePower2 = PowerEnum.Rotten,
                    RedPower1 = PowerEnum.Plus1CombatAction,
                    RedPower2 = PowerEnum.Plus1MoveAction,
                    RedPower3 = PowerEnum.SuperStrength
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            //Grindlock
            list.Add(new Domain.Character.Character
            {
                Name = "Grindlock",
                Tags = new List<TagEnum>
                {
                    TagEnum.MeleeWarrior,
                    TagEnum.Protective
                },
                LongDescription = TranslationsService.DESCRIPTION_GRINDLOCK,
                BoardImage = "/Library;component/Image/Board/Grindlock.jpg",
                Image = "/Library;component/Image/Character/Grindlock.jpg",
                IdImage = "/Library;component/Image/IdImage/Grindlock.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Taunt,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1MeleeAction,
                    OrangePower2 = PowerEnum.Slippery,
                    RedPower1 = PowerEnum.Plus1MeleeDamage,
                    RedPower2 = PowerEnum.IsThatAllYouveGot,
                    RedPower3 = PowerEnum.Roll6Plus1CombatDie
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.PrisonOutBreak
            });

            list.Add(new Domain.Character.Character
            {
                Name = "GrindlockZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.MeleeWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_GRINDLOCK,
                BoardImage = "/Library;component/Image/Board/GrindlockZombie.jpg",
                Image = "/Library;component/Image/Character/GrindlockZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/GrindlockZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Taunt
                    },
                    YellowPower = PowerEnum.Plus1MeleeAction,
                    OrangePower1 = PowerEnum.Slippery,
                    OrangePower2 = PowerEnum.ZombieLink,
                    RedPower1 = PowerEnum.Plus1MeleeDamage,
                    RedPower2 = PowerEnum.ReaperMelee,
                    RedPower3 = PowerEnum.Roll6Plus1CombatDie
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.PrisonOutBreak
            });

            //James
            list.Add(new Domain.Character.Character
            {
                Name = "James",
                Tags = new List<TagEnum>
                {
                    TagEnum.RangedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_JAMES,
                BoardImage = "/Library;component/Image/Board/James.jpg",
                Image = "/Library;component/Image/Character/James.jpg",
                IdImage = "/Library;component/Image/IdImage/James.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Plus1Range,
                        PowerEnum.FastRoping
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1RangedAction,
                    OrangePower2 = PowerEnum.Sniper,
                    RedPower1 = PowerEnum.Plus1CombatAction,
                    RedPower2 = PowerEnum.Plus1CombatDieResult,
                    RedPower3 = PowerEnum.ReaperCombat
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            list.Add(new Domain.Character.Character
            {
                Name = "JamesZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.RangedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_JAMES,
                BoardImage = "/Library;component/Image/Board/JamesZombie.jpg",
                Image = "/Library;component/Image/Character/JamesZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/JamesZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Plus1Range,
                        PowerEnum.FastRoping
                    },
                    YellowPower = PowerEnum.Plus1RangedAction,
                    OrangePower1 = PowerEnum.Plus1RangedDamage,
                    OrangePower2 = PowerEnum.Sniper,
                    RedPower1 = PowerEnum.Plus1CombatDieResult,
                    RedPower2 = PowerEnum.CombatBloodlust,
                    RedPower3 = PowerEnum.ReaperCombat
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            //Jane
            list.Add(new Domain.Character.Character
            {
                Name = "Jane",
                Tags = new List<TagEnum>
                {
                    TagEnum.RangedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_JANE,
                BoardImage = "/Library;component/Image/Board/Jane.jpg",
                Image = "/Library;component/Image/Character/Jane.jpg",
                IdImage = "/Library;component/Image/IdImage/Jane.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Plus1RangedDie,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1RangedDie,
                    OrangePower2 = PowerEnum.Lucky,
                    RedPower1 = PowerEnum.Plus1CombatAction,
                    RedPower2 = PowerEnum.Plus1MoveAction,
                    RedPower3 = PowerEnum.Gunslinger
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            list.Add(new Domain.Character.Character
            {
                Name = "JaneZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.RangedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_JANE,
                BoardImage = "/Library;component/Image/Board/JaneZombie.jpg",
                Image = "/Library;component/Image/Character/JaneZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/JaneZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Plus1RangedDie
                    },
                    YellowPower = PowerEnum.Plus1RangedAction,
                    OrangePower1 = PowerEnum.Plus1RangedDie,
                    OrangePower2 = PowerEnum.FullAuto,
                    RedPower1 = PowerEnum.Plus1CombatAction,
                    RedPower2 = PowerEnum.Gunslinger,
                    RedPower3 = PowerEnum.HitAndRun
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            //Jeff
            list.Add(new Domain.Character.Character
            {
                Name = "Jeff",
                Tags = new List<TagEnum>
                {
                    TagEnum.RangedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_JEFF,
                BoardImage = "/Library;component/Image/Board/Jeff.jpg",
                Image = "/Library;component/Image/Character/Jeff.jpg",
                IdImage = "/Library;component/Image/IdImage/Jeff.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Sniper,
                    },
                    YellowPower = PowerEnum.Plus1RangedDie,
                    OrangePower1 = PowerEnum.Plus1Range,
                    OrangePower2 = PowerEnum.ToxicImmunity,
                    RedPower1 = PowerEnum.Plus1RangedAction,
                    RedPower2 = PowerEnum.ReaperCombat,
                    RedPower3 = PowerEnum.Tactician
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.AngryNeighbors
            });

            list.Add(new Domain.Character.Character
            {
                Name = "JeffZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.RangedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_JEFF,
                BoardImage = "/Library;component/Image/Board/JeffZombie.jpg",
                Image = "/Library;component/Image/Character/JeffZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/JeffZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Sniper
                    },
                    YellowPower = PowerEnum.Plus1RangedAction,
                    OrangePower1 = PowerEnum.FrenzyRanged,
                    OrangePower2 = PowerEnum.Plus1Range,
                    RedPower1 = PowerEnum.Plus1RangedAction,
                    RedPower2 = PowerEnum.ReaperCombat,
                    RedPower3 = PowerEnum.Tactician
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.AngryNeighbors
            });

            //Joe
            list.Add(new Domain.Character.Character
            {
                Name = "Joe",
                Tags = new List<TagEnum>
                {
                    TagEnum.Scavenger,
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_JOE,
                BoardImage = "/Library;component/Image/Board/Joe.jpg",
                Image = "/Library;component/Image/Character/Joe.jpg",
                IdImage = "/Library;component/Image/IdImage/Joe.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Scavenger,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1CombatDie,
                    OrangePower2 = PowerEnum.ReaperCombat,
                    RedPower1 = PowerEnum.Plus1CombatAction,
                    RedPower2 = PowerEnum.Plus1CombatDieResult,
                    RedPower3 = PowerEnum.Ambidextrous
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            list.Add(new Domain.Character.Character
            {
                Name = "JoeZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.Scavenger,
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_JOE,
                BoardImage = "/Library;component/Image/Board/JoeZombie.jpg",
                Image = "/Library;component/Image/Character/JoeZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/JoeZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Scavenger
                    },
                    YellowPower = PowerEnum.Plus1SearchAction,
                    OrangePower1 = PowerEnum.ReaperCombat,
                    OrangePower2 = PowerEnum.Rotten,
                    RedPower1 = PowerEnum.Plus1CombatDieResult,
                    RedPower2 = PowerEnum.Ambidextrous,
                    RedPower3 = PowerEnum.ZombieLink
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            //Josh
            list.Add(new Domain.Character.Character
            {
                Name = "Josh",
                Tags = new List<TagEnum>
                {
                    TagEnum.DiceThrowner,
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_JOSH,
                BoardImage = "/Library;component/Image/Board/Josh.jpg",
                Image = "/Library;component/Image/Character/Josh.jpg",
                IdImage = "/Library;component/Image/IdImage/Josh.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Slippery,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1MeleeDie,
                    OrangePower2 = PowerEnum.OneReRollPerTurn,
                    RedPower1 = PowerEnum.Plus1MoveAction,
                    RedPower2 = PowerEnum.Plus1CombatDieResult,
                    RedPower3 = PowerEnum.Lucky
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.Season1
            });

            list.Add(new Domain.Character.Character
            {
                Name = "JoshZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.Discreet,
                    TagEnum.DiceThrowner,
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_JOSH,
                BoardImage = "/Library;component/Image/Board/JoshZombie.jpg",
                Image = "/Library;component/Image/Character/JoshZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/JoshZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Slippery
                    },
                    YellowPower = PowerEnum.Plus1MeleeAction,
                    OrangePower1 = PowerEnum.OneReRollPerTurn,
                    OrangePower2 = PowerEnum.LowProfile,
                    RedPower1 = PowerEnum.Plus1CombatDieResult,
                    RedPower2 = PowerEnum.Ambidextrous,
                    RedPower3 = PowerEnum.Lucky
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.Season1
            });

            //Joshua
            list.Add(new Domain.Character.Character
            {
                Name = "Joshua",
                Tags = new List<TagEnum>
                {
                    TagEnum.Protective,
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_JOSHUA,
                BoardImage = "/Library;component/Image/Board/Joshua.jpg",
                Image = "/Library;component/Image/Character/Joshua.jpg",
                IdImage = "/Library;component/Image/IdImage/Joshua.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Lifesaver,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1RangedAction,
                    OrangePower2 = PowerEnum.Plus1MeleeDieResult,
                    RedPower1 = PowerEnum.Plus1CombatAction,
                    RedPower2 = PowerEnum.Plus1RangedDieResult,
                    RedPower3 = PowerEnum.BornLeader
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.PrisonOutBreak
            });

            list.Add(new Domain.Character.Character
            {
                Name = "JoshuaZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.Protective,
                    TagEnum.MeleeWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_JOSHUA,
                BoardImage = "/Library;component/Image/Board/JoshuaZombie.jpg",
                Image = "/Library;component/Image/Character/JoshuaZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/JoshuaZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Lifesaver
                    },
                    YellowPower = PowerEnum.Plus1MeleeAction,
                    OrangePower1 = PowerEnum.Plus1MeleeDieResult,
                    OrangePower2 = PowerEnum.SuperStrength,
                    RedPower1 = PowerEnum.Plus1RangedDieResult,
                    RedPower2 = PowerEnum.BornLeader,
                    RedPower3 = PowerEnum.Regeneration
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.PrisonOutBreak
            });

            //Julien
            list.Add(new Domain.Character.Character
            {
                Name = "Julien",
                Tags = new List<TagEnum>
                {
                    TagEnum.RangedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_JULIEN,
                BoardImage = "/Library;component/Image/Board/Julien.jpg",
                Image = "/Library;component/Image/Character/Julien.jpg",
                IdImage = "/Library;component/Image/IdImage/Julien.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.SteadyHand,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1RangedDieResult,
                    OrangePower2 = PowerEnum.HitAndRun,
                    RedPower1 = PowerEnum.Plus1CombatDie,
                    RedPower2 = PowerEnum.Plus1CombatAction,
                    RedPower3 = PowerEnum.PointBlank
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.AngryNeighbors
            });

            list.Add(new Domain.Character.Character
            {
                Name = "JulienZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.RangedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_JULIEN,
                BoardImage = "/Library;component/Image/Board/JulienZombie.jpg",
                Image = "/Library;component/Image/Character/JulienZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/JulienZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.SteadyHand
                    },
                    YellowPower = PowerEnum.Plus1RangedAction,
                    OrangePower1 = PowerEnum.Plus1RangedDieResult,
                    OrangePower2 = PowerEnum.RangedBloodlust,
                    RedPower1 = PowerEnum.Plus1RangedDamage,
                    RedPower2 = PowerEnum.Plus1CombatDie,
                    RedPower3 = PowerEnum.PointBlank
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.AngryNeighbors
            });

            //Kim
            list.Add(new Domain.Character.Character
            {
                Name = "Kim",
                Tags = new List<TagEnum>
                {
                    TagEnum.DiceThrowner,
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_KIM,
                BoardImage = "/Library;component/Image/Board/Kim.jpg",
                Image = "/Library;component/Image/Character/Kim.jpg",
                IdImage = "/Library;component/Image/IdImage/Kim.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Lucky,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Webbing,
                    OrangePower2 = PowerEnum.Roll6Plus1RangedDie,
                    RedPower1 = PowerEnum.Plus1CombatAction,
                    RedPower2 = PowerEnum.Plus1CombatDieResult,
                    RedPower3 = PowerEnum.Roll6Plus1MeleeDie
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.PrisonOutBreak
            });

            list.Add(new Domain.Character.Character
            {
                Name = "KimZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.DiceThrowner,
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_KIM,
                BoardImage = "/Library;component/Image/Board/KimZombie.jpg",
                Image = "/Library;component/Image/Character/KimZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/KimZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Lucky
                    },
                    YellowPower = PowerEnum.Plus1RangedAction,
                    OrangePower1 = PowerEnum.Webbing,
                    OrangePower2 = PowerEnum.ReaperCombat,
                    RedPower1 = PowerEnum.Plus1CombatDieResult,
                    RedPower2 = PowerEnum.ZombieLink,
                    RedPower3 = PowerEnum.Roll6Plus1MeleeDie
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.PrisonOutBreak
            });

            //Laurie
            list.Add(new Domain.Character.Character
            {
                Name = "Laurie",
                Tags = new List<TagEnum>
                {
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_LAURIE,
                BoardImage = "/Library;component/Image/Board/Laurie.jpg",
                Image = "/Library;component/Image/Character/Laurie.jpg",
                IdImage = "/Library;component/Image/IdImage/Laurie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.FreeReload,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1RangedAction,
                    OrangePower2 = PowerEnum.Webbing,
                    RedPower1 = PowerEnum.Plus1CombatAction,
                    RedPower2 = PowerEnum.Plus1CombatDieResult,
                    RedPower3 = PowerEnum.HitAndRun
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            list.Add(new Domain.Character.Character
            {
                Name = "LaurieZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_LAURIE,
                BoardImage = "/Library;component/Image/Board/LaurieZombie.jpg",
                Image = "/Library;component/Image/Character/LaurieZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/LaurieZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.FreeReload
                    },
                    YellowPower = PowerEnum.Plus1RangedAction,
                    OrangePower1 = PowerEnum.DeathGrasp,
                    OrangePower2 = PowerEnum.Webbing,
                    RedPower1 = PowerEnum.Plus1CombatDieResult,
                    RedPower2 = PowerEnum.HitAndRun,
                    RedPower3 = PowerEnum.ReaperCombat
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            //Louise
            list.Add(new Domain.Character.Character
            {
                Name = "Louise",
                Tags = new List<TagEnum>
                {
                    TagEnum.RangedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_LOUISE,
                BoardImage = "/Library;component/Image/Board/Louise.jpg",
                Image = "/Library;component/Image/Character/Louise.jpg",
                IdImage = "/Library;component/Image/IdImage/Louise.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.SearchPlus1Card,
                        PowerEnum.FastRoping
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1CombatDamage,
                    OrangePower2 = PowerEnum.Plus1RangedDieResult,
                    RedPower1 = PowerEnum.Plus1CombatDie,
                    RedPower2 = PowerEnum.Plus1CombatAction,
                    RedPower3 = PowerEnum.Sniper
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            list.Add(new Domain.Character.Character
            {
                Name = "LouiseZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.Scavenger,
                    TagEnum.RangedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_LOUISE,
                BoardImage = "/Library;component/Image/Board/LouiseZombie.jpg",
                Image = "/Library;component/Image/Character/LouiseZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/LouiseZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.SearchPlus1Card,
                        PowerEnum.FastRoping
                    },
                    YellowPower = PowerEnum.Plus1SearchAction,
                    OrangePower1 = PowerEnum.Plus1CombatDamage,
                    OrangePower2 = PowerEnum.PointBlank,
                    RedPower1 = PowerEnum.Plus1CombatDie,
                    RedPower2 = PowerEnum.FrenzyCombat,
                    RedPower3 = PowerEnum.Sniper
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            //Maddie
            list.Add(new Domain.Character.Character
            {
                Name = "Maddie",
                Tags = new List<TagEnum>
                {
                    TagEnum.MeleeWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_MADDIE,
                BoardImage = "/Library;component/Image/Board/Maddie.jpg",
                Image = "/Library;component/Image/Character/Maddie.jpg",
                IdImage = "/Library;component/Image/IdImage/Maddie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.MeleeBloodlust,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1MeleeDieResult,
                    OrangePower2 = PowerEnum.Taunt,
                    RedPower1 = PowerEnum.Plus1CombatAction,
                    RedPower2 = PowerEnum.HitAndRun,
                    RedPower3 = PowerEnum.Roll6Plus1CombatDie
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            list.Add(new Domain.Character.Character
            {
                Name = "MaddieZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.MeleeWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_MADDIE,
                BoardImage = "/Library;component/Image/Board/MaddieZombie.jpg",
                Image = "/Library;component/Image/Character/MaddieZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/MaddieZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.MeleeBloodlust
                    },
                    YellowPower = PowerEnum.Plus1MeleeAction,
                    OrangePower1 = PowerEnum.Barbarian,
                    OrangePower2 = PowerEnum.Taunt,
                    RedPower1 = PowerEnum.HitAndRun,
                    RedPower2 = PowerEnum.Roll6Plus1CombatDie,
                    RedPower3 = PowerEnum.SuperStrength
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });


            //Ned
            list.Add(new Domain.Character.Character
            {
                Name = "Ned",
                Tags = new List<TagEnum>
                {
                    TagEnum.BalancedWarrior,
                    TagEnum.Scavenger
                },
                LongDescription = TranslationsService.DESCRIPTION_NED,
                BoardImage = "/Library;component/Image/Board/Ned.jpg",
                Image = "/Library;component/Image/Character/Ned.jpg",
                IdImage = "/Library;component/Image/IdImage/Ned.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Plus1SearchAction,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1RangedDie,
                    OrangePower2 = PowerEnum.Plus1CombatAction,
                    RedPower1 = PowerEnum.Plus1CombatDie,
                    RedPower2 = PowerEnum.Plus1CombatDieResult,
                    RedPower3 = PowerEnum.Tough
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.Season1
            });

            list.Add(new Domain.Character.Character
            {
                Name = "NedZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.RangedWarrior,
                    TagEnum.Scavenger
                },
                LongDescription = TranslationsService.DESCRIPTION_NED,
                BoardImage = "/Library;component/Image/Board/NedZombie.jpg",
                Image = "/Library;component/Image/Character/NedZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/NedZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Plus1SearchAction
                    },
                    YellowPower = PowerEnum.Plus1RangedAction,
                    OrangePower1 = PowerEnum.Plus1RangedDie,
                    OrangePower2 = PowerEnum.Regeneration,
                    RedPower1 = PowerEnum.Plus1CombatDie,
                    RedPower2 = PowerEnum.Plus1CombatDieResult,
                    RedPower3 = PowerEnum.Rotten
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.Season1
            });

            //Neema
            list.Add(new Domain.Character.Character
            {
                Name = "Neema",
                Tags = new List<TagEnum>
                {
                    TagEnum.Tank,
                    TagEnum.BalancedWarrior
                },
                LongDescription = TranslationsService.DESCRIPTION_NEEMA,
                BoardImage = "/Library;component/Image/Board/Neema.jpg",
                Image = "/Library;component/Image/Character/Neema.jpg",
                IdImage = "/Library;component/Image/IdImage/Neema.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.BornLeader,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1CombatAction,
                    OrangePower2 = PowerEnum.IsThatAllYouveGot,
                    RedPower1 = PowerEnum.Plus1MeleeAction,
                    RedPower2 = PowerEnum.Plus1RangedAction,
                    RedPower3 = PowerEnum.Tough
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.ToxicCityMall
            });

            list.Add(new Domain.Character.Character
            {
                Name = "NeemaZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.BalancedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_NEEMA,
                BoardImage = "/Library;component/Image/Board/NeemaZombie.jpg",
                Image = "/Library;component/Image/Character/NeemaZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/NeemaZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.BornLeader
                    },
                    YellowPower = PowerEnum.Plus1SearchAction,
                    OrangePower1 = PowerEnum.IsThatAllYouveGot,
                    OrangePower2 = PowerEnum.ZombieLink,
                    RedPower1 = PowerEnum.Plus1MeleeAction,
                    RedPower2 = PowerEnum.Plus1RangedAction,
                    RedPower3 = PowerEnum.Plus1CombatDieResult
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.ToxicCityMall
            });

            //Parker
            list.Add(new Domain.Character.Character
            {
                Name = "Parker",
                Tags = new List<TagEnum>
                {
                    TagEnum.BalancedWarrior,
                    TagEnum.HelicopterPilot
                },
                LongDescription = TranslationsService.DESCRIPTION_PARKER,
                BoardImage = "/Library;component/Image/Board/Parker.jpg",
                Image = "/Library;component/Image/Character/Parker.jpg",
                IdImage = "/Library;component/Image/IdImage/Parker.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Medic,
                        PowerEnum.HelicopterPilot
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1MoveAction,
                    OrangePower2 = PowerEnum.FreeReload,
                    RedPower1 = PowerEnum.Plus1CombatAction,
                    RedPower2 = PowerEnum.Plus1Range,
                    RedPower3 = PowerEnum.Shove
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            list.Add(new Domain.Character.Character
            {
                Name = "ParkerZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.BalancedWarrior,
                    TagEnum.HelicopterPilot
                },
                LongDescription = TranslationsService.DESCRIPTION_PARKER,
                BoardImage = "/Library;component/Image/Board/ParkerZombie.jpg",
                Image = "/Library;component/Image/Character/ParkerZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/ParkerZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Medic,
                        PowerEnum.HelicopterPilot
                    },
                    YellowPower = PowerEnum.Plus1RangedAction,
                    OrangePower1 = PowerEnum.DeathGrasp,
                    OrangePower2 = PowerEnum.FreeReload,
                    RedPower1 = PowerEnum.Regeneration,
                    RedPower2 = PowerEnum.Plus1Range,
                    RedPower3 = PowerEnum.Shove
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            //Phil
            list.Add(new Domain.Character.Character
            {
                Name = "Phil",
                Tags = new List<TagEnum>
                {
                    TagEnum.RangedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_PHIL,
                BoardImage = "/Library;component/Image/Board/Phil.jpg",
                Image = "/Library;component/Image/Character/Phil.jpg",
                IdImage = "/Library;component/Image/IdImage/Phil.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.StartWithAGun,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1SearchAction,
                    OrangePower2 = PowerEnum.Plus1RangedDieResult,
                    RedPower1 = PowerEnum.Plus1RangedDie,
                    RedPower2 = PowerEnum.BornLeader,
                    RedPower3 = PowerEnum.Sniper
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.Season1
            });

            list.Add(new Domain.Character.Character
            {
                Name = "PhilZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.RangedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_PHIL,
                BoardImage = "/Library;component/Image/Board/PhilZombie.jpg",
                Image = "/Library;component/Image/Character/PhilZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/PhilZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.StartWithAGun
                    },
                    YellowPower = PowerEnum.Plus1RangedAction,
                    OrangePower1 = PowerEnum.Plus1RangedDieResult,
                    OrangePower2 = PowerEnum.Regeneration,
                    RedPower1 = PowerEnum.Plus1RangedDie,
                    RedPower2 = PowerEnum.Gunslinger,
                    RedPower3 = PowerEnum.Sniper
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.Season1
            });

            //Raoul
            list.Add(new Domain.Character.Character
            {
                Name = "Raoul",
                Tags = new List<TagEnum>
                {
                    TagEnum.Collector,
                },
                LongDescription = TranslationsService.DESCRIPTION_RAOUL,
                BoardImage = "/Library;component/Image/Board/Raoul.jpg",
                Image = "/Library;component/Image/Character/Raoul.jpg",
                IdImage = "/Library;component/Image/IdImage/Raoul.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Webbing,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Hoard,
                    OrangePower2 = PowerEnum.Medic,
                    RedPower1 = PowerEnum.Plus1MeleeAction,
                    RedPower2 = PowerEnum.Plus1RangedAction,
                    RedPower3 = PowerEnum.Plus1RangedDieResult
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.ToxicCityMall
            });

            list.Add(new Domain.Character.Character
            {
                Name = "RaoulZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.Collector,
                },
                LongDescription = TranslationsService.DESCRIPTION_RAOUL,
                BoardImage = "/Library;component/Image/Board/RaoulZombie.jpg",
                Image = "/Library;component/Image/Character/RaoulZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/RaoulZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Webbing
                    },
                    YellowPower = PowerEnum.Plus1SearchAction,
                    OrangePower1 = PowerEnum.DeathGrasp,
                    OrangePower2 = PowerEnum.Hoard,
                    RedPower1 = PowerEnum.Plus1RangedAction,
                    RedPower2 = PowerEnum.Plus1RangedDieResult,
                    RedPower3 = PowerEnum.Rotten
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.ToxicCityMall
            });

            //Shannon
            list.Add(new Domain.Character.Character
            {
                Name = "Shannon",
                Tags = new List<TagEnum>
                {
                    TagEnum.RangedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_SHANNON,
                BoardImage = "/Library;component/Image/Board/Shannon.jpg",
                Image = "/Library;component/Image/Character/Shannon.jpg",
                IdImage = "/Library;component/Image/IdImage/Shannon.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.PointBlank,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1RangedAction,
                    OrangePower2 = PowerEnum.Lucky,
                    RedPower1 = PowerEnum.Plus1CombatDie,
                    RedPower2 = PowerEnum.Plus1CombatAction,
                    RedPower3 = PowerEnum.Slippery
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.PrisonOutBreak
            });

            list.Add(new Domain.Character.Character
            {
                Name = "ShannonZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.RangedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_SHANNON,
                BoardImage = "/Library;component/Image/Board/ShannonZombie.jpg",
                Image = "/Library;component/Image/Character/ShannonZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/ShannonZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.PointBlank
                    },
                    YellowPower = PowerEnum.Plus1RangedAction,
                    OrangePower1 = PowerEnum.FrenzyRanged,
                    OrangePower2 = PowerEnum.Lucky,
                    RedPower1 = PowerEnum.Plus1CombatDie,
                    RedPower2 = PowerEnum.ReaperCombat,
                    RedPower3 = PowerEnum.Slippery
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.PrisonOutBreak
            });

            //Terry
            list.Add(new Domain.Character.Character
            {
                Name = "Terry",
                Tags = new List<TagEnum>
                {
                    TagEnum.BalancedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_TERRY,
                BoardImage = "/Library;component/Image/Board/Terry.jpg",
                Image = "/Library;component/Image/Character/Terry.jpg",
                IdImage = "/Library;component/Image/IdImage/Terry.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Plus1TeamAction,
                        PowerEnum.HelicopterPilot
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1CombatAction,
                    OrangePower2 = PowerEnum.Distributor,
                    RedPower1 = PowerEnum.Plus1CombatAction,
                    RedPower2 = PowerEnum.IsThatAllYouveGot,
                    RedPower3 = PowerEnum.SteadyHand
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            list.Add(new Domain.Character.Character
            {
                Name = "TerryZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.BalancedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_TERRY,
                BoardImage = "/Library;component/Image/Board/TerryZombie.jpg",
                Image = "/Library;component/Image/Character/TerryZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/TerryZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.Plus1TeamAction,
                        PowerEnum.HelicopterPilot
                    },
                    YellowPower = PowerEnum.Plus1MeleeAction,
                    OrangePower1 = PowerEnum.Distributor,
                    OrangePower2 = PowerEnum.ZombieLink,
                    RedPower1 = PowerEnum.IsThatAllYouveGot,
                    RedPower2 = PowerEnum.ReaperCombat,
                    RedPower3 = PowerEnum.SteadyHand
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            //Tiff
            list.Add(new Domain.Character.Character
            {
                Name = "Tiff",
                Tags = new List<TagEnum>
                {
                    TagEnum.RangedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_TIFF,
                BoardImage = "/Library;component/Image/Board/Tiff.jpg",
                Image = "/Library;component/Image/Character/Tiff.jpg",
                IdImage = "/Library;component/Image/IdImage/Tiff.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.StartWithASubMG,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1RangedAction,
                    OrangePower2 = PowerEnum.Sniper,
                    RedPower1 = PowerEnum.Plus1RangedDie,
                    RedPower2 = PowerEnum.Plus1RangedAction,
                    RedPower3 = PowerEnum.Gunslinger
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.AngryNeighbors
            });

            list.Add(new Domain.Character.Character
            {
                Name = "TiffZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.RangedWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_TIFF,
                BoardImage = "/Library;component/Image/Board/TiffZombie.jpg",
                Image = "/Library;component/Image/Character/TiffZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/TiffZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.StartWithASubMG
                    },
                    YellowPower = PowerEnum.Plus1RangedAction,
                    OrangePower1 = PowerEnum.HitAndRun,
                    OrangePower2 = PowerEnum.Sniper,
                    RedPower1 = PowerEnum.Plus1RangedDie,
                    RedPower2 = PowerEnum.Charge,


                    RedPower3 = PowerEnum.Gunslinger
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.AngryNeighbors
            });

            //Travis
            list.Add(new Domain.Character.Character
            {
                Name = "Travis",
                Tags = new List<TagEnum>
                {
                    TagEnum.BalancedWarrior,
                    TagEnum.HelicopterPilot
                },
                LongDescription = TranslationsService.DESCRIPTION_TRAVIS,
                BoardImage = "/Library;component/Image/Board/Travis.jpg",
                Image = "/Library;component/Image/Character/Travis.jpg",
                IdImage = "/Library;component/Image/IdImage/Travis.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.HelicopterPilot,
                        PowerEnum.ReaperCombat
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1RangedDieResult,
                    OrangePower2 = PowerEnum.HitAndRun,
                    RedPower1 = PowerEnum.Plus1CombatDie,
                    RedPower2 = PowerEnum.Plus1CombatAction,
                    RedPower3 = PowerEnum.PointBlank
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            list.Add(new Domain.Character.Character
            {
                Name = "TravisZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.RangedWarrior,
                    TagEnum.HelicopterPilot
                },
                LongDescription = TranslationsService.DESCRIPTION_TRAVIS,
                BoardImage = "/Library;component/Image/Board/TravisZombie.jpg",
                Image = "/Library;component/Image/Character/TravisZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/TravisZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.ReaperCombat,
                        PowerEnum.HelicopterPilot
                    },
                    YellowPower = PowerEnum.Plus1RangedAction,
                    OrangePower1 = PowerEnum.CombatBloodlust,
                    OrangePower2 = PowerEnum.HitAndRun,
                    RedPower1 = PowerEnum.Plus1CombatDie,
                    RedPower2 = PowerEnum.FullAuto,
                    RedPower3 = PowerEnum.PointBlank
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.RueMorgue
            });

            //Wanda
            list.Add(new Domain.Character.Character
            {
                Name = "Wanda",
                Tags = new List<TagEnum>
                {
                    TagEnum.Runner,
                },
                LongDescription = TranslationsService.DESCRIPTION_WANDA,
                BoardImage = "/Library;component/Image/Board/Wanda.jpg",
                Image = "/Library;component/Image/Character/Wanda.jpg",
                IdImage = "/Library;component/Image/IdImage/Wanda.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.TwoZonesPerMove,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1MeleeDieResult,
                    OrangePower2 = PowerEnum.Slippery,
                    RedPower1 = PowerEnum.Plus1CombatDie,
                    RedPower2 = PowerEnum.Plus1MoveAction,
                    RedPower3 = PowerEnum.Plus1ZonePerMove
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.Season1
            });

            list.Add(new Domain.Character.Character
            {
                Name = "WandaZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.MeleeWarrior,
                    TagEnum.Runner
                },
                LongDescription = TranslationsService.DESCRIPTION_WANDA,
                BoardImage = "/Library;component/Image/Board/WandaZombie.jpg",
                Image = "/Library;component/Image/Character/WandaZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/WandaZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.TwoZonesPerMove
                    },
                    YellowPower = PowerEnum.Plus1MeleeAction,
                    OrangePower1 = PowerEnum.Plus1MeleeDieResult,
                    OrangePower2 = PowerEnum.Regeneration,
                    RedPower1 = PowerEnum.Plus1CombatDie,
                    RedPower2 = PowerEnum.Plus1ZonePerMove,
                    RedPower3 = PowerEnum.DeathGrasp
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.Season1
            });

            //Watts
            list.Add(new Domain.Character.Character
            {
                Name = "Watts",
                Tags = new List<TagEnum>
                {
                    TagEnum.MeleeWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_WATTS,
                BoardImage = "/Library;component/Image/Board/Watts.jpg",
                Image = "/Library;component/Image/Character/Watts.jpg",
                IdImage = "/Library;component/Image/IdImage/Watts.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.StartWithABaseballBat,
                    },
                    YellowPower = PowerEnum.Plus1Action,
                    OrangePower1 = PowerEnum.Plus1MeleeDie,
                    OrangePower2 = PowerEnum.Shove,
                    RedPower1 = PowerEnum.Plus1CombatAction,
                    RedPower2 = PowerEnum.Plus1CombatDieResult,
                    RedPower3 = PowerEnum.TwoZonesPerMove
                },
                IsZombie = false,
                ZombicideGame = ZombicideGameEnum.PrisonOutBreak
            });

            list.Add(new Domain.Character.Character
            {
                Name = "WattsZ",
                Tags = new List<TagEnum>
                {
                    TagEnum.MeleeWarrior,
                },
                LongDescription = TranslationsService.DESCRIPTION_WATTS,
                BoardImage = "/Library;component/Image/Board/WattsZombie.jpg",
                Image = "/Library;component/Image/Character/WattsZombie.jpg",
                IdImage = "/Library;component/Image/IdImage/WattsZombie.jpg",
                Powers = new CharacterPower
                {
                    BluePower = new List<PowerEnum>
                    {
                        PowerEnum.StartWithABaseballBat
                    },
                    YellowPower = PowerEnum.Plus1MeleeAction,
                    OrangePower1 = PowerEnum.FrenzyMelee,
                    OrangePower2 = PowerEnum.Shove,
                    RedPower1 = PowerEnum.Plus1CombatDieResult,
                    RedPower2 = PowerEnum.TwoZonesPerMove,
                    RedPower3 = PowerEnum.FrenzyCombat
                },
                IsZombie = true,
                ZombicideGame = ZombicideGameEnum.PrisonOutBreak
            });

            return list;
        }
        #endregion

        public List<Domain.Character.Character> GetCharacters(List<ZombicideGameEnum> zombicideGames, bool withZombie = false)
        {
            var list = CreateAllCharacters();

            if (withZombie)
            {
                return list.Where(x => zombicideGames.Contains(x.ZombicideGame)).ToList();
            }

            return list.Where(x => zombicideGames.Contains(x.ZombicideGame) && !x.IsZombie).ToList();
        }

    }
}