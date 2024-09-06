using System.Linq;
using Microsoft.AspNetCore.Mvc;
using clashclash.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace clashclash.Controllers
{
    public class CardController : Controller
    {
    private static List<CardModel> _cards = new List<CardModel>
        {
        new CardModel
        {
          Name = "Knight",
          Id = 26000000,
          maxlevel = 14,
          maxevolutionlevel = 1,
          Medium = "https://api-assets.clashroyale.com/cards/300/jAj1Q5rclXxU9kVImGqSJxa4wEMfEhvwNQ_4jiGUuqg.png",
          elixircost = 3,
          Rarity = "common"

        },

        new CardModel 
        {
          Name = "Archers",
          Id = 26000001,
          maxlevel = 14,
          maxevolutionlevel = 1,
          elixircost = 3,
          Medium = "https://api-assets.clashroyale.com/cards/300/W4Hmp8MTSdXANN8KdblbtHwtsbt0o749BbxNqmJYfA8.png",
          Rarity = "common"
        },
        
        new CardModel
        {

          Name = "Goblins",
          Id = 26000002,
          maxlevel = 14,
          elixircost = 2,
          Medium = "https://api-assets.clashroyale.com/cards/300/X_DQUye_OaS3QN6VC9CPw05Fit7wvSm3XegXIXKP--0.png",
          Rarity = "common"
        },

        
      
        new CardModel
        {
          Name = "P.E.K.K.A",
          Id = 26000004,
          maxlevel = 9,
          elixircost = 7,        
          Medium = "https://api-assets.clashroyale.com/cards/300/MlArURKhn_zWAZY-Xj1qIRKLVKquarG25BXDjUQajNs.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Minions",
          Id = 26000005,
          maxlevel = 14,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/yHGpoEnmUWPGV_hBbhn-Kk-Bs838OjGzWzJJlQpQKQA.png",
          Rarity = "common"
        },
      
        new CardModel
        {
          Name = "Balloon",
          Id = 26000006,
          maxlevel = 9,
          elixircost = 5,        
          Medium = "https://api-assets.clashroyale.com/cards/300/qBipxLo-3hhCnPrApp2Nn3b2NgrSrvwzWytvREev0CY.png",
          Rarity = "epic"
        },
      
        new CardModel
        {
          Name = "Witch",
          Id = 26000007,
          maxlevel = 9,
          elixircost = 5,        
          Medium = "https://api-assets.clashroyale.com/cards/300/cfwk1vzehVyHC-uloEIH6NOI0hOdofCutR5PyhIgO6w.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Barbarians",
          Id = 26000008,
          maxlevel = 14,
          maxevolutionlevel = 1,
          elixircost = 5,        
          Medium = "https://api-assets.clashroyale.com/cards/300/TvJsuu2S4yhyk1jVYUAQwdKOnW4U77KuWWOTPOWnwfI.png",          
          Rarity = "common"
          
        },
        
        new CardModel
        {
          Name = "Golem",
          Id = 26000009,
          maxlevel = 9,
          elixircost = 8,        
          Medium = "https://api-assets.clashroyale.com/cards/300/npdmCnET7jmVjJvjJQkFnNSNnDxYHDBigbvIAloFMds.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Skeletons",
          Id = 26000010,
          maxlevel = 14,
          maxevolutionlevel = 1,
          elixircost = 1,        
          Medium = "https://api-assets.clashroyale.com/cards/300/oO7iKMU5m0cdxhYPZA3nWQiAUh2yoGgdThLWB1rVSec.png",          
          Rarity = "common"
        },

        new CardModel
        {
          Name = "Valkyrie",
          Id = 26000011,
          maxlevel = 12,
          maxevolutionlevel = 1,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/0lIoYf3Y_plFTzo95zZL93JVxpfb3MMgFDDhgSDGU9A.png",          
          Rarity = "rare"
        },

        new CardModel
        {
          Name = "Skeleton Army",
          Id = 26000012,
          maxlevel = 9,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/fAOToOi1pRy7svN2xQS6mDkhQw2pj9m_17FauaNqyl4.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Bomber",
          Id = 26000013,
          maxlevel = 14,
          maxevolutionlevel = 1,
          elixircost = 2,        
          Medium = "https://api-assets.clashroyale.com/cards/300/12n1CesxKIcqVYntjxcF36EFA-ONw7Z-DoL0_rQrbdo.png",          
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Musketeer",
          Id = 26000014,
          maxlevel = 12,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/Tex1C48UTq9FKtAX-3tzG0FJmc9jzncUZG3bb5Vf-Ds.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Baby Dragon",
          Id = 26000015,
          maxlevel = 9,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/cjC9n4AvEZJ3urkVh-rwBkJ-aRSsydIMqSAV48hAih0.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Prince",
          Id = 26000016,
          maxlevel = 9,
          elixircost = 5,        
          Medium = "https://api-assets.clashroyale.com/cards/300/3JntJV62aY0G1Qh6LIs-ek-0ayeYFY3VItpG7cb9I60.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Wizard",
          Id = 26000017,
          maxlevel = 12,
          maxevolutionlevel = 1,
          elixircost = 5,        
          Medium = "https://api-assets.clashroyale.com/cards/300/Mej7vnv4H_3p_8qPs_N6_GKahy6HDr7pU7i9eTHS84U.png",          
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Mini P.E.K.K.A",
          Id = 26000018,
          maxlevel = 12,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/Fmltc4j3Ve9vO_xhHHPEO3PRP3SmU2oKp2zkZQHRZT4.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Spear Goblins",
          Id = 26000019,
          maxlevel = 14,
          elixircost = 2,        
          Medium = "https://api-assets.clashroyale.com/cards/300/FSDFotjaXidI4ku_WFpVCTWS1hKGnFh1sxX0lxM43_E.png",
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Giant Skeleton",
          Id = 26000020,
          maxlevel = 9,
          elixircost = 6,        
          Medium = "https://api-assets.clashroyale.com/cards/300/0p0gd0XaVRu1Hb1iSG1hTYbz2AN6aEiZnhaAib5O8Z8.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Hog Rider",
          Id = 26000021,
          maxlevel = 12,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/Ubu0oUl8tZkusnkZf8Xv9Vno5IO29Y-jbZ4fhoNJ5oc.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Minion Horde",
          Id = 26000022,
          maxlevel = 14,
          elixircost = 5,        
          Medium = "https://api-assets.clashroyale.com/cards/300/Wyjq5l0IXHTkX9Rmpap6HaH08MvjbxFp1xBO9a47YSI.png",
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Ice Wizard",
          Id = 26000023,
          maxlevel = 6,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/W3dkw0HTw9n1jB-zbknY2w3wHuyuLxSRIAV5fUT1SEY.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "Royal Giant",
          Id = 26000024,
          maxlevel = 14,
        },
        
        new CardModel
        {
          Name = "Guards",
          Id = 26000025,
          maxlevel = 9,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/1ArKfLJxYo6_NU_S9cAeIrfbXqWH0oULVJXedxBXQlU.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Princess",
          Id = 26000026,
          maxlevel = 6,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/bAwMcqp9EKVIKH3ZLm_m0MqZFSG72zG-vKxpx8aKoVs.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "Dark Prince",
          Id = 26000027,
          maxlevel = 9,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/M7fXlrKXHu2IvpSGpk36kXVstslbR08Bbxcy0jQcln8.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Three Musketeers",
          Id = 26000028,
          maxlevel = 12,
          elixircost = 9,        
          Medium = "https://api-assets.clashroyale.com/cards/300/_J2GhbkX3vswaFk1wG-dopwiHyNc_YiPhwroiKF3Mek.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Lava Hound",
          Id = 26000029,
          maxlevel = 6,
          elixircost = 7,        
          Medium = "https://api-assets.clashroyale.com/cards/300/unicRQ975sBY2oLtfgZbAI56ZvaWz7azj-vXTLxc0r8.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "Ice Spirit",
          Id = 26000030,
          maxlevel = 14,
          maxevolutionlevel = 1,
          elixircost = 1,        
          Medium = "https://api-assets.clashroyale.com/cards/300/lv1budiafU9XmSdrDkk0NYyqASAFYyZ06CPysXKZXlA.png",          
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Fire Spirit",
          Id = 26000031,
          maxlevel = 14,
          elixircost = 1,        
          Medium = "https://api-assets.clashroyale.com/cards/300/16-BqusVvynIgYI8_Jci3LDC-r8AI_xaIYLgXqtlmS8.png",
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Miner",
          Id = 26000032,
          maxlevel = 6,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/Y4yWvdwBCg2FpAZgs8T09Gy34WOwpLZW-ttL52Ae8NE.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "Sparky",
          Id = 26000033,
          maxlevel = 6,
          elixircost = 6,        
          Medium = "https://api-assets.clashroyale.com/cards/300/2GKMkBrArZXgQxf2ygFjDs4VvGYPbx8F6Lj_68iVhIM.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "Bowler",
          Id = 26000034,
          maxlevel = 9,
          elixircost = 5,        
          Medium = "https://api-assets.clashroyale.com/cards/300/SU4qFXmbQXWjvASxVI6z9IJuTYolx4A0MKK90sTIE88.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Lumberjack",
          Id = 26000035,
          maxlevel = 6,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/E6RWrnCuk13xMX5OE1EQtLEKTZQV6B78d00y8PlXt6Q.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "Battle Ram",
          Id = 26000036,
          maxlevel = 12,
          maxevolutionlevel = 1,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/dyc50V2cplKi4H7pq1B3I36pl_sEH5DQrNHboS_dbbM.png",          
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Inferno Dragon",
          Id = 26000037,
          maxlevel = 6,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/y5HDbKtTbWG6En6TGWU0xoVIGs1-iQpIP4HC-VM7u8A.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "Ice Golem",
          Id = 26000038,
          maxlevel = 12,
          elixircost = 2,        
          Medium = "https://api-assets.clashroyale.com/cards/300/r05cmpwV1o7i7FHodtZwW3fmjbXCW34IJCsDEV5cZC4.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Mega Minion",
          Id = 26000039,
          maxlevel = 12,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/-T_e4YLbuhPBKbYnBwQfXgynNpp5eOIN_0RracYwL9c.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Dart Goblin",
          Id = 26000040,
          maxlevel = 12,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/BmpK3bqEAviflqHCdxxnfm-_l3pRPJw3qxHkwS55nCY.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Goblin Gang",
          Id = 26000041,
          maxlevel = 14,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/NHflxzVAQT4oAz7eDfdueqpictb5vrWezn1nuqFhE4w.png",
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Electro Wizard",
          Id = 26000042,
          maxlevel = 6,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/RsFaHgB3w6vXsTjXdPr3x8l_GbV9TbOUCvIx07prbrQ.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "Elite Barbarians",
          Id = 26000043,
          maxlevel = 14,
          elixircost = 6,        
          Medium = "https://api-assets.clashroyale.com/cards/300/C88C5JH_F3lLZj6K-tLcMo5DPjrFmvzIb1R2M6xCfTE.png",
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Hunter",
          Id = 26000044,
          maxlevel = 9,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/VNabB1WKnYtYRSG7X_FZfnZjQDHTBs9A96OGMFmecrA.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Executioner",
          Id = 26000045,
          maxlevel = 9,
          elixircost = 5,        
          Medium = "https://api-assets.clashroyale.com/cards/300/9XL5BP2mqzV8kza6KF8rOxrpCZTyuGLp2l413DTjEoM.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Bandit",
          Id = 26000046,
          maxlevel = 6,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/QWDdXMKJNpv0go-HYaWQWP6p8uIOHjqn-zX7G0p3DyM.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "Royal Recruits",
          Id = 26000047,
          maxlevel = 14,
          maxevolutionlevel = 1,
          elixircost = 7,        
          Medium = "https://api-assets.clashroyale.com/cards/300/jcNyYGUiXXNz3kuz8NBkHNKNREQKraXlb_Ts7rhCIdM.png",          
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Night Witch",
          Id = 26000048,
          maxlevel = 6,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/NpCrXDEDBBJgNv9QrBAcJmmMFbS7pe3KCY8xJ5VB18A.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "Bats",
          Id = 26000049,
          maxlevel = 14,
          maxevolutionlevel = 1,
          elixircost = 2,        
          Medium = "https://api-assets.clashroyale.com/cards/300/EnIcvO21hxiNpoI-zO6MDjLmzwPbq8Z4JPo2OKoVUjU.png",          
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Royal Ghost",
          Id = 26000050,
          maxlevel = 6,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/3En2cz0ISQAaMTHY3hj3rTveFN2kJYq-H4VxvdJNvCM.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "Ram Rider",
          Id = 26000051,
          maxlevel = 6,
          elixircost = 5,        
          Medium = "https://api-assets.clashroyale.com/cards/300/QaJyerT7f7oMyZ3Fv1glKymtLSvx7YUXisAulxl7zRI.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "Zappies",
          Id = 26000052,
          maxlevel = 12,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/QZfHRpLRmutZbCr5fpLnTpIp89vLI6NrAwzGZ8tHEc4.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Rascals",
          Id = 26000053,
          maxlevel = 14,
          elixircost = 5,        
          Medium = "https://api-assets.clashroyale.com/cards/300/KV48DfwVHKx9XCjzBdk3daT_Eb52Me4VgjVO7WctRc4.png",
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Cannon Cart",
          Id = 26000054,
          maxlevel = 9,
          elixircost = 5,        
          Medium = "https://api-assets.clashroyale.com/cards/300/aqwxRz8HXzqlMCO4WMXNA1txynjXTsLinknqsgZLbok.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Mega Knight",
          Id = 26000055,
          maxlevel = 6,
          elixircost = 7,        
          Medium = "https://api-assets.clashroyale.com/cards/300/O2NycChSNhn_UK9nqBXUhhC_lILkiANzPuJjtjoz0CE.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "Skeleton Barrel",
          Id = 26000056,
          maxlevel = 14,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/vCB4DWCcrGbTkarjcOiVz4aNDx6GWLm0yUepg9E1MGo.png",
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Flying Machine",
          Id = 26000057,
          maxlevel = 12,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/hzKNE3QwFcrSrDDRuVW3QY_OnrDPijSiIp-PsWgFevE.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Wall Breakers",
          Id = 26000058,
          maxlevel = 9,
          maxevolutionlevel = 1,
          elixircost = 2,        
          Medium = "https://api-assets.clashroyale.com/cards/300/_xPphEfC8eEwFNrfU3cMQG9-f5JaLQ31ARCA7l3XtW4.png",          
          Rarity = "epic"
        },

        new CardModel
        {
          Name = "Royal Hogs",
          Id = 26000059,
          maxlevel = 12,
          elixircost = 5,        
          Medium = "https://api-assets.clashroyale.com/cards/300/ASSQJG_MoVq9e81HZzo4bynMnyLNpNJMfSLb3hqydOw.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Goblin Giant",
          Id = 26000060,
          maxlevel = 9,
          maxevolutionlevel = 1,
          elixircost = 6,        
          Medium = "https://api-assets.clashroyale.com/cards/300/SoW16cY3jXBwaTDvb39DkqiVsoFVaDWbzf5QBYphJrY.png",          
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Fisherman",
          Id = 26000061,
          maxlevel = 6,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/U2KZ3g0wyufcuA5P2Xrn3Z3lr1WiJmc5S0IWOZHgizQ.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "Magic Archer",
          Id = 26000062,
          maxlevel = 6,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/Avli3W7BxU9HQ2SoLiXnBgGx25FoNXUSFm7OcAk68ek.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "Electro Dragon",
          Id = 26000063,
          maxlevel = 9,
          elixircost = 5,        
          Medium = "https://api-assets.clashroyale.com/cards/300/tN9h6lnMNPCNsx0LMFmvpHgznbDZ1fBRkx-C7UfNmfY.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Firecracker",
          Id = 26000064,
          maxlevel = 14,
          maxevolutionlevel = 1,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/c1rL3LO1U2D9-TkeFfAC18gP3AO8ztSwrcHMZplwL2Q.png",          
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Mighty Miner",
          Id = 26000065,
          maxlevel = 4,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/Cd9R56yraxTvJiD8xJ2qT2OdsHyh94FqOAarXpbyelo.png",
          Rarity = "champion"
        },
        
        new CardModel
        {
          Name = "Elixir Golem",
          Id = 26000067,
          maxlevel = 12,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/puhMsZjCIqy21HW3hYxjrk_xt8NIPyFqjRy-BeLKZwo.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Battle Healer",
          Id = 26000068,
          maxlevel = 12,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/KdwXcoigS2Kg-cgA7BJJIANbUJG6SNgjetRQ-MegZ08.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Skeleton King",
          Id = 26000069,
          maxlevel = 4,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/dCd69_wN9f8DxwuqOGtR4QgWhHIPIaTNxZ1e23RzAAc.png",
          Rarity = "champion"
        },
        
        new CardModel
        {
          Name = "Archer Queen",
          Id = 26000072,
          maxlevel = 4,
          elixircost = 5,        
          Medium = "https://api-assets.clashroyale.com/cards/300/p7OQmOAFTery7zCzlpDdm-LOD1kINTm42AwIHchZfWk.png",
          Rarity = "champion"
        },
        
        new CardModel
        {
          Name = "Golden Knight",
          Id = 26000074,
          maxlevel = 4,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/WJd207D0O1sN-l1FTb8P9KhYL2oF5jY26vRUfTUW3FQ.png",
          Rarity = "champion"
        },
        
        new CardModel
        {
          Name = "Monk",
          Id = 26000077,
          maxlevel = 4,
          elixircost = 5,        
          Medium = "https://api-assets.clashroyale.com/cards/300/2onG4t4-CxqwFVZAn6zpWxFz3_mG2ksSj4Q7zldo1SM.png",
          Rarity = "champion"
        },
        
        new CardModel
        {
          Name = "Skeleton Dragons",
          Id = 26000080,
          maxlevel = 14,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/qPOtg9uONh47_NLxGhhFc_ww9PlZ6z3Ry507q1NZUXs.png",
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Mother Witch",
          Id = 26000083,
          maxlevel = 6,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/fO-Xah8XZkYKaSK9SCp3wnzwxtvIhun9NVY-zzte1Ng.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "Electro Spirit",
          Id = 26000084,
          maxlevel = 14,
          elixircost = 1,        
          Medium = "https://api-assets.clashroyale.com/cards/300/WKd4-IAFsgPpMo7dDi9sujmYjRhOMEWiE07OUJpvD9g.png",
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Electro Giant",
          Id = 26000085,
          maxlevel = 9,
          elixircost = 7,        
          Medium = "https://api-assets.clashroyale.com/cards/300/_uChZkNHAMq6tPb3v6A49xinOe3CnhjstOhG6OZbPYc.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Phoenix",
          Id = 26000087,
          maxlevel = 6,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/i0RoY1fs6ay7VAxyFEfZGIPnD002nAKcne9FtJsWBHM.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "Little Prince",
          Id = 26000093,
          maxlevel = 4,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/dY-gSseki6KBpkIG17safHH5YlB8SErFZO9OXbJxf9w.png",
          Rarity = "champion"
        },
        
        new CardModel
        {
          Name = "Goblin Demolisher",
          Id = 26000095,
          maxlevel = 12,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/KVVOgdn40xasFLYuQv8Go_U_LCV7wSG9q9eE1H7f3Qk.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Goblin Machine",
          Id = 26000096,
          maxlevel = 6,
          elixircost = 5,        
          Medium = "https://api-assets.clashroyale.com/cards/300/-iLlotr6GCFndL_1BSBqWBb6DnsHBhLerd5EblZDNfU.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "Suspicious Bush",
          Id = 26000097,
          maxlevel = 12,
          elixircost = 2,        
          Medium = "https://api-assets.clashroyale.com/cards/300/vqTzGAjseQv9F5rf4tsFWeocvg0dyPw1j_nB1cmDZfI.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Cannon",
          Id = 27000000,
          maxlevel = 14,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/nZK1y-beLxO5vnlyUhK6-2zH2NzXJwqykcosqQ1cmZ8.png",
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Goblin Hut",
          Id = 27000001,
          maxlevel = 12,
          elixircost = 5,        
          Medium = "https://api-assets.clashroyale.com/cards/300/l8ZdzzNLcwB4u7ihGgxNFQOjCT_njFuAhZr7D6PRF7E.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Mortar",
          Id = 27000002,
          maxlevel = 14,
          maxevolutionlevel = 1,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/lPOSw6H7YOHq2miSCrf7ZDL3ANjhJdPPDYOTujdNrVE.png",          
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Inferno Tower",
          Id = 27000003,
          maxlevel = 12,
          elixircost = 5,        
          Medium = "https://api-assets.clashroyale.com/cards/300/GSHY_wrooMMLET6bG_WJB8redtwx66c4i80ipi4gYOM.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Bomb Tower",
          Id = 27000004,
          maxlevel = 12,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/rirYRyHPc97emRjoH-c1O8uZCBzPVnToaGuNGusF3TQ.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Barbarian Hut",
          Id = 27000005,
          maxlevel = 12,
          elixircost = 6,        
          Medium = "https://api-assets.clashroyale.com/cards/300/ho0nOG2y3Ch86elHHcocQs8Fv_QNe0cFJ2CijsxABZA.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Tesla",
          Id = 27000006,
          maxlevel = 14,
          maxevolutionlevel = 1,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/OiwnGrxFMNiHetYEerE-UZt0L_uYNzFY7qV_CA_OxR4.png",          
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Elixir Collector",
          Id = 27000007,
          maxlevel = 12,
          elixircost = 6,        
          Medium = "https://api-assets.clashroyale.com/cards/300/BGLo3Grsp81c72EpxLLk-Sofk3VY56zahnUNOv3JcT0.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "X-Bow",
          Id = 27000008,
          maxlevel = 9,
          elixircost = 6,        
          Medium = "https://api-assets.clashroyale.com/cards/300/zVQ9Hme1hlj9Dc6e1ORl9xWwglcSrP7ejow5mAhLUJc.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Tombstone",
          Id = 27000009,
          maxlevel = 12,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/LjSfSbwQfkZuRJY4pVxKspZ-a0iM5KAhU8w-a_N5Z7Y.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Furnace",
          Id = 27000010,
          maxlevel = 12,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/iqbDiG7yYRIzvCPXdt9zPb3IvMt7F7Gi4wIPnh2x4aI.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Goblin Cage",
          Id = 27000012,
          maxlevel = 12,
          maxevolutionlevel = 1,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/vD24bBgK4rSq7wx5QEbuqChtPMRFviL_ep76GwQw1yA.png",          
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Goblin Drill",
          Id = 27000013,
          maxlevel = 9,
          maxevolutionlevel = 1,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/eN2TKUYbih-26yBi0xy5LVFOA0zDftgDqxxnVfdIg1o.png",          
          Rarity = "epic"
          
        },
        
        new CardModel
        {
          Name = "Fireball",
          Id = 28000000,
          maxlevel = 12,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/lZD9MILQv7O-P3XBr_xOLS5idwuz3_7Ws9G60U36yhc.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Arrows",
          Id = 28000001,
          maxlevel = 14,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/Flsoci-Y6y8ZFVi5uRFTmgkPnCmMyMVrU7YmmuPvSBo.png",
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Rage",
          Id = 28000002,
          maxlevel = 9,
          elixircost = 2,        
          Medium = "https://api-assets.clashroyale.com/cards/300/bGP21OOmcpHMJ5ZA79bHVV2D-NzPtDkvBskCNJb7pg0.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Rocket",
          Id = 28000003,
          maxlevel = 12,
          elixircost = 6,        
          Medium = "https://api-assets.clashroyale.com/cards/300/Ie07nQNK9CjhKOa4-arFAewi4EroqaA-86Xo7r5tx94.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Goblin Barrel",
          Id = 28000004,
          maxlevel = 9,
          maxevolutionlevel = 1,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/CoZdp5PpsTH858l212lAMeJxVJ0zxv9V-f5xC8Bvj5g.png",          
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Freeze",
          Id = 28000005,
          maxlevel = 9,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/I1M20_Zs_p_BS1NaNIVQjuMJkYI_1-ePtwYZahn0JXQ.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Mirror",
          Id = 28000006,
          maxlevel = 9,
          Medium = "https://api-assets.clashroyale.com/cards/300/wC6Cm9rKLEOk72zTsukVwxewKIoO4ZcMJun54zCPWvA.png",
          Rarity = "epic"        
        },
        
        new CardModel
        {
          Name = "Lightning",
          Id = 28000007,
          maxlevel = 9,
          elixircost = 6,        
          Medium = "https://api-assets.clashroyale.com/cards/300/fpnESbYqe5GyZmaVVYe-SEu7tE0Kxh_HZyVigzvLjks.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Zap",
          Id = 28000008,
          maxlevel = 14,
          maxevolutionlevel = 1,
          elixircost = 2,        
          Medium = "https://api-assets.clashroyale.com/cards/300/7dxh2-yCBy1x44GrBaL29vjqnEEeJXHEAlsi5g6D1eY.png",          
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Poison",
          Id = 28000009,
          maxlevel = 9,
          elixircost = 4,        
          Medium = "https://api-assets.clashroyale.com/cards/300/98HDkG2189yOULcVG9jz2QbJKtfuhH21DIrIjkOjxI8.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Graveyard",
          Id = 28000010,
          maxlevel = 6,
          elixircost = 5,        
          Medium = "https://api-assets.clashroyale.com/cards/300/Icp8BIyyfBTj1ncCJS7mb82SY7TPV-MAE-J2L2R48DI.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "The Log",
          Id = 28000011,
          maxlevel = 6,
          elixircost = 2,        
          Medium = "https://api-assets.clashroyale.com/cards/300/_iDwuDLexHPFZ_x4_a0eP-rxCS6vwWgTs6DLauwwoaY.png",
          Rarity = "legendary"
        },
        
        new CardModel
        {
          Name = "Tornado",
          Id = 28000012,
          maxlevel = 9,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/QJB-QK1QJHdw4hjpAwVSyZBozc2ZWAR9pQ-SMUyKaT0.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Clone",
          Id = 28000013,
          maxlevel = 9,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/mHVCet-1TkwWq-pxVIU2ZWY9_2z7Z7wtP25ArEUsP_g.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Earthquake",
          Id = 28000014,
          maxlevel = 12,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/XeQXcrUu59C52DslyZVwCnbi4yamID-WxfVZLShgZmE.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Barbarian Barrel",
          Id = 28000015,
          maxlevel = 9,
          elixircost = 2,        
          Medium = "https://api-assets.clashroyale.com/cards/300/Gb0G1yNy0i5cIGUHin8uoFWxqntNtRPhY_jeMXg7HnA.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Heal Spirit",
          Id = 28000016,
          maxlevel = 12,
          elixircost = 1,        
          Medium = "https://api-assets.clashroyale.com/cards/300/GITl06sa2nGRLPvboyXbGEv5E3I-wAwn1Eqa5esggbc.png",
          Rarity = "rare"
        },
        
        new CardModel
        {
          Name = "Giant Snowball",
          Id = 28000017,
          maxlevel = 14,
          elixircost = 2,        
          Medium = "https://api-assets.clashroyale.com/cards/300/7MaJLa6hK9WN2_VIshuh5DIDfGwm0wEv98gXtAxLDPs.png",
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Royal Delivery",
          Id = 28000018,
          maxlevel = 14,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/LPg7AGjGI3_xmi7gLLgGC50yKM1jJ2teWkZfoHJcIZo.png",
          Rarity = "common"
        },
        
        new CardModel
        {
          Name = "Void",
          Id = 28000023,
          maxlevel = 9,
          elixircost = 3,        
          Medium = "https://api-assets.clashroyale.com/cards/300/BykyeWDqzn4PlHSszu3NbrXT1mHxW2EA8vHbQGR5LDE.png",
          Rarity = "epic"
        },
        
        new CardModel
        {
          Name = "Goblin Curse",
          Id = 28000024,
          maxlevel = 9,
          elixircost = 2,        
          Medium = "https://api-assets.clashroyale.com/cards/300/OQPfGgT5mHEUvPuKKt0plZT0PNtIjCqUgQ3Rm86dQ2k.png",
          Rarity = "epic"
        }
        

      };


        [HttpGet]
        public IActionResult Index(string searchString)
        {
            var cards = _cards;

            if (!string.IsNullOrEmpty(searchString))
            {
                cards = cards.Where(c => c.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            return View(cards);
        }

        [HttpGet]
        public IActionResult Search(string query)
        {
            var cards = _cards;

            if (!string.IsNullOrEmpty(query))
            {
                cards = cards.Where(c => c.Name.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            return Json(cards);
        }

        [HttpGet]
        public IActionResult GetCardById(int id)
        {
            var card = _cards.FirstOrDefault(c => c.Id == id);
            if (card == null)
            {
                return NotFound(); // Retorna 404 se o cartão não for encontrado
            }

            return Json(card);
        }


    }
}
