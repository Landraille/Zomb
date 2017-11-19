using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters;
using System.Text;
using Core;
using Core.GlobalVar;
using Domain;
using Domain.Card.Equipment;
using Domain.Card.Zombie;
using Domain.Zombie;
using Newtonsoft.Json;
using Services.CardService.Dto;
using Services.Extension;
using Services.Zombie.dto;
using ZombieTypeEnum = Domain.Zombie.ZombieTypeEnum;

namespace Services.CardService
{
    public class CardService : ICardService
    {
        public List<ZombieCardDto> ZombieCards { get; private set; }

        public List<EquipmentDto> EquipmentCards { get; private set; }

        //private List<ZombieCardDto> CreateAllZombieCard()
        //{
        //    var list = new List<ZombieCardDto>();

        //    #region zombie card Season1
        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        1, //number
        //        null, //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        2, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(6, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        3, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        4, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(2, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        5, //number
        //        null, //blue invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Fatty), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        6, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        7, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        8, //number
        //        new Invasion(2, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(2, ZombieTypeEnum.Fatty) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        9, //number
        //        null, //blue invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        10, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        11, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Fatty) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        12, //number
        //        new Invasion(1, ZombieTypeEnum.Fatty), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(2, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        13, //number
        //        null, //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        14, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(6, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        15, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        16, //number
        //        new Invasion(2, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(2, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        17, //number
        //        null, //blue invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Fatty), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        18, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        19, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        20, //number
        //        new Invasion(2, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(2, ZombieTypeEnum.Fatty) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        21, //number
        //        null, //blue invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        22, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        23, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Fatty) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        24, //number
        //        new Invasion(1, ZombieTypeEnum.Fatty), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(2, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        25, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(5, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(3, ZombieTypeEnum.Fatty) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        26, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        27, //number
        //        new Invasion(2, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Fatty) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        28, //number
        //        new Invasion(2, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Abomination), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        29, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Abomination), //orange invasion
        //        new Invasion(6, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        30, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(6, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Abomination) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        31, //number
        //        new Invasion(1, ZombieTypeEnum.Runner), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(8, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        32, //number
        //        new Invasion(1, ZombieTypeEnum.Fatty), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Fatty), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        33, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(5, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(3, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        34, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        35, //number
        //        new Invasion(1, ZombieTypeEnum.Runner), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        36, //number
        //        new Invasion(1, ZombieTypeEnum.Abomination), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        37, //number              
        //        null, //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Walker) //red invasion
        //        )
        //        { IsSupplementaryActivation = true});

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        38, //number              
        //        null, //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Walker) //red invasion
        //        )
        //    { IsSupplementaryActivation = true });

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        39, //number              
        //        null, //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty) //red invasion
        //        )
        //    { IsSupplementaryActivation = true });

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        40, //number              
        //        null, //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Runner) //red invasion
        //        )
        //    { IsSupplementaryActivation = true });

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        41, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Runner) //red invasion
        //        )
        //    { IsSewerInvasion = true });

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.Season1,
        //        42, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty) //red invasion
        //        )
        //    { IsSewerInvasion = true });

        //    #endregion

        //    #region Walk of the dead 1
        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead1,
        //        43, //number
        //        null, //blue invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead1,
        //        44, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(6, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead1,
        //        45, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(8, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead1,
        //        46, //number
        //        new Invasion(2, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead1,
        //        47, //number
        //        null, //blue invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead1,
        //        48, //number
        //        new Invasion(7, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(6, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead1,
        //        49, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(8, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead1,
        //        50, //number
        //        new Invasion(2, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead1,
        //        51, //number
        //        null, //blue invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead1,
        //        52, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(6, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead1,
        //        53, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(8, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead1,
        //        54, //number
        //        new Invasion(2, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Walker) //red invasion
        //        ));
        //    #endregion

        //    #region Zombie dogz
        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.ZombieDogz,
        //       55, //number
        //       new Invasion(1, ZombieTypeEnum.Dogz), //blue invasion
        //       new Invasion(2, ZombieTypeEnum.Runner), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.Dogz), //orange invasion
        //       new Invasion(5, ZombieTypeEnum.Walker) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ZombieDogz,
        //        56, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Dogz), //yellow invasion
        //        new Invasion(6, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Dogz) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ZombieDogz,
        //        57, //number
        //        new Invasion(1, ZombieTypeEnum.Dogz), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Dogz), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ZombieDogz,
        //        58, //number
        //        new Invasion(2, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Dogz), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Dogz) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ZombieDogz,
        //        59, //number
        //        new Invasion(1, ZombieTypeEnum.Dogz), //blue invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Dogz), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ZombieDogz,
        //        60, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Dogz), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Dogz) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ZombieDogz,
        //        61, //number
        //        new Invasion(1, ZombieTypeEnum.Dogz), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Dogz), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ZombieDogz,
        //        62, //number
        //        new Invasion(2, ZombieTypeEnum.Dogz), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Dogz), //orange invasion
        //        new Invasion(2, ZombieTypeEnum.Fatty) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ZombieDogz,
        //        63, //number
        //        null, //blue invasion
        //        new Invasion(4, ZombieTypeEnum.Dogz), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.Dogz) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ZombieDogz,
        //        64, //number
        //        new Invasion(1, ZombieTypeEnum.Dogz), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(6, ZombieTypeEnum.Dogz), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ZombieDogz,
        //        65, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Dogz), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(8, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ZombieDogz,
        //        66, //number
        //        new Invasion(1, ZombieTypeEnum.Fatty), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Dogz), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Dogz) //red invasion
        //        ));
        //    #endregion

        //    #region Toxic city mall
        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ToxicCityMall,
        //        67, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerToxic), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerToxic), //yellow invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerToxic), //orange invasion
        //        new Invasion(3, ZombieTypeEnum.FattyToxic) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ToxicCityMall,
        //        68, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerToxic), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.WalkerToxic), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.RunnerToxic), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.WalkerToxic) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ToxicCityMall,
        //        69, //number
        //        new Invasion(2, ZombieTypeEnum.WalkerToxic), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.WalkerToxic), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerToxic), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.FattyToxic) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ToxicCityMall,
        //        70, //number
        //        new Invasion(2, ZombieTypeEnum.WalkerToxic), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.AbominationToxic), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerToxic), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerToxic) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ToxicCityMall,
        //        71, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerToxic), //blue invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerToxic), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.AbominationToxic), //orange invasion
        //        new Invasion(3, ZombieTypeEnum.RunnerToxic) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ToxicCityMall,
        //        72, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerToxic), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.WalkerToxic), //yellow invasion
        //        new Invasion(6, ZombieTypeEnum.WalkerToxic), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.AbominationToxic) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ToxicCityMall,
        //        73, //number
        //        new Invasion(1, ZombieTypeEnum.FattyToxic), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.RunnerToxic), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerToxic), //orange invasion
        //        new Invasion(8, ZombieTypeEnum.WalkerToxic) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ToxicCityMall,
        //        74, //number
        //        new Invasion(1, ZombieTypeEnum.RunnerToxic), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerToxic), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.FattyToxic), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerToxic) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ToxicCityMall,
        //        75, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerToxic), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.FattyToxic), //yellow invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerToxic), //orange invasion
        //        new Invasion(3, ZombieTypeEnum.RunnerToxic) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ToxicCityMall,
        //        76, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerToxic), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.WalkerToxic), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.FattyToxic), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.WalkerToxic) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ToxicCityMall,
        //        77, //number
        //        new Invasion(1, ZombieTypeEnum.RunnerToxic), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.FattyToxic), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerToxic), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.RunnerToxic) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ToxicCityMall,
        //        78, //number
        //        new Invasion(1, ZombieTypeEnum.AbominationToxic), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerToxic), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerToxic), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerToxic) //red invasion
        //        ));
        //    #endregion

