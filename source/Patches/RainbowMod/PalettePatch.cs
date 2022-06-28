using UnityEngine;

namespace TownOfUs.RainbowMod
{
    public static class PalettePatch
    {
        public static void Load()
        {
            Palette.ColorNames = new[]
            {
                StringNames.ColorRed,
                StringNames.ColorBlue,
                StringNames.ColorGreen,
                StringNames.ColorPink,
                StringNames.ColorOrange,
                StringNames.ColorYellow,
                StringNames.ColorBlack,
                StringNames.ColorWhite,
                StringNames.ColorPurple,
                StringNames.ColorBrown,
                StringNames.ColorCyan,
                StringNames.ColorLime,
                StringNames.ColorMaroon,
                StringNames.ColorRose,
                StringNames.ColorBanana,
                StringNames.ColorGray,
                StringNames.ColorTan,
                StringNames.ColorCoral,
                // New colours
                (StringNames)999990,//"Watermelon",
                (StringNames)999991,//"Chocolate",
                (StringNames)999992,//"Sky Blue",
                (StringNames)999993,//"Beige",
                (StringNames)999994,//"Hot Pink",
                (StringNames)999995,//"Turquoise",
                (StringNames)999996,//"Lilac",
                (StringNames)999997,//"Olive",
                (StringNames)999998,//"Azure",
                (StringNames)999999,//"Rainbow",
                (StringNames)999989,//blurple
                (StringNames)999988,//wine
                (StringNames)999987,//rust
                (StringNames)999986,//peach
                (StringNames)999985,//darkmint
                (StringNames)999984,//teal
                (StringNames)999983,//pastelpink
                (StringNames)999982,//merlot
                (StringNames)999981,//pear
                (StringNames)999980,//coppper
                (StringNames)999979,//khaki
                (StringNames)999978,//mustard
                (StringNames)999977,//ice
                (StringNames)999976,//concord
            };
            Palette.PlayerColors = new[]
            {
                new Color32(198, 17, 17, byte.MaxValue),
                new Color32(19, 46, 210, byte.MaxValue),
                new Color32(17, 128, 45, byte.MaxValue),
                new Color32(238, 84, 187, byte.MaxValue),
                new Color32(240, 125, 13, byte.MaxValue),
                new Color32(246, 246, 87, byte.MaxValue),
                new Color32(63, 71, 78, byte.MaxValue),
                new Color32(215, 225, 241, byte.MaxValue),
                new Color32(107, 47, 188, byte.MaxValue),
                new Color32(113, 73, 30, byte.MaxValue),
                new Color32(56, byte.MaxValue, 221, byte.MaxValue),
                new Color32(80, 240, 57, byte.MaxValue),
                Palette.FromHex(6233390),
                Palette.FromHex(15515859),
                Palette.FromHex(15787944),
                Palette.FromHex(7701907),
                Palette.FromHex(9537655),
                Palette.FromHex(14115940),
                // New colours
                new Color32(168, 50, 62, byte.MaxValue),
                new Color32(60, 48, 44, byte.MaxValue),
                new Color32(61, 129, 255, byte.MaxValue),
                new Color32(240, 211, 165, byte.MaxValue),
                new Color32(236, 61, 255, byte.MaxValue),
                new Color32(61, 255, 181, byte.MaxValue),
                new Color32(186, 161, 255, byte.MaxValue),
                new Color32(97, 114, 24, byte.MaxValue),
                new Color32(1, 166, 255, byte.MaxValue),
                new Color32(0, 0, 0, byte.MaxValue),
                new Color32(130, 125, 235, byte.MaxValue),//blurple
                new Color32(154, 38, 136, byte.MaxValue),//wine
                new Color32(184, 69, 18, byte.MaxValue),//rust
                new Color32(244, 175, 120, byte.MaxValue),//peach
                new Color32(41, 157, 126, byte.MaxValue),//darkmint
                new Color32(35, 126, 136, byte.MaxValue),//teal
                new Color32(254, 207, 216, byte.MaxValue),//pastelpink
                new Color32(122, 20, 40, byte.MaxValue),//merlot
                new Color32(142, 219, 31, byte.MaxValue),//tidelime
                new Color32(211, 141, 95, byte.MaxValue),//copper
                new Color32(222, 220, 136, byte.MaxValue),//khaki
                new Color32(210, 190, 18, byte.MaxValue),//mustard
                new Color32(177, 231, 243, byte.MaxValue),//ice
                new Color32(71, 66, 168, byte.MaxValue),//concord
            };
            Palette.ShadowColors = new[]
            {
                new Color32(122, 8, 56, byte.MaxValue),
                new Color32(9, 21, 142, byte.MaxValue),
                new Color32(10, 77, 46, byte.MaxValue),
                new Color32(172, 43, 174, byte.MaxValue),
                new Color32(180, 62, 21, byte.MaxValue),
                new Color32(195, 136, 34, byte.MaxValue),
                new Color32(30, 31, 38, byte.MaxValue),
                new Color32(132, 149, 192, byte.MaxValue),
                new Color32(59, 23, 124, byte.MaxValue),
                new Color32(94, 38, 21, byte.MaxValue),
                new Color32(36, 169, 191, byte.MaxValue),
                new Color32(21, 168, 66, byte.MaxValue),
                Palette.FromHex(4263706),
                Palette.FromHex(14586547),
                Palette.FromHex(13810825),
                Palette.FromHex(4609636),
                Palette.FromHex(5325118),
                Palette.FromHex(11813730),
                // New colours
                new Color32(101, 30, 37, byte.MaxValue),
                new Color32(30, 24, 22, byte.MaxValue),
                new Color32(31, 65, 128, byte.MaxValue),
                new Color32(120, 106, 83, byte.MaxValue),
                new Color32(118, 31, 128, byte.MaxValue),
                new Color32(31, 128, 91, byte.MaxValue),
                new Color32(93, 81, 128, byte.MaxValue),
                new Color32(66, 91, 15, byte.MaxValue),
                new Color32(17, 104, 151, byte.MaxValue),
                new Color32(0, 0, 0, byte.MaxValue),
                new Color32(78, 63, 187, byte.MaxValue),//blurple
                new Color32(96, 34, 86, byte.MaxValue),//wine
                new Color32(117, 40, 19, byte.MaxValue),//rust
                new Color32(212, 111, 62, byte.MaxValue),//peach
                new Color32(33, 91, 79, byte.MaxValue),//darkmint
                new Color32(17, 76, 82, byte.MaxValue),//teal
                new Color32(199, 138, 160, byte.MaxValue),//pastelpink
                new Color32(77, 8, 20, byte.MaxValue),//merlot
                new Color32(75, 134, 28, byte.MaxValue),//tidelime
                new Color32(152, 98, 66, byte.MaxValue),//copper
                new Color32(201, 183, 102, byte.MaxValue),//khaki
                new Color32(162, 128, 26, byte.MaxValue),//mustard
                new Color32(102, 171, 194, byte.MaxValue),//ice
                new Color32(42, 40, 84, byte.MaxValue),//concord
            };
        }
    }
}
