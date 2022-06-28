using HarmonyLib;
using UnhollowerBaseLib;

namespace TownOfUs.RainbowMod
{
    [HarmonyPatch(typeof(TranslationController), nameof(TranslationController.GetString),
        new[] { typeof(StringNames), typeof(Il2CppReferenceArray<Il2CppSystem.Object>) })]
    public class PatchColours
    {
        public static bool Prefix(ref string __result, [HarmonyArgument(0)] StringNames name)
        {
            var newResult = (int)name switch
            {
                999990 => "Watermelon",
                999991 => "Chocolate",
                999992 => "Sky Blue",
                999993 => "Beige",
                999994 => "Hot Pink",
                999995 => "Turquoise",
                999996 => "Lilac",
                999997 => "Olive",
                999998 => "Azure",
                999999 => "Rainbow",
                999989 => "Blurple",
                999988 => "Wine",
                999987 => "Rust",
                999986 => "Peach",
                999985 => "Dark Mint",
                999984 => "Teal",
                999983 => "Pastel Pink",
                999982 => "Merlot",
                999981 => "Pear",
                999980 => "Copper",
                999979 => "Khaki",
                999978 => "Mustard",
                999977 => "Ice",
                999976 => "Concord",
                _ => null
            };
            if (newResult != null)
            {
                __result = newResult;
                return false;
            }

            return true;
        }
    }
}