        //    #region Prison outbreak
        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        79, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerBerserker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerBerserker), //yellow invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerBerserker), //orange invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerBerserker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        80, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerBerserker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.WalkerBerserker), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.RunnerBerserker), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.WalkerBerserker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        81, //number
        //        new Invasion(2, ZombieTypeEnum.WalkerBerserker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.WalkerBerserker), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerBerserker), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.FattyBerserker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        82, //number
        //        new Invasion(2, ZombieTypeEnum.WalkerBerserker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.AbominationBerserker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerBerserker), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerBerserker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        83, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerBerserker), //blue invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerBerserker), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.AbominationBerserker), //orange invasion
        //        new Invasion(3, ZombieTypeEnum.RunnerBerserker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        84, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerBerserker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.WalkerBerserker), //yellow invasion
        //        new Invasion(6, ZombieTypeEnum.WalkerBerserker), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.AbominationBerserker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        85, //number
        //        new Invasion(1, ZombieTypeEnum.FattyBerserker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.RunnerBerserker), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerBerserker), //orange invasion
        //        new Invasion(8, ZombieTypeEnum.WalkerBerserker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        86, //number
        //        new Invasion(1, ZombieTypeEnum.RunnerBerserker), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerBerserker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.FattyBerserker), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerBerserker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        87, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerBerserker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.FattyBerserker), //yellow invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerBerserker), //orange invasion
        //        new Invasion(3, ZombieTypeEnum.RunnerBerserker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        88, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerBerserker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.WalkerBerserker), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.FattyBerserker), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.WalkerBerserker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        89, //number
        //        new Invasion(1, ZombieTypeEnum.RunnerBerserker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.FattyBerserker), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerBerserker), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.RunnerBerserker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        90, //number
        //        new Invasion(1, ZombieTypeEnum.AbominationBerserker), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerBerserker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerBerserker), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerBerserker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        91, //number
        //        null, //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        92, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(6, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        93, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        94, //number
        //        new Invasion(2, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(2, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        95, //number
        //        null, //blue invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Fatty), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        96, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        97, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        98, //number
        //        new Invasion(2, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(2, ZombieTypeEnum.Fatty) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        99, //number
        //        null, //blue invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        100, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        101, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Fatty) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        102, //number
        //        new Invasion(1, ZombieTypeEnum.Fatty), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(2, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        103, //number
        //        null, //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        104, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Abomination), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        105, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        106, //number
        //        new Invasion(2, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(2, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        107, //number
        //        null, //blue invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Fatty), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        108, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        109, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        110, //number
        //        null, //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(2, ZombieTypeEnum.Fatty) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        111, //number
        //        null, //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Abomination), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        112, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        113, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Abomination) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        114, //number
        //        new Invasion(1, ZombieTypeEnum.Fatty), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(2, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        115, //number
        //        null, //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Walker) //red invasion
        //        )
        //        { IsSupplementaryActivation = true });

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        116, //number
        //        null, //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Walker) //red invasion
        //        )
        //    { IsSupplementaryActivation = true });

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        117, //number
        //        null, //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty) //red invasion
        //        )
        //    { IsSupplementaryActivation = true });

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        118, //number
        //        null, //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Runner) //red invasion
        //        )
        //    { IsSupplementaryActivation = true });

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        119, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Runner) //red invasion
        //        )
        //    { IsSewerInvasion = true });

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.PrisonOutBreak,
        //        120, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty) //red invasion
        //        )
        //    { IsSewerInvasion = true });
        //    #endregion

        //    #region Walk of the dead 2
        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead2,
        //        121, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(5, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(3, ZombieTypeEnum.Fatty) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead2,
        //        122, //number
        //        new Invasion(2, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead2,
        //        123, //number
        //        new Invasion(1, ZombieTypeEnum.Runner), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Fatty) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead2,
        //        124, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(5, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(6, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead2,
        //        125, //number
        //        new Invasion(2, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.Walker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead2,
        //        126, //number
        //        new Invasion(1, ZombieTypeEnum.Fatty), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Fatty), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.Runner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead2,
        //        127, //number
        //        null, //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Walker) //red invasion
        //        )
        //        {IsSupplementaryActivation = true});

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead2,
        //        128, //number
        //        null, //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Walker) //red invasion
        //        )
        //    { IsSupplementaryActivation = true });

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead2,
        //        129, //number
        //        null, //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty) //red invasion
        //        )
        //    { IsSupplementaryActivation = true });

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead2,
        //        130, //number
        //        null, //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Runner) //red invasion
        //        )
        //    { IsSupplementaryActivation = true });

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead2,
        //        131, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Runner) //red invasion
        //        )
        //    { IsSewerInvasion = true });

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.WalkOfTheDead2,
        //        132, //number
        //        new Invasion(1, ZombieTypeEnum.Walker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.Runner), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.Walker), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.Fatty) //red invasion
        //        )
        //    { IsSewerInvasion = true });
        //    #endregion

        //    #region Toxic crowd
        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ToxicCrowd,
        //        133, //number
        //        null, //blue invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerToxic), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerToxic), //orange invasion
        //        new Invasion(3, ZombieTypeEnum.RunnerToxic) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ToxicCrowd,
        //        134, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerToxic), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.RunnerToxic), //yellow invasion
        //        new Invasion(6, ZombieTypeEnum.WalkerToxic), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.WalkerToxic) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ToxicCrowd,
        //        135, //number
        //        new Invasion(2, ZombieTypeEnum.WalkerToxic), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerToxic), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.RunnerToxic), //orange invasion
        //        new Invasion(8, ZombieTypeEnum.WalkerToxic) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ToxicCrowd,
        //        136, //number
        //        null, //blue invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerToxic), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerToxic), //orange invasion
        //        new Invasion(3, ZombieTypeEnum.FattyToxic) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ToxicCrowd,
        //        137, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerToxic), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.FattyToxic), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.RunnerToxic), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.WalkerToxic) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.ToxicCrowd,
        //        138, //number
        //        new Invasion(1, ZombieTypeEnum.RunnerToxic), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerToxic), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.FattyToxic), //orange invasion
        //        new Invasion(8, ZombieTypeEnum.WalkerToxic) //red invasion
        //        ));
        //    #endregion

        //    #region Angry Zombie
        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.AngryZombies,
        //        139, //number
        //        null, //blue invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerBerserker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerBerserker), //orange invasion
        //        new Invasion(3, ZombieTypeEnum.RunnerBerserker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.AngryZombies,
        //        140, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerBerserker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.FattyBerserker), //yellow invasion
        //        new Invasion(6, ZombieTypeEnum.WalkerBerserker), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.WalkerBerserker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.AngryZombies,
        //        141, //number
        //        new Invasion(2, ZombieTypeEnum.WalkerBerserker), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerBerserker), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.FattyBerserker), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.RunnerBerserker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.AngryZombies,
        //        142, //number
        //        null, //blue invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerBerserker), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerBerserker), //orange invasion
        //        new Invasion(3, ZombieTypeEnum.FattyBerserker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.AngryZombies,
        //        143, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerBerserker), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.RunnerBerserker), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.RunnerBerserker), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.WalkerBerserker) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.AngryZombies,
        //        144, //number
        //        new Invasion(1, ZombieTypeEnum.RunnerBerserker), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerBerserker), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.FattyBerserker), //orange invasion
        //        new Invasion(8, ZombieTypeEnum.WalkerBerserker) //red invasion
        //        ));
        //    #endregion

        //    #region zombie card RueMorgue
        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        145, //number
        //        null, //blue invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerSkinner), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerSkinner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        146, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(6, ZombieTypeEnum.WalkerSkinner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        147, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.RunnerSkinner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.FattySkinner), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.RunnerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        148, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerSkinner), //orange invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        149, //number
        //        null, //blue invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.FattySkinner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        150, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.RunnerSkinner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        151, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.WalkerSkinner), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.RunnerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        152, //number
        //        new Invasion(2, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerSkinner), //orange invasion
        //        new Invasion(2, ZombieTypeEnum.FattySkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        153, //number
        //        null, //blue invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerSkinner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        154, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.RunnerSkinner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        155, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.RunnerSkinner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.RunnerSkinner), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.FattySkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        156, //number
        //        new Invasion(1, ZombieTypeEnum.FattySkinner), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerSkinner), //orange invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        157, //number
        //        null, //blue invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerSkinner), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerSkinner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        158, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(6, ZombieTypeEnum.WalkerSkinner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        159, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.RunnerSkinner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.FattySkinner), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.RunnerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        160, //number
        //        new Invasion(2, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerSkinner), //orange invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        161, //number
        //        null, //blue invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.FattySkinner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        162, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.RunnerSkinner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        163, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.WalkerSkinner), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.RunnerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        164, //number
        //        new Invasion(2, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerSkinner), //orange invasion
        //        new Invasion(2, ZombieTypeEnum.FattySkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        165, //number
        //        null, //blue invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerSkinner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        166, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.RunnerSkinner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        167, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.RunnerSkinner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.RunnerSkinner), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.FattySkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        168, //number
        //        new Invasion(1, ZombieTypeEnum.FattySkinner), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerSkinner), //orange invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        169, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerSkinner), //yellow invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerSkinner), //orange invasion
        //        new Invasion(3, ZombieTypeEnum.FattySkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        170, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.RunnerSkinner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        171, //number
        //        new Invasion(2, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerSkinner), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.FattySkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        172, //number
        //        new Invasion(2, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.ABombAbomination), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerSkinner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        173, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(4, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.ABombAbomination), //orange invasion
        //        new Invasion(6, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        174, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(6, ZombieTypeEnum.WalkerSkinner), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.ABombAbomination) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        175, //number
        //        new Invasion(1, ZombieTypeEnum.RunnerSkinner), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.RunnerSkinner), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerSkinner), //orange invasion
        //        new Invasion(8, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        176, //number
        //        new Invasion(1, ZombieTypeEnum.FattySkinner), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.FattySkinner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        177, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerSkinner), //yellow invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerSkinner), //orange invasion
        //        new Invasion(3, ZombieTypeEnum.RunnerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        178, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.RunnerSkinner), //orange invasion
        //        new Invasion(7, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        179, //number
        //        new Invasion(1, ZombieTypeEnum.RunnerSkinner), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.FattySkinner), //yellow invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerSkinner), //orange invasion
        //        new Invasion(4, ZombieTypeEnum.RunnerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        180, //number
        //        new Invasion(1, ZombieTypeEnum.ABombAbomination), //blue invasion
        //        new Invasion(3, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.RunnerSkinner), //orange invasion
        //        new Invasion(5, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        ));

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        181, //number              
        //        null, //blue invasion
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        )
        //    { IsSupplementaryActivation = true });

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        182, //number              
        //        null, //blue invasion
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner) //red invasion
        //        )
        //    { IsSupplementaryActivation = true });

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        183, //number              
        //        null, //blue invasion
        //        new Invasion(1, ZombieTypeEnum.FattySkinner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.FattySkinner), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.FattySkinner) //red invasion
        //        )
        //    { IsSupplementaryActivation = true });

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        184, //number              
        //        null, //blue invasion
        //        new Invasion(1, ZombieTypeEnum.RunnerSkinner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.RunnerSkinner), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.RunnerSkinner) //red invasion
        //        )
        //    { IsSupplementaryActivation = true });

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        185, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(2, ZombieTypeEnum.WalkerSkinner), //yellow invasion
        //        new Invasion(1, ZombieTypeEnum.FattySkinner), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.RunnerSkinner) //red invasion
        //        )
        //    { IsSewerInvasion = true });

        //    list.Add(new ZombieCardDto(
        //        ZombicideGameEnum.RueMorgue,
        //        186, //number
        //        new Invasion(1, ZombieTypeEnum.WalkerSkinner), //blue invasion
        //        new Invasion(1, ZombieTypeEnum.RunnerSkinner), //yellow invasion
        //        new Invasion(2, ZombieTypeEnum.WalkerSkinner), //orange invasion
        //        new Invasion(1, ZombieTypeEnum.FattySkinner) //red invasion
        //        )
        //    { IsSewerInvasion = true });

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.RueMorgue,
        //       187, //number
        //       new Invasion(1, ZombieTypeEnum.Crawler), //blue invasion
        //       new Invasion(1, ZombieTypeEnum.Crawler), //yellow invasion
        //       new Invasion(2, ZombieTypeEnum.Crawler), //orange invasion
        //       new Invasion(1, ZombieTypeEnum.Crawler) //red invasion
        //       )
        //    { IsBlueBedInvasion = true });

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.RueMorgue,
        //       188, //number
        //       new Invasion(1, ZombieTypeEnum.Crawler), //blue invasion
        //       new Invasion(1, ZombieTypeEnum.Crawler), //yellow invasion
        //       new Invasion(2, ZombieTypeEnum.Crawler), //orange invasion
        //       new Invasion(1, ZombieTypeEnum.Crawler) //red invasion
        //       )
        //    { IsBlueBedInvasion = true });

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.RueMorgue,
        //       189, //number
        //       new Invasion(1, ZombieTypeEnum.Crawler), //blue invasion
        //       new Invasion(1, ZombieTypeEnum.Crawler), //yellow invasion
        //       new Invasion(2, ZombieTypeEnum.Crawler), //orange invasion
        //       new Invasion(1, ZombieTypeEnum.Crawler) //red invasion
        //       )
        //    { IsBlueBedInvasion = true });

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.RueMorgue,
        //       190, //number
        //       new Invasion(1, ZombieTypeEnum.Crawler), //blue invasion
        //       new Invasion(1, ZombieTypeEnum.Crawler), //yellow invasion
        //       new Invasion(2, ZombieTypeEnum.Crawler), //orange invasion
        //       new Invasion(1, ZombieTypeEnum.Crawler) //red invasion
        //       )
        //    { IsGreenBedInvasion = true });

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.RueMorgue,
        //       191, //number
        //       new Invasion(1, ZombieTypeEnum.Crawler), //blue invasion
        //       new Invasion(1, ZombieTypeEnum.Crawler), //yellow invasion
        //       new Invasion(2, ZombieTypeEnum.Crawler), //orange invasion
        //       new Invasion(1, ZombieTypeEnum.Crawler) //red invasion
        //       )
        //    { IsGreenBedInvasion = true });

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.RueMorgue,
        //       192, //number
        //       new Invasion(1, ZombieTypeEnum.Crawler), //blue invasion
        //       new Invasion(1, ZombieTypeEnum.Crawler), //yellow invasion
        //       new Invasion(2, ZombieTypeEnum.Crawler), //orange invasion
        //       new Invasion(1, ZombieTypeEnum.Crawler) //red invasion
        //       )
        //    { IsGreenBedInvasion = true });
        //    #endregion

        //    #region Angry Neighbours
        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.AngryNeighbors,
        //       193, //number
        //       new Invasion(1, ZombieTypeEnum.Seeker), //blue invasion
        //       new Invasion(2, ZombieTypeEnum.Seeker), //yellow invasion
        //       new Invasion(3, ZombieTypeEnum.Seeker), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.Seeker) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.AngryNeighbors,
        //       194, //number
        //       new Invasion(1, ZombieTypeEnum.Seeker), //blue invasion
        //       new Invasion(2, ZombieTypeEnum.Seeker), //yellow invasion
        //       new Invasion(3, ZombieTypeEnum.Seeker), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.Seeker) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.AngryNeighbors,
        //       195, //number
        //       new Invasion(1, ZombieTypeEnum.Seeker), //blue invasion
        //       new Invasion(2, ZombieTypeEnum.Seeker), //yellow invasion
        //       new Invasion(3, ZombieTypeEnum.Seeker), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.Seeker) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.AngryNeighbors,
        //       196, //number
        //       new Invasion(1, ZombieTypeEnum.Seeker), //blue invasion
        //       new Invasion(2, ZombieTypeEnum.Seeker), //yellow invasion
        //       new Invasion(3, ZombieTypeEnum.Seeker), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.Seeker) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.AngryNeighbors,
        //       197, //number
        //       new Invasion(1, ZombieTypeEnum.Seeker), //blue invasion
        //       new Invasion(2, ZombieTypeEnum.Seeker), //yellow invasion
        //       new Invasion(3, ZombieTypeEnum.Seeker), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.Seeker) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.AngryNeighbors,
        //       198, //number
        //       new Invasion(1, ZombieTypeEnum.Seeker), //blue invasion
        //       new Invasion(2, ZombieTypeEnum.Seeker), //yellow invasion
        //       new Invasion(3, ZombieTypeEnum.Seeker), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.Seeker) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.AngryNeighbors,
        //       199, //number
        //       new Invasion(1, ZombieTypeEnum.Seeker), //blue invasion
        //       new Invasion(2, ZombieTypeEnum.Seeker), //yellow invasion
        //       new Invasion(3, ZombieTypeEnum.Seeker), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.Seeker) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.AngryNeighbors,
        //       200, //number
        //       new Invasion(1, ZombieTypeEnum.Seeker), //blue invasion
        //       new Invasion(2, ZombieTypeEnum.Seeker), //yellow invasion
        //       new Invasion(3, ZombieTypeEnum.Seeker), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.Seeker) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.AngryNeighbors,
        //       201, //number
        //       new Invasion(1, ZombieTypeEnum.Seeker), //blue invasion
        //       new Invasion(2, ZombieTypeEnum.Seeker), //yellow invasion
        //       new Invasion(3, ZombieTypeEnum.Seeker), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.Seeker) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.AngryNeighbors,
        //       202, //number
        //       new Invasion(1, ZombieTypeEnum.Seeker), //blue invasion
        //       new Invasion(2, ZombieTypeEnum.Seeker), //yellow invasion
        //       new Invasion(3, ZombieTypeEnum.Seeker), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.Seeker) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.AngryNeighbors,
        //       203, //number
        //       new Invasion(1, ZombieTypeEnum.Seeker), //blue invasion
        //       new Invasion(2, ZombieTypeEnum.Seeker), //yellow invasion
        //       new Invasion(3, ZombieTypeEnum.Seeker), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.Seeker) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.AngryNeighbors,
        //       204, //number
        //       new Invasion(1, ZombieTypeEnum.Seeker), //blue invasion
        //       new Invasion(2, ZombieTypeEnum.Seeker), //yellow invasion
        //       new Invasion(3, ZombieTypeEnum.Seeker), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.Seeker) //red invasion
        //       ));
        //    #endregion

        //    #region Lost Zombivors
        //    //list.Add(new ZombieCardDto(
        //    //   ZombicideGameEnum.LostZombivors,
        //    //   205, //number
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor), //blue invasion
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor), //yellow invasion
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor), //orange invasion
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor) //red invasion
        //    //   ));

        //    //list.Add(new ZombieCardDto(
        //    //   ZombicideGameEnum.LostZombivors,
        //    //   206, //number
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor), //blue invasion
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor), //yellow invasion
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor), //orange invasion
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor) //red invasion
        //    //   ));

        //    //list.Add(new ZombieCardDto(
        //    //   ZombicideGameEnum.LostZombivors,
        //    //   207, //number
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor), //blue invasion
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor), //yellow invasion
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor), //orange invasion
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor) //red invasion
        //    //   ));

        //    //list.Add(new ZombieCardDto(
        //    //   ZombicideGameEnum.LostZombivors,
        //    //   208, //number
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor), //blue invasion
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor), //yellow invasion
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor), //orange invasion
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor) //red invasion
        //    //   ));

        //    //list.Add(new ZombieCardDto(
        //    //   ZombicideGameEnum.LostZombivors,
        //    //   209, //number
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor), //blue invasion
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor), //yellow invasion
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor), //orange invasion
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor) //red invasion
        //    //   ));

        //    //list.Add(new ZombieCardDto(
        //    //   ZombicideGameEnum.LostZombivors,
        //    //   210, //number
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor), //blue invasion
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor), //yellow invasion
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor), //orange invasion
        //    //   new Invasion(1, ZombieTypeEnum.LostZombivor) //red invasion
        //    //   ));
        //    #endregion

        //    #region VIP1
        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip1,
        //       211, //number
        //       null, //blue invasion
        //       new Invasion(4, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip1,
        //       212, //number
        //       new Invasion(1, ZombieTypeEnum.VIP), //blue invasion
        //       new Invasion(1, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(6, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(7, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip1,
        //       213, //number
        //       new Invasion(1, ZombieTypeEnum.VIP), //blue invasion
        //       new Invasion(2, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(2, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(8, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip1,
        //       214, //number
        //       new Invasion(2, ZombieTypeEnum.VIP), //blue invasion
        //       new Invasion(3, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip1,
        //       215, //number
        //       null, //blue invasion
        //       new Invasion(4, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(5, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip1,
        //       216, //number
        //       new Invasion(1, ZombieTypeEnum.VIP), //blue invasion
        //       new Invasion(1, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(6, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(7, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip1,
        //       217, //number
        //       new Invasion(1, ZombieTypeEnum.VIP), //blue invasion
        //       new Invasion(2, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(2, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(8, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip1,
        //       218, //number
        //       new Invasion(2, ZombieTypeEnum.VIP), //blue invasion
        //       new Invasion(3, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip1,
        //       219, //number
        //       null, //blue invasion
        //       new Invasion(4, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(5, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip1,
        //       220, //number
        //       new Invasion(1, ZombieTypeEnum.VIP), //blue invasion
        //       new Invasion(1, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(6, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(7, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip1,
        //       221, //number
        //       new Invasion(1, ZombieTypeEnum.VIP), //blue invasion
        //       new Invasion(2, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(2, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(8, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip1,
        //       222, //number
        //       new Invasion(2, ZombieTypeEnum.VIP), //blue invasion
        //       new Invasion(3, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.VIP) //red invasion
        //       ));
        //    #endregion

        //    #region VIP2
        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip2,
        //       223, //number
        //       null, //blue invasion
        //       new Invasion(4, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip2,
        //       224, //number
        //       new Invasion(1, ZombieTypeEnum.VIP), //blue invasion
        //       new Invasion(1, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(6, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(7, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip2,
        //       225, //number
        //       new Invasion(1, ZombieTypeEnum.VIP), //blue invasion
        //       new Invasion(2, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(2, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(8, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip2,
        //       226, //number
        //       new Invasion(2, ZombieTypeEnum.VIP), //blue invasion
        //       new Invasion(3, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip2,
        //       227, //number
        //       null, //blue invasion
        //       new Invasion(4, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(5, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip2,
        //       228, //number
        //       new Invasion(1, ZombieTypeEnum.VIP), //blue invasion
        //       new Invasion(1, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(6, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(7, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip2,
        //       229, //number
        //       new Invasion(1, ZombieTypeEnum.VIP), //blue invasion
        //       new Invasion(2, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(2, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(8, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip2,
        //       230, //number
        //       new Invasion(2, ZombieTypeEnum.VIP), //blue invasion
        //       new Invasion(3, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip2,
        //       231, //number
        //       null, //blue invasion
        //       new Invasion(4, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(5, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip2,
        //       232, //number
        //       new Invasion(1, ZombieTypeEnum.VIP), //blue invasion
        //       new Invasion(1, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(6, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(7, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip2,
        //       233, //number
        //       new Invasion(1, ZombieTypeEnum.VIP), //blue invasion
        //       new Invasion(2, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(2, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(8, ZombieTypeEnum.VIP) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Vip2,
        //       234, //number
        //       new Invasion(2, ZombieTypeEnum.VIP), //blue invasion
        //       new Invasion(3, ZombieTypeEnum.VIP), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.VIP), //orange invasion
        //       new Invasion(4, ZombieTypeEnum.VIP) //red invasion
        //       ));
        //    #endregion

        //    #region Murder of the crowz
        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Crowz,
        //       235, //number
        //       new Invasion(2, ZombieTypeEnum.Crowz), //blue invasion
        //       new Invasion(3, ZombieTypeEnum.Crowz), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.Crowz), //orange invasion
        //       new Invasion(5, ZombieTypeEnum.Crowz) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Crowz,
        //       236, //number
        //       new Invasion(2, ZombieTypeEnum.Crowz), //blue invasion
        //       new Invasion(3, ZombieTypeEnum.Crowz), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.Crowz), //orange invasion
        //       new Invasion(5, ZombieTypeEnum.Crowz) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Crowz,
        //       237, //number
        //       new Invasion(2, ZombieTypeEnum.Crowz), //blue invasion
        //       new Invasion(3, ZombieTypeEnum.Crowz), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.Crowz), //orange invasion
        //       new Invasion(5, ZombieTypeEnum.Crowz) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Crowz,
        //       238, //number
        //       new Invasion(2, ZombieTypeEnum.Crowz), //blue invasion
        //       new Invasion(3, ZombieTypeEnum.Crowz), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.Crowz), //orange invasion
        //       new Invasion(5, ZombieTypeEnum.Crowz) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Crowz,
        //       239, //number
        //       new Invasion(2, ZombieTypeEnum.Crowz), //blue invasion
        //       new Invasion(3, ZombieTypeEnum.Crowz), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.Crowz), //orange invasion
        //       new Invasion(5, ZombieTypeEnum.Crowz) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Crowz,
        //       240, //number
        //       new Invasion(2, ZombieTypeEnum.Crowz), //blue invasion
        //       new Invasion(3, ZombieTypeEnum.Crowz), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.Crowz), //orange invasion
        //       new Invasion(5, ZombieTypeEnum.Crowz) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Crowz,
        //       241, //number
        //       new Invasion(2, ZombieTypeEnum.Crowz), //blue invasion
        //       new Invasion(3, ZombieTypeEnum.Crowz), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.Crowz), //orange invasion
        //       new Invasion(5, ZombieTypeEnum.Crowz) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Crowz,
        //       242, //number
        //       new Invasion(2, ZombieTypeEnum.Crowz), //blue invasion
        //       new Invasion(3, ZombieTypeEnum.Crowz), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.Crowz), //orange invasion
        //       new Invasion(5, ZombieTypeEnum.Crowz) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Crowz,
        //       243, //number
        //       new Invasion(2, ZombieTypeEnum.Crowz), //blue invasion
        //       new Invasion(3, ZombieTypeEnum.Crowz), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.Crowz), //orange invasion
        //       new Invasion(5, ZombieTypeEnum.Crowz) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Crowz,
        //       244, //number
        //       new Invasion(2, ZombieTypeEnum.Crowz), //blue invasion
        //       new Invasion(3, ZombieTypeEnum.Crowz), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.Crowz), //orange invasion
        //       new Invasion(5, ZombieTypeEnum.Crowz) //red invasion
        //       ));

        //    list.Add(new ZombieCardDto(
        //       ZombicideGameEnum.Crowz,
        //       245, //number
        //       new Invasion(2, ZombieTypeEnum.Crowz), //blue invasion
        //       new Invasion(3, ZombieTypeEnum.Crowz), //yellow invasion
        //       new Invasion(4, ZombieTypeEnum.Crowz), //orange invasion
        //       new Invasion(5, ZombieTypeEnum.Crowz) //red invasion
        //       ));
        //    #endregion

        //    return list;
        //}

        //private List<EquipmentDto> CreateAllEquipmentCard()
        //{
        //    var list = new List<EquipmentDto>();

        //    #region Season 1
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 1, TranslationsService.AAAH, TranslationsService.AAAA_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 2, TranslationsService.AAAH, TranslationsService.AAAA_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 3, TranslationsService.AAAH, TranslationsService.AAAA_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 4, TranslationsService.AAAH, TranslationsService.AAAA_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 5, TranslationsService.RICE, null));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 6, TranslationsService.RICE, null));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 7, TranslationsService.RICE, null));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 8, TranslationsService.FOOD, null));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 9, TranslationsService.FOOD, null));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 10, TranslationsService.FOOD, null));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 11, TranslationsService.FLASHLIGHT, TranslationsService.FLASHLIGHT_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 12, TranslationsService.FLASHLIGHT, TranslationsService.FLASHLIGHT_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 13, TranslationsService.GASOLINE, TranslationsService.GASOLINE_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 14, TranslationsService.GASOLINE, TranslationsService.GASOLINE_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 15, TranslationsService.GLASSBOTTLE, TranslationsService.GLASSBOTTLE_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 16, TranslationsService.GLASSBOTTLE, TranslationsService.GLASSBOTTLE_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 17, TranslationsService.GOALIEMASK, TranslationsService.GOALIEMASK_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 18, TranslationsService.PLENTY_AMMO_BULLET, TranslationsService.PLENTY_AMMO_BULLET_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 19, TranslationsService.PLENTY_AMMO_BULLET, TranslationsService.PLENTY_AMMO_BULLET_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 20, TranslationsService.PLENTY_AMMO_BULLET, TranslationsService.PLENTY_AMMO_BULLET_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 21, TranslationsService.PLENTY_AMMO_SHOTGUN, TranslationsService.PLENTY_AMMO_SHOTGUN_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 22, TranslationsService.PLENTY_AMMO_SHOTGUN, TranslationsService.PLENTY_AMMO_SHOTGUN_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 23, TranslationsService.PLENTY_AMMO_SHOTGUN, TranslationsService.PLENTY_AMMO_SHOTGUN_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 24, TranslationsService.SCOPE, TranslationsService.SCOPE_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 25, TranslationsService.SCOPE, TranslationsService.SCOPE_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 26, TranslationsService.WATER, null));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 27, TranslationsService.WATER, null));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.Season1, 28, TranslationsService.WATER, null));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.Season1, 29, TranslationsService.BASEBALL_BAT, null, 1, 3, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.Season1, 30, TranslationsService.BASEBALL_BAT, null, 1, 3, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.Season1, 31, TranslationsService.CHAINSAW, null, 5, 5, 2, true, false, false, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.Season1, 32, TranslationsService.CHAINSAW, null, 5, 5, 2, true, false, false, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.Season1, 33, TranslationsService.KATANA, null, 2, 4, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.Season1, 34, TranslationsService.KATANA, null, 2, 4, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.Season1, 35, TranslationsService.MACHETE, null, 1, 4, 2, false, false, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.Season1, 36, TranslationsService.MACHETE, null, 1, 4, 2, false, false, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.Season1, 37, TranslationsService.MACHETE, null, 1, 4, 2, false, false, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.Season1, 38, TranslationsService.MACHETE, null, 1, 4, 2, false, false, true, true));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Season1, 39, TranslationsService.PISTOL, null, 0, 1, 1, 4, 1, false, false, false, true));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Season1, 40, TranslationsService.PISTOL, null, 0, 1, 1, 4, 1, false, false, false, true));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Season1, 41, TranslationsService.PISTOL, null, 0, 1, 1, 4, 1, false, false, false, true));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Season1, 42, TranslationsService.RIFLE, null, 1, 3, 1, 3, 1, false, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Season1, 43, TranslationsService.RIFLE, null, 1, 3, 1, 3, 1, false, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Season1, 44, TranslationsService.SAWED_OFF, null, 0, 1, 2, 3, 1, false, false, false, true) { HasToReload = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Season1, 45, TranslationsService.SAWED_OFF, null, 0, 1, 2, 3, 1, false, false, false, true) { HasToReload = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Season1, 46, TranslationsService.SAWED_OFF, null, 0, 1, 2, 3, 1, false, false, false, true) { HasToReload = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Season1, 47, TranslationsService.SAWED_OFF, null, 0, 1, 2, 3, 1, false, false, false, true) { HasToReload = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Season1, 48, TranslationsService.SHOTGUN, null, 0, 1, 2, 4, 2, false, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Season1, 49, TranslationsService.SHOTGUN, null, 0, 1, 2, 4, 2, false, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Season1, 50, TranslationsService.SUBMG, null, 0, 1, 3, 5, 1, false, false, false, true));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Season1, 51, TranslationsService.SUBMG, null, 0, 1, 3, 5, 1, false, false, false, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.Season1, 52, TranslationsService.PAN, null, 1, 6, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.Season1, 53, TranslationsService.PAN, null, 1, 6, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.Season1, 54, TranslationsService.PAN, null, 1, 6, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.Season1, 55, TranslationsService.CROWBAR, null, 1, 4, 1, true, true, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.Season1, 56, TranslationsService.CROWBAR, null, 1, 4, 1, true, true, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.Season1, 57, TranslationsService.FIREAXE, null, 1, 4, 2, true, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.Season1, 58, TranslationsService.FIREAXE, null, 1, 4, 2, true, false, true, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Season1, 59, TranslationsService.MOLOTOV, null, 0, 1, null, null, 10, false, false, false, false) { InDeck = false });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Season1, 60, TranslationsService.MOLOTOV, null, 0, 1, null, null, 10, false, false, false, false) { InDeck = false });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Season1, 61, TranslationsService.EVILTWIN, null, 0, 1, 2, 4, 1, false, false, false, false) { InDeck = false, IsPimpWeapon = true });
        //    list.Add(new MixWeaponDto(ZombicideGameEnum.Season1, 62, TranslationsService.MA_SHOTGUN, null, 0, 1, 1, 2, 3, 2, false, false, true, false, false) { InDeck = false, IsPimpWeapon = true });
        //    #endregion

        //    #region Toxic city mall
        //    list.Add(new EquipmentDto(ZombicideGameEnum.ToxicCityMall, 63, TranslationsService.COOKIES, TranslationsService.COOKIES_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.ToxicCityMall, 64, TranslationsService.COOKIES, TranslationsService.COOKIES_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.ToxicCityMall, 65, TranslationsService.GASMASK, TranslationsService.GASMASK_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.ToxicCityMall, 66, TranslationsService.GASMASK, TranslationsService.GASMASK_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.ToxicCityMall, 67, TranslationsService.HOLLOW_POINT_ROUNDS, TranslationsService.HOLLOW_POINT_ROUNDS_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.ToxicCityMall, 68, TranslationsService.HOLLOW_POINT_ROUNDS, TranslationsService.HOLLOW_POINT_ROUNDS_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.ToxicCityMall, 69, TranslationsService.LASER_POINTER, TranslationsService.LASER_POINTER_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.ToxicCityMall, 70, TranslationsService.LASER_POINTER, TranslationsService.LASER_POINTER_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.ToxicCityMall, 71, TranslationsService.LASER_POINTER, TranslationsService.LASER_POINTER_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.ToxicCityMall, 72, TranslationsService.LASER_POINTER, TranslationsService.LASER_POINTER_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.ToxicCityMall, 73, TranslationsService.SPARE_CHANGE, TranslationsService.SPARE_CHANGE_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.ToxicCityMall, 74, TranslationsService.SPARE_CHANGE, TranslationsService.SPARE_CHANGE_DESCRIPTION));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.ToxicCityMall, 75, TranslationsService.MAGNUM44, null, 0, 1, 1, 4, 2, false, false, false, true));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.ToxicCityMall, 76, TranslationsService.MAGNUM44, null, 0, 1, 1, 4, 2, false, false, false, true));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.ToxicCityMall, 77, TranslationsService.ASSAULT_RIFLE, null, 1, 2, 3, 4, 1, false, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.ToxicCityMall, 78, TranslationsService.ASSAULT_RIFLE, null, 1, 2, 3, 4, 1, false, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.ToxicCityMall, 79, TranslationsService.FLAMETHROWER, TranslationsService.FLAMETHROWER_DESCRIPTION, 0, 1, null, null, 10, false, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.ToxicCityMall, 80, TranslationsService.PAS_GUN, null, 0, 1, 1, 4, 3, false, false, false, false) { InDeck = false, IsPimpWeapon = true });
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.ToxicCityMall, 81, TranslationsService.PAN, null, 1, 6, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.ToxicCityMall, 82, TranslationsService.PAN, null, 1, 6, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.ToxicCityMall, 83, TranslationsService.PAN, null, 1, 6, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.ToxicCityMall, 84, TranslationsService.PAN, null, 1, 6, 1, false, false, true, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.ToxicCityMall, 85, TranslationsService.SPECIAL911, null, 0, 2, 5, 3, 1, false, false, false, false) { InDeck = false, IsUltraRedWeapon = true });
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.ToxicCityMall, 86, TranslationsService.BETTY, null, 7, 4, 2, true, false, false, false) { InDeck = false, IsUltraRedWeapon = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.ToxicCityMall, 87, TranslationsService.DOUGS_DREAM, null, 0, 1, 8, 4, 1, false, false, false, false) { InDeck = false, IsUltraRedWeapon = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.ToxicCityMall, 88, TranslationsService.JACK_JILL, null, 0, 1, 6, 3, 2, false, false, false, false) { InDeck = false, IsUltraRedWeapon = true, HasToReload = true });
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.ToxicCityMall, 89, TranslationsService.NEDS_FLASHLIGHT, null, 5, 4, 3, true, false, false, false) { InDeck = false, IsUltraRedWeapon = true });
        //    list.Add(new MixWeaponDto(ZombicideGameEnum.ToxicCityMall, 90, TranslationsService.SWEET_SISTERS, null, 0, 1, 6, 4, 3, 2, false, false, true, false, false) { InDeck = false, IsUltraRedWeapon = true });
        //    #endregion

        //    #region Prison outbreak
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 91, TranslationsService.NAILS, TranslationsService.NAILS_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 92, TranslationsService.NAILS, TranslationsService.NAILS_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 93, TranslationsService.RIOT_SHIELD, TranslationsService.RIOT_SHIELD_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 94, TranslationsService.RIOT_SHIELD, TranslationsService.RIOT_SHIELD_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 95, TranslationsService.AAAH, TranslationsService.AAAA_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 96, TranslationsService.AAAH, TranslationsService.AAAA_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 97, TranslationsService.AAAH, TranslationsService.AAAA_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 98, TranslationsService.AAAH, TranslationsService.AAAA_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 99, TranslationsService.RICE, null));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 100, TranslationsService.RICE, null));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 101, TranslationsService.RICE, null));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 102, TranslationsService.FOOD, null));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 103, TranslationsService.FOOD, null));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 104, TranslationsService.FOOD, null));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 105, TranslationsService.WATER, null));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 106, TranslationsService.WATER, null));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 107, TranslationsService.WATER, null));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 108, TranslationsService.BASEBALL_BAT, null, 1, 3, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 109, TranslationsService.BASEBALL_BAT, null, 1, 3, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 110, TranslationsService.CHAINSAW, null, 5, 5, 2, true, false, false, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 111, TranslationsService.CHAINSAW, null, 5, 5, 2, true, false, false, false));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 112, TranslationsService.FLASHLIGHT, TranslationsService.FLASHLIGHT_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 113, TranslationsService.FLASHLIGHT, TranslationsService.FLASHLIGHT_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 114, TranslationsService.GASOLINE, TranslationsService.GASOLINE_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 115, TranslationsService.GASOLINE, TranslationsService.GASOLINE_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 116, TranslationsService.GLASSBOTTLE, TranslationsService.GLASSBOTTLE_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 117, TranslationsService.GLASSBOTTLE, TranslationsService.GLASSBOTTLE_DESCRIPTION));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 118, TranslationsService.KATANA, null, 2, 4, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 119, TranslationsService.KATANA, null, 2, 4, 1, false, false, true, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 120, TranslationsService.PISTOL, null, 0, 1, 1, 4, 1, false, false, false, true));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 121, TranslationsService.PISTOL, null, 0, 1, 1, 4, 1, false, false, false, true));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 122, TranslationsService.PISTOL, null, 0, 1, 1, 4, 1, false, false, false, true));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 123, TranslationsService.PISTOL, null, 0, 1, 1, 4, 1, false, false, false, true));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 124, TranslationsService.PISTOL, null, 0, 1, 1, 4, 1, false, false, false, true));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 125, TranslationsService.PISTOL, null, 0, 1, 1, 4, 1, false, false, false, true));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 126, TranslationsService.PLENTY_AMMO_BULLET, TranslationsService.PLENTY_AMMO_BULLET_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 127, TranslationsService.PLENTY_AMMO_BULLET, TranslationsService.PLENTY_AMMO_BULLET_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 128, TranslationsService.PLENTY_AMMO_BULLET, TranslationsService.PLENTY_AMMO_BULLET_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 129, TranslationsService.PLENTY_AMMO_SHOTGUN, TranslationsService.PLENTY_AMMO_SHOTGUN_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 130, TranslationsService.PLENTY_AMMO_SHOTGUN, TranslationsService.PLENTY_AMMO_SHOTGUN_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 131, TranslationsService.PLENTY_AMMO_SHOTGUN, TranslationsService.PLENTY_AMMO_SHOTGUN_DESCRIPTION));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 132, TranslationsService.RIFLE, null, 1, 3, 1, 3, 1, false, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 133, TranslationsService.RIFLE, null, 1, 3, 1, 3, 1, false, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 134, TranslationsService.SAWED_OFF, null, 0, 1, 2, 3, 1, false, false, false, true) { HasToReload = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 135, TranslationsService.SAWED_OFF, null, 0, 1, 2, 3, 1, false, false, false, true) { HasToReload = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 136, TranslationsService.SAWED_OFF, null, 0, 1, 2, 3, 1, false, false, false, true) { HasToReload = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 137, TranslationsService.SAWED_OFF, null, 0, 1, 2, 3, 1, false, false, false, true) { HasToReload = true });
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 138, TranslationsService.SCOPE, TranslationsService.SCOPE_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.PrisonOutBreak, 139, TranslationsService.SCOPE, TranslationsService.SCOPE_DESCRIPTION));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 140, TranslationsService.SHOTGUN, null, 0, 1, 2, 4, 2, false, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 141, TranslationsService.SHOTGUN, null, 0, 1, 2, 4, 2, false, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 142, TranslationsService.SUBMG, null, 0, 1, 3, 5, 1, false, false, false, true));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 143, TranslationsService.SUBMG, null, 0, 1, 3, 5, 1, false, false, false, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 144, TranslationsService.FIREAXE, null, 1, 4, 2, true, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 145, TranslationsService.FIREAXE, null, 1, 4, 2, true, false, true, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 146, TranslationsService.MOLOTOV, null, 0, 1, null, null, 10, false, false, false, false) { InDeck = false });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 147, TranslationsService.MOLOTOV, null, 0, 1, null, null, 10, false, false, false, false) { InDeck = false });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 148, TranslationsService.AUTOMATIC_SHOTGUN, null, 0, 1, 3, 4, 2, false, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.PrisonOutBreak, 149, TranslationsService.AUTOMATIC_SHOTGUN, null, 0, 1, 3, 4, 2, false, false, false, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 150, TranslationsService.CONCRETE_SAW, null, 3, 5, 3, true, false, false, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 151, TranslationsService.HATCHET, null, 1, 3, 1, false, false, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 152, TranslationsService.HATCHET, null, 1, 3, 1, false, false, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 153, TranslationsService.HATCHET, null, 1, 3, 1, false, false, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 154, TranslationsService.HATCHET, null, 1, 3, 1, false, false, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 155, TranslationsService.KUKRI, null, 1, 4, 1, false, false, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 156, TranslationsService.KUKRI, null, 1, 4, 1, false, false, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 157, TranslationsService.KUKRI, null, 1, 4, 1, false, false, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 158, TranslationsService.KUKRI, null, 1, 4, 1, false, false, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 159, TranslationsService.MEAT_CLEAVER, null, 1, 3, 2, false, false, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 160, TranslationsService.MEAT_CLEAVER, null, 1, 3, 2, false, false, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 161, TranslationsService.WAKIZACHI, TranslationsService.WAKIZACHI_DESCRIPTION, 1, 4, 1, false, false, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 162, TranslationsService.WAKIZACHI, TranslationsService.WAKIZACHI_DESCRIPTION, 1, 4, 1, false, false, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 163, TranslationsService.CLAW_HAMMER, null, 3, 5, 1, true, true, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 164, TranslationsService.CLAW_HAMMER, null, 3, 5, 1, true, true, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 165, TranslationsService.CLAW_HAMMER, null, 3, 5, 1, true, true, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 166, TranslationsService.CLAW_HAMMER, null, 3, 5, 1, true, true, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 167, TranslationsService.NIGHT_STICK, TranslationsService.NIGHT_STICK_DESCRIPTION, 1, 4, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 168, TranslationsService.NIGHT_STICK, TranslationsService.NIGHT_STICK_DESCRIPTION, 1, 4, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 169, TranslationsService.NIGHT_STICK, TranslationsService.NIGHT_STICK_DESCRIPTION, 1, 4, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 170, TranslationsService.NAILBAT, null, 2, 3, 2, false, false, true, false) { InDeck = false });
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.PrisonOutBreak, 171, TranslationsService.NAILBAT, null, 2, 3, 2, false, false, true, false) { InDeck = false });
        //    list.Add(new MixWeaponDto(ZombicideGameEnum.PrisonOutBreak, 172, TranslationsService.GUNBLADE, null, 0, 1, 2, 1, 4, 2, false, false, true, false, false) { InDeck = false, IsPimpWeapon = true });
        //    list.Add(new MixWeaponDto(ZombicideGameEnum.PrisonOutBreak, 173, TranslationsService.GUNBLADE, null, 0, 1, 2, 1, 4, 2, false, false, true, false, false) { InDeck = false, IsPimpWeapon = true });
        //    #endregion

        //    #region VIP1
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.Vip1, 174, TranslationsService.DAISHO, null, 4, 4, 1, false, false, true, false) { InDeck = false, IsPimpWeapon = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Vip1, 175, TranslationsService.GOLDEN_AK47, null, 1, 2, 2, 4, 2, false, false, false, false) { InDeck = false, IsPimpWeapon = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Vip1, 176, TranslationsService.PINK_M4, null, 1, 2, 3, 4, 1, false, false, false, false) { InDeck = false, IsPimpWeapon = true });
        //    #endregion

        //    #region VIP2
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Vip2, 177, TranslationsService.SPAS12, null, 0, 1, 3, 4, 2, false, false, false, false) { InDeck = false, IsPimpWeapon = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Vip2, 178, TranslationsService.DESERT_EAGLE, null, 0, 1, 1, 4, 2, false, false, false, false) { InDeck = false, IsPimpWeapon = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.Vip2, 179, TranslationsService.THOMPSON, null, 0, 1, 5, 3, 1, false, false, false, false) { InDeck = false, IsPimpWeapon = true });
        //    #endregion

        //    #region Rue Morgue
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 180, TranslationsService.AAAH, TranslationsService.AAAA_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 181, TranslationsService.AAAH, TranslationsService.AAAA_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 182, TranslationsService.AAAH, TranslationsService.AAAA_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 183, TranslationsService.AAAH, TranslationsService.AAAA_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 184, TranslationsService.AAAH, TranslationsService.AAAA_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 185, TranslationsService.AAAH, TranslationsService.AAAA_DESCRIPTION));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 186, TranslationsService.AK47, null, 1, 2, 2, 4, 2, false, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 187, TranslationsService.AK47, null, 1, 2, 2, 4, 2, false, false, false, false));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 188, TranslationsService.BULLETPROOF_VEST, TranslationsService.BULLETPROOF_VEST_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 189, TranslationsService.BULLETPROOF_VEST, TranslationsService.BULLETPROOF_VEST_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 190, TranslationsService.BULLETPROOF_VEST, TranslationsService.BULLETPROOF_VEST_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 191, TranslationsService.BULLETPROOF_VEST, TranslationsService.BULLETPROOF_VEST_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 192, TranslationsService.BULLETPROOF_VEST, TranslationsService.BULLETPROOF_VEST_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 193, TranslationsService.BULLETPROOF_VEST, TranslationsService.BULLETPROOF_VEST_DESCRIPTION));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 194, TranslationsService.CHAINSAW, null, 5, 5, 2, true, false, false, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 195, TranslationsService.CHAINSAW, null, 5, 5, 2, true, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 196, TranslationsService.DOUBLE_BARREL, null, 0, 2, 2, 3, 1, false, false, false, false) { HasToReload = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 197, TranslationsService.DOUBLE_BARREL, null, 0, 2, 2, 3, 1, false, false, false, false) { HasToReload = true });
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 198, TranslationsService.GASOLINE, TranslationsService.GASOLINE_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 199, TranslationsService.GASOLINE, TranslationsService.GASOLINE_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 200, TranslationsService.GASOLINE, TranslationsService.GASOLINE_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 201, TranslationsService.GLASSBOTTLE, TranslationsService.GLASSBOTTLE_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 202, TranslationsService.GLASSBOTTLE, TranslationsService.GLASSBOTTLE_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 203, TranslationsService.GLASSBOTTLE, TranslationsService.GLASSBOTTLE_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 204, TranslationsService.GOALIEMASK, TranslationsService.GOALIEMASK_DESCRIPTION));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 205, TranslationsService.KNIFE, TranslationsService.KNIFE_DESCRIPTION, 1, 4, 1, false, false, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 206, TranslationsService.KNIFE, TranslationsService.KNIFE_DESCRIPTION, 1, 4, 1, false, false, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 207, TranslationsService.KNIFE, TranslationsService.KNIFE_DESCRIPTION, 1, 4, 1, false, false, true, true));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 208, TranslationsService.KNIFE, TranslationsService.KNIFE_DESCRIPTION, 1, 4, 1, false, false, true, true));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 209, TranslationsService.MAC10, null, 0, 1, 5, 5, 1, false, false, false, true) { HasToReload = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 210, TranslationsService.MAC10, null, 0, 1, 5, 5, 1, false, false, false, true) { HasToReload = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 211, TranslationsService.MAC10, null, 0, 1, 5, 5, 1, false, false, false, true) { HasToReload = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 212, TranslationsService.MAC10, null, 0, 1, 5, 5, 1, false, false, false, true) { HasToReload = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 213, TranslationsService.MP5, null, 0, 1, 3, 4, 1, false, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 214, TranslationsService.MP5, null, 0, 1, 3, 4, 1, false, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 215, TranslationsService.MP5, null, 0, 1, 3, 4, 1, false, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 216, TranslationsService.MP5, null, 0, 1, 3, 4, 1, false, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 217, TranslationsService.PISTOL, null, 0, 1, 1, 4, 1, false, false, false, true));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 218, TranslationsService.PISTOL, null, 0, 1, 1, 4, 1, false, false, false, true));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 219, TranslationsService.PISTOL, null, 0, 1, 1, 4, 1, false, false, false, true));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 220, TranslationsService.PISTOL, null, 0, 1, 1, 4, 1, false, false, false, true));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 221, TranslationsService.PLENTY_AMMO_BULLET, TranslationsService.PLENTY_AMMO_BULLET_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 222, TranslationsService.PLENTY_AMMO_BULLET, TranslationsService.PLENTY_AMMO_BULLET_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 223, TranslationsService.PLENTY_AMMO_BULLET, TranslationsService.PLENTY_AMMO_BULLET_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 224, TranslationsService.PLENTY_AMMO_BULLET, TranslationsService.PLENTY_AMMO_BULLET_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 225, TranslationsService.PLENTY_AMMO_SHOTGUN, TranslationsService.PLENTY_AMMO_SHOTGUN_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 226, TranslationsService.PLENTY_AMMO_SHOTGUN, TranslationsService.PLENTY_AMMO_SHOTGUN_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 227, TranslationsService.PLENTY_AMMO_SHOTGUN, TranslationsService.PLENTY_AMMO_SHOTGUN_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 228, TranslationsService.PLENTY_AMMO_SHOTGUN, TranslationsService.PLENTY_AMMO_SHOTGUN_DESCRIPTION));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 229, TranslationsService.RIFLE, null, 1, 3, 1, 3, 1, false, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 230, TranslationsService.RIFLE, null, 1, 3, 1, 3, 1, false, false, false, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 231, TranslationsService.SABER, null, 2, 4, 2, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 232, TranslationsService.SABER, null, 2, 4, 2, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 233, TranslationsService.SABER, null, 2, 4, 2, false, false, true, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 234, TranslationsService.SAWED_OFF, null, 0, 1, 2, 3, 1, false, false, false, true) { HasToReload = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 235, TranslationsService.SAWED_OFF, null, 0, 1, 2, 3, 1, false, false, false, true) { HasToReload = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 236, TranslationsService.SAWED_OFF, null, 0, 1, 2, 3, 1, false, false, false, true) { HasToReload = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 237, TranslationsService.SAWED_OFF, null, 0, 1, 2, 3, 1, false, false, false, true) { HasToReload = true });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 238, TranslationsService.SHOTGUN, null, 0, 1, 2, 4, 2, false, false, false, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 239, TranslationsService.SHOTGUN, null, 0, 1, 2, 4, 2, false, false, false, false));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 240, TranslationsService.SCOPE, TranslationsService.SCOPE_DESCRIPTION));
        //    list.Add(new EquipmentDto(ZombicideGameEnum.RueMorgue, 241, TranslationsService.SCOPE, TranslationsService.SCOPE_DESCRIPTION));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 242, TranslationsService.SWORD, null, 3, 4, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 243, TranslationsService.SWORD, null, 3, 4, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 244, TranslationsService.SWORD, null, 3, 4, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 245, TranslationsService.URBAN_MACE, null, 2, 3, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 246, TranslationsService.URBAN_MACE, null, 2, 3, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 247, TranslationsService.URBAN_MACE, null, 2, 3, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 248, TranslationsService.URBAN_MACE, null, 2, 3, 1, false, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 249, TranslationsService.CROWBAR, null, 1, 4, 1, true, true, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 250, TranslationsService.CROWBAR, null, 1, 4, 1, true, true, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 251, TranslationsService.CROWBAR, null, 1, 4, 1, true, true, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 252, TranslationsService.CROWBAR, null, 1, 4, 1, true, true, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 253, TranslationsService.FIREAXE, null, 1, 4, 2, true, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 254, TranslationsService.FIREAXE, null, 1, 4, 2, true, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 255, TranslationsService.FIREAXE, null, 1, 4, 2, true, false, true, false));
        //    list.Add(new MeleeWeaponDto(ZombicideGameEnum.RueMorgue, 256, TranslationsService.FIREAXE, null, 1, 4, 2, true, false, true, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 257, TranslationsService.BOW, TranslationsService.BOW_DESCRIPTION, 0, 1, 1, 3, 1, false, false, true, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 258, TranslationsService.BOW, TranslationsService.BOW_DESCRIPTION, 0, 1, 1, 3, 1, false, false, true, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 259, TranslationsService.BOW, TranslationsService.BOW_DESCRIPTION, 0, 1, 1, 3, 1, false, false, true, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 260, TranslationsService.BOW, TranslationsService.BOW_DESCRIPTION, 0, 1, 1, 3, 1, false, false, true, false));
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 261, TranslationsService.MOLOTOV, null, 0, 1, null, null, 10, false, false, false, false) { InDeck = false });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 262, TranslationsService.MOLOTOV, null, 0, 1, null, null, 10, false, false, false, false) { InDeck = false });
        //    list.Add(new RangedWeaponDto(ZombicideGameEnum.RueMorgue, 263, TranslationsService.MOLOTOV, null, 0, 1, null, null, 10, false, false, false, false) { InDeck = false });
        //    #endregion
        //    return list;
        //}

        public CardService()
        {
            //ZombieCards = CreateAllZombieCard();
            //EquipmentCards = CreateAllEquipmentCard();

            //test 
            
            var assembly = typeof(EquipmentDomain).Assembly;


            using (Stream stream = assembly.GetManifestResourceStream("Domain.Card.Equipment.FOOD.json"))
            {
                if (stream == null)
                    throw new Exception("Erreur");

                using (StreamReader reader = new StreamReader(stream, Encoding.GetEncoding("iso-8859-1")))
                {
                    string content = reader.ReadToEnd();
                    var res = JsonConvert.DeserializeObject<EquipmentDto>(content);


                }
            }
        }

        public List<int> GetZombieDeck(List<ZombicideGameEnum> zombicideGames)
        {
            var deck = new List<int>();

            if (zombicideGames == null || !zombicideGames.Any())
                throw new Exception();

            foreach (var game in zombicideGames)
            {
                var g = ZombieDeck.ZombieDeckCardNumber
                            .SingleOrDefault(x => x.Game == game);

               deck.AddRange(Enumerable.Range(g.First,g.Last));
            }

            return deck;
        }

        public List<EquipmentDto> GetEquimentDeck(List<ZombicideGameEnum> zombicideGames = null)
        {
            return zombicideGames == null ? EquipmentCards : EquipmentCards.Where(x => zombicideGames.Contains(x.ZombicideGame)).ToList();
        }

        public CardDto DrawCard(List<CardDto> deck)
        {
            var cardListId = new Random().Next(deck.Count);

            var card = deck[cardListId];

            //TODO check si suffisant
            deck.RemoveAt(cardListId);

            return card;
        }

        public List<ZombieFamilyEnum> GetDeckZombieFamilyFromVersion(ZombicideGameEnum version)
        {
            var allZombie = GetZombieDeck(new List<ZombicideGameEnum> { version });

            return allZombie
                .Where(x => x.ZombicideGame == version && x.BlueInvasion != null)
                .Select(x => x.BlueInvasion.ZombieType)
                .Union(allZombie
                    .Where(x => x.ZombicideGame == version && x.YellowInvasion != null)
                    .Select(x => x.YellowInvasion.ZombieType))
                .Union(allZombie
                    .Where(x => x.ZombicideGame == version && x.OrangeInvasion != null)
                    .Select(x => x.OrangeInvasion.ZombieType))
                .Union(allZombie
                    .Where(x => x.ZombicideGame == version && x.RedInvasion != null)
                    .Select(x => x.RedInvasion.ZombieType))
                .Distinct()
                .ToZombieDtos()
                .Select(x => x.Family)
                .Distinct()
                .ToList();
        }
    }
}