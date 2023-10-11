// -----------------------------------------------------------------------
// Author:  Takayoshi Hagiwara (KMD)
// Created: 2023/6/19
// Summary: Utility class for Japanese traditional color
// References:
// https://en.wikipedia.org/wiki/Traditional_colors_of_Japan
// https://www.colordic.org/w
// Remarks:
// Those shown here are approximate colors and are an example.
// Basically, refer to this (https://www.colordic.org/w), and if it differs, refer to Wikipedia.
// Also, the RGBA values shown in Summary are the values before normalization (0~255). Return values are normalized.
// -----------------------------------------------------------------------

using System.Runtime.CompilerServices;
using UnityEngine;

namespace TH.Utils.UI
{
    /// <summary>
    /// Representation of RGBA colors.
    /// The RGBA values shown in Summary are the values before normalization (0~255). Return values are normalized.
    /// </summary>
    public static class JapaneseTraditionalColors
    {
        /// <summary>
        /// Shades of red.
        /// </summary>
        public static class RedFamily
        {
            /// <summary>
            /// Solid Sakura (桜). RGBA is (254, 238, 237, 255).
            /// </summary>
            public static Color Sakura { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(254F / 255F, 238F / 255F, 237F / 255F, 1F); } }
            /// <summary>
            /// Solid Usuzakura (薄桜). RGBA is (253, 239, 242, 255).
            /// </summary>
            public static Color Usuzakura { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(253F / 255F, 239F / 255F, 242F / 255F, 1F); } }
            /// <summary>
            /// Solid Sakuranezumi (桜鼠). RGBA is (233, 223, 229, 255).
            /// </summary>
            public static Color Sakuranezumi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(233F / 255F, 223F / 255F, 229F / 255F, 1F); } }
            /// <summary>
            /// Solid Tokinezu (鴇鼠). RGBA is (228, 210, 216, 255).
            /// </summary>
            public static Color Tokinezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(228F / 255F, 210F / 255F, 216F / 255F, 1F); } }
            /// <summary>
            /// Solid Nijiiro (虹色). RGBA is (246, 191, 188, 255).
            /// </summary>
            public static Color Nijiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(246F / 255F, 191F / 255F, 188F / 255F, 1F); } }
            /// <summary>
            /// Solid Sangoiro (珊瑚色). RGBA is (255, 127, 80, 255).
            /// </summary>
            public static Color Sangoiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(255F / 255F, 127F / 255F, 80F / 255F, 1F); } }
            /// <summary>
            /// Solid Ikkonzome (一斤染). RGBA is (255, 211, 228, 255).
            /// </summary>
            public static Color Ikkonzome { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(255F / 255F, 211F / 255F, 228F / 255F, 1F); } }
            /// <summary>
            /// Solid Shishiiro (宍色). RGBA is (239, 171, 147, 255).
            /// </summary>
            public static Color Shishiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(239F / 255F, 171F / 255F, 147F / 255F, 1F); } }
            /// <summary>
            /// Solid Kobaiiro (紅梅色). RGBA is (232, 107, 121, 255).
            /// </summary>
            public static Color Kobaiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(232F / 255F, 107F / 255F, 121F / 255F, 1F); } }
            /// <summary>
            /// Solid Usukurenai (薄紅). RGBA is (177, 92, 101, 255).
            /// </summary>
            public static Color Usukurenai { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(177F / 255F, 92F / 255F, 101F / 255F, 1F); } }
            /// <summary>
            /// Solid Jinzamomi (甚三紅). RGBA is (238, 130, 124, 255).
            /// </summary>
            public static Color Jinzamomi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(238F / 255F, 130F / 255F, 124F / 255F, 1F); } }
            /// <summary>
            /// Solid Momoiro (桃色). RGBA is (245, 143, 152, 255).
            /// </summary>
            public static Color Momoiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(245F / 255F, 143F / 255F, 152F / 255F, 1F); } }
            /// <summary>
            /// Solid Tokiiro (鴇色). RGBA is (249, 161, 208, 255).
            /// </summary>
            public static Color Tokiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(249F / 255F, 161F / 255F, 208F / 255F, 1F); } }
            /// <summary>
            /// Solid Nadeshikoiro (撫子色). RGBA is (246, 173, 198, 255).
            /// </summary>
            public static Color Nadeshikoiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(246F / 255F, 173F / 255F, 198F / 255F, 1F); } }
            /// <summary>
            /// Solid Haiume (灰梅). RGBA is (232, 211, 199, 255).
            /// </summary>
            public static Color Haiume { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(232F / 255F, 211F / 255F, 199F / 255F, 1F); } }
            /// <summary>
            /// Solid Haizakura (灰桜). RGBA is (232, 211, 209, 255).
            /// </summary>
            public static Color Haizakura { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(232F / 255F, 211F / 255F, 209F / 255F, 1F); } }
            /// <summary>
            /// Solid Usubenifuji (淡紅藤). RGBA is (230, 205, 227, 255).
            /// </summary>
            public static Color Usubenifuji { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(230F / 255F, 205F / 255F, 227F / 255F, 1F); } }
            /// <summary>
            /// Solid Sekichikuiro (石竹色). RGBA is (249, 193, 207, 255).
            /// </summary>
            public static Color Sekichikuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(249F / 255F, 193F / 255F, 207F / 255F, 1F); } }
            /// <summary>
            /// Solid Usukobai (薄紅梅). RGBA is (229, 151, 178, 255).
            /// </summary>
            public static Color Usukobai { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(229F / 255F, 151F / 255F, 178F / 255F, 1F); } }
            /// <summary>
            /// Solid Momohanairo (桃花色). RGBA is (225, 152, 180, 255).
            /// </summary>
            public static Color Momohanairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(225F / 255F, 152F / 255F, 180F / 255F, 1F); } }
            /// <summary>
            /// Solid Mizugaki (水柿). RGBA is (228, 171, 155, 255).
            /// </summary>
            public static Color Mizugaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(228F / 255F, 171F / 255F, 155F / 255F, 1F); } }
            /// <summary>
            /// Solid Tokigaracha (ときがら茶). RGBA is (224, 158, 135, 255).
            /// </summary>
            public static Color Tokigaracha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(224F / 255F, 158F / 255F, 135F / 255F, 1F); } }
            /// <summary>
            /// Solid Arazome (退紅). RGBA is (214, 144, 144, 255).
            /// </summary>
            public static Color Arazome { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(214F / 255F, 144F / 255F, 144F / 255F, 1F); } }
            /// <summary>
            /// Solid Usugaki (薄柿). RGBA is (212, 172, 173, 255).
            /// </summary>
            public static Color Usugaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(212F / 255F, 172F / 255F, 173F / 255F, 1F); } }
            /// <summary>
            /// Solid Choushuniro (長春色). RGBA is (201, 117, 134, 255).
            /// </summary>
            public static Color Choushuniro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(201F / 255F, 117F / 255F, 134F / 255F, 1F); } }
            /// <summary>
            /// Solid Umenezumi (梅鼠). RGBA is (173, 121, 132, 255).
            /// </summary>
            public static Color Umenezumi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(173F / 255F, 121F / 255F, 132F / 255F, 1F); } }
            /// <summary>
            /// Solid Tokiasagi (鴇浅葱). RGBA is (184, 136, 132, 255).
            /// </summary>
            public static Color Tokiasagi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(184F / 255F, 136F / 255F, 132F / 255F, 1F); } }
            /// <summary>
            /// Solid Umezome (梅染). RGBA is (180, 138, 118, 255).
            /// </summary>
            public static Color Umezome { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(180F / 255F, 138F / 255F, 118F / 255F, 1F); } }
            /// <summary>
            /// Solid Suoko (蘇芳香). RGBA is (168, 105, 101, 255).
            /// </summary>
            public static Color Suoko { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(168F / 255F, 105F / 255F, 101F / 255F, 1F); } }
            /// <summary>
            /// Solid Asasuou (浅蘇芳). RGBA is (162, 87, 104, 255).
            /// </summary>
            public static Color Asasuou { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(162F / 255F, 87F / 255F, 104F / 255F, 1F); } }
            /// <summary>
            /// Solid Masoo (真朱). RGBA is (236, 109, 113, 255).
            /// </summary>
            public static Color Masoo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(236F / 255F, 109F / 255F, 113F / 255F, 1F); } }
            /// <summary>
            /// Solid Akamurasaki (赤紫). RGBA is (235, 110, 165, 255).
            /// </summary>
            public static Color Akamurasaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(235F / 255F, 110F / 255F, 165F / 255F, 1F); } }
            /// <summary>
            /// Solid Tsutsujiiro (躑躅色). RGBA is (231, 97, 164, 255).
            /// </summary>
            public static Color Tsutsujiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(231F / 255F, 97F / 255F, 164F / 255F, 1F); } }
            /// <summary>
            /// Solid Botaniro (牡丹色). RGBA is (231, 97, 164, 255).
            /// </summary>
            public static Color Botaniro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(231F / 255F, 97F / 255F, 164F / 255F, 1F); } }
            /// <summary>
            /// Solid Imayouiro (今様色). RGBA is (208, 87, 107, 255).
            /// </summary>
            public static Color Imayouiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(208F / 255F, 87F / 255F, 107F / 255F, 1F); } }
            /// <summary>
            /// Solid Nakabeni (中紅). RGBA is (200, 81, 121, 255).
            /// </summary>
            public static Color Nakabeni { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(200F / 255F, 81F / 255F, 121F / 255F, 1F); } }
            /// <summary>
            /// Solid Barairo (薔薇色). RGBA is (231, 50, 117, 255).
            /// </summary>
            public static Color Barairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(231F / 255F, 50F / 255F, 117F / 255F, 1F); } }
            /// <summary>
            /// Solid Karakurenai (韓紅). RGBA is (217, 52, 72, 255).
            /// </summary>
            public static Color Karakurenai { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(217F / 255F, 52F / 255F, 72F / 255F, 1F); } }
            /// <summary>
            /// Solid Ginshu (銀朱). RGBA is (242, 107, 73, 255).
            /// </summary>
            public static Color Ginshu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(242F / 255F, 107F / 255F, 73F / 255F, 1F); } }
            /// <summary>
            /// Solid Akabeni (赤紅). RGBA is (197, 61, 67, 255).
            /// </summary>
            public static Color Akabeni { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(197F / 255F, 61F / 255F, 67F / 255F, 1F); } }
            /// <summary>
            /// Solid Benihi (紅緋). RGBA is (232, 57, 40, 255).
            /// </summary>
            public static Color Benihi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(232F / 255F, 57F / 255F, 40F / 255F, 1F); } }
            /// <summary>
            /// Solid Aka (赤). RGBA is (237, 26, 61, 255).
            /// </summary>
            public static Color Aka { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(237F / 255F, 26F / 255F, 61F / 255F, 1F); } }
            /// <summary>
            /// Solid Shoujouhi (猩々緋). RGBA is (206, 49, 61, 255).
            /// </summary>
            public static Color Shoujouhi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(206F / 255F, 49F / 255F, 61F / 255F, 1F); } }
            /// <summary>
            /// Solid Kurenai (紅). RGBA is (194, 32, 71, 255).
            /// </summary>
            public static Color Kurenai { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(194F / 255F, 32F / 255F, 71F / 255F, 1F); } }
            /// <summary>
            /// Solid Kokihi (深緋). RGBA is (201, 23, 30, 255).
            /// </summary>
            public static Color Kokihi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(201F / 255F, 23F / 255F, 30F / 255F, 1F); } }
            /// <summary>
            /// Solid Hiiro (緋色). RGBA is (229, 72, 72, 255).
            /// </summary>
            public static Color Hiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(229F / 255F, 72F / 255F, 72F / 255F, 1F); } }
            /// <summary>
            /// Solid Akani (赤丹). RGBA is (206, 82, 66, 255).
            /// </summary>
            public static Color Akani { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(206F / 255F, 82F / 255F, 66F / 255F, 1F); } }
            /// <summary>
            /// Solid Beniaka (紅赤). RGBA is (229, 0, 79, 255).
            /// </summary>
            public static Color Beniaka { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(229F / 255F, 0F / 255F, 79F / 255F, 1F); } }
            /// <summary>
            /// Solid Enji (臙脂). RGBA is (179, 66, 74, 255).
            /// </summary>
            public static Color Enji { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(179F / 255F, 66F / 255F, 74F / 255F, 1F); } }
            /// <summary>
            /// Solid Ake (朱・緋). RGBA is (186, 38, 54, 255).
            /// </summary>
            public static Color Ake { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(186F / 255F, 38F / 255F, 54F / 255F, 1F); } }
            /// <summary>
            /// Solid Akaneiro (茜色). RGBA is (177, 53, 70, 255).
            /// </summary>
            public static Color Akaneiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(177F / 255F, 53F / 255F, 70F / 255F, 1F); } }
            /// <summary>
            /// Solid Beniebicha (紅海老茶). RGBA is (167, 56, 54, 255).
            /// </summary>
            public static Color Beniebicha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(167F / 255F, 56F / 255F, 54F / 255F, 1F); } }
            /// <summary>
            /// Solid Suou (蘇芳). RGBA is (151, 60, 63, 255).
            /// </summary>
            public static Color Suou { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(151F / 255F, 60F / 255F, 63F / 255F, 1F); } }
            /// <summary>
            /// Solid Shinku (真紅). RGBA is (177, 6, 58, 255).
            /// </summary>
            public static Color Shinku { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(177F / 255F, 6F / 255F, 58F / 255F, 1F); } }
            /// <summary>
            /// Solid Koikurenai (濃紅). RGBA is (162, 32, 65, 255).
            /// </summary>
            public static Color Koikurenai { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(162F / 255F, 32F / 255F, 65F / 255F, 1F); } }
            /// <summary>
            /// Solid Shinonomeiro (東雲色). RGBA is (241, 144, 114, 255).
            /// </summary>
            public static Color Shinonomeiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(241F / 255F, 144F / 255F, 114F / 255F, 1F); } }
            /// <summary>
            /// Solid Akebonoiro (曙色). RGBA is (241, 144, 114, 255).
            /// </summary>
            public static Color Akebonoiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(241F / 255F, 144F / 255F, 114F / 255F, 1F); } }
            /// <summary>
            /// Solid Sangoshuiro (珊瑚朱色). RGBA is (238, 131, 111, 255).
            /// </summary>
            public static Color Sangoshuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(238F / 255F, 131F / 255F, 111F / 255F, 1F); } }
            /// <summary>
            /// Solid Kokikuchinashi (深支子). RGBA is (235, 155, 111, 255).
            /// </summary>
            public static Color Kokikuchinashi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(235F / 255F, 155F / 255F, 111F / 255F, 1F); } }
            /// <summary>
            /// Solid Sohi (纁). RGBA is (224, 129, 94, 255).
            /// </summary>
            public static Color Sohi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(224F / 255F, 129F / 255F, 94F / 255F, 1F); } }
            /// <summary>
            /// Solid Usukihi (浅緋). RGBA is (223, 113, 99, 255).
            /// </summary>
            public static Color Usukihi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(223F / 255F, 113F / 255F, 99F / 255F, 1F); } }
            /// <summary>
            /// Solid Masoho (真赭). RGBA is (213, 124, 107, 255).
            /// </summary>
            public static Color Masoho { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(213F / 255F, 124F / 255F, 107F / 255F, 1F); } }
            /// <summary>
            /// Solid Araishu (洗朱). RGBA is (208, 130, 108, 255).
            /// </summary>
            public static Color Araishu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(208F / 255F, 130F / 255F, 108F / 255F, 1F); } }
            /// <summary>
            /// Solid Benikabairo (紅樺色). RGBA is (187, 85, 72, 255).
            /// </summary>
            public static Color Benikabairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(187F / 255F, 85F / 255F, 72F / 255F, 1F); } }
            /// <summary>
            /// Solid Awabenifuji (淡紅藤). RGBA is (230, 205, 227, 255).
            /// </summary>
            public static Color Awabenifuji { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(230F / 255F, 205F / 255F, 227F / 255F, 1F); } }
        }

        /// <summary>
        /// Shades of yellow.
        /// </summary>
        public static class YellowFamily
        {
            /// <summary>
            /// Solid Zougeiro (象牙色). RGBA is (248, 244, 230, 255).
            /// </summary>
            public static Color Zougeiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(248F / 255F, 244F / 255F, 230F / 255F, 1F); } }
            /// <summary>
            /// Solid Neriiro (練色). RGBA is (237, 228, 205, 255).
            /// </summary>
            public static Color Neriiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(237F / 255F, 228F / 255F, 205F / 255F, 1F); } }
            /// <summary>
            /// Solid Kaihakushoku (灰白色). RGBA is (233, 228, 212, 255).
            /// </summary>
            public static Color Kaihakushoku { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(233F / 255F, 228F / 255F, 212F / 255F, 1F); } }
            /// <summary>
            /// Solid Mushiguriiro (蒸栗色). RGBA is (235, 225, 169, 255).
            /// </summary>
            public static Color Mushiguriiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(235F / 255F, 225F / 255F, 169F / 255F, 1F); } }
            /// <summary>
            /// Solid Ominaeshi (女郎花). RGBA is (242, 242, 176, 255).
            /// </summary>
            public static Color Ominaeshi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(242F / 255F, 242F / 255F, 176F / 255F, 1F); } }
            /// <summary>
            /// Solid Karekusairo (枯草色). RGBA is (228, 220, 138, 255).
            /// </summary>
            public static Color Karekusairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(228F / 255F, 220F / 255F, 138F / 255F, 1F); } }
            /// <summary>
            /// Solid Tankou (淡黄). RGBA is (248, 229, 140, 255).
            /// </summary>
            public static Color Tankou { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(248F / 255F, 229F / 255F, 140F / 255F, 1F); } }
            /// <summary>
            /// Solid Torinokoiro (鳥の子色). RGBA is (255, 241, 207, 255).
            /// </summary>
            public static Color Torinokoiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(255F / 255F, 241F / 255F, 207F / 255F, 1F); } }
            /// <summary>
            /// Solid Hachimitsuiro (蜂蜜色). RGBA is (253, 222, 165, 255).
            /// </summary>
            public static Color Hachimitsuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(253F / 255F, 222F / 255F, 165F / 255F, 1F); } }
            /// <summary>
            /// Solid Hadairo (肌色). RGBA is (252, 226, 196, 255).
            /// </summary>
            public static Color Hadairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(252F / 255F, 226F / 255F, 196F / 255F, 1F); } }
            /// <summary>
            /// Solid Usutamagoiro (薄卵色). RGBA is (253, 232, 208, 255).
            /// </summary>
            public static Color Usutamagoiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(253F / 255F, 232F / 255F, 208F / 255F, 1F); } }
            /// <summary>
            /// Solid Yuuou (雄黄). RGBA is (249, 200, 155, 255).
            /// </summary>
            public static Color Yuuou { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(249F / 255F, 200F / 255F, 155F / 255F, 1F); } }
            /// <summary>
            /// Solid Sharegaki (洒落柿). RGBA is (247, 189, 143, 255).
            /// </summary>
            public static Color Sharegaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(247F / 255F, 189F / 255F, 143F / 255F, 1F); } }
            /// <summary>
            /// Solid Akakou (赤香). RGBA is (246, 184, 148, 255).
            /// </summary>
            public static Color Akakou { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(246F / 255F, 184F / 255F, 148F / 255F, 1F); } }
            /// <summary>
            /// Solid Tonokoiro (砥粉色). RGBA is (244, 221, 165, 255).
            /// </summary>
            public static Color Tonokoiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(244F / 255F, 221F / 255F, 165F / 255F, 1F); } }
            /// <summary>
            /// Solid Choujiiro (丁子色). RGBA is (239, 205, 154, 255).
            /// </summary>
            public static Color Choujiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(239F / 255F, 205F / 255F, 154F / 255F, 1F); } }
            /// <summary>
            /// Solid Kouiro (香色). RGBA is (239, 205, 154, 255).
            /// </summary>
            public static Color Kouiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(239F / 255F, 205F / 255F, 154F / 255F, 1F); } }
            /// <summary>
            /// Solid Usukou (薄香). RGBA is (240, 207, 160, 255).
            /// </summary>
            public static Color Usukou { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(240F / 255F, 207F / 255F, 160F / 255F, 1F); } }
            /// <summary>
            /// Solid Usuki (浅黄). RGBA is (237, 211, 161, 255).
            /// </summary>
            public static Color Usuki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(237F / 255F, 211F / 255F, 161F / 255F, 1F); } }
            /// <summary>
            /// Solid Kareiro (枯色). RGBA is (224, 195, 140, 255).
            /// </summary>
            public static Color Kareiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(224F / 255F, 195F / 255F, 140F / 255F, 1F); } }
            /// <summary>
            /// Solid Tanpopoiro (蒲公英色). RGBA is (255, 217, 0, 255).
            /// </summary>
            public static Color Tanpopoiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(255F / 255F, 217F / 255F, 0F / 255F, 1F); } }
            /// <summary>
            /// Solid Kiiro (黄色). RGBA is (255, 217, 0, 255).
            /// </summary>
            public static Color Kiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(255F / 255F, 217F / 255F, 0F / 255F, 1F); } }
            /// <summary>
            /// Solid Chuuki (中黄). RGBA is (255, 234, 0, 255).
            /// </summary>
            public static Color Chuuki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(255F / 255F, 234F / 255F, 0F / 255F, 1F); } }
            /// <summary>
            /// Solid Nanohanairo (菜の花色). RGBA is (255, 236, 71, 255).
            /// </summary>
            public static Color Nanohanairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(255F / 255F, 236F / 255F, 71F / 255F, 1F); } }
            /// <summary>
            /// Solid Kihadairo (黄檗色). RGBA is (254, 242, 99, 255).
            /// </summary>
            public static Color Kihadairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(254F / 255F, 242F / 255F, 99F / 255F, 1F); } }
            /// <summary>
            /// Solid Tamagoiro (卵色). RGBA is (252, 213, 117, 255).
            /// </summary>
            public static Color Tamagoiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(252F / 255F, 213F / 255F, 117F / 255F, 1F); } }
            /// <summary>
            /// Solid Hanabairo (花葉色). RGBA is (251, 210, 107, 255).
            /// </summary>
            public static Color Hanabairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(251F / 255F, 210F / 255F, 107F / 255F, 1F); } }
            /// <summary>
            /// Solid Kariyasuiro (刈安色). RGBA is (245, 229, 107, 255).
            /// </summary>
            public static Color Kariyasuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(245F / 255F, 229F / 255F, 107F / 255F, 1F); } }
            /// <summary>
            /// Solid Toumorokoshiiro (玉蜀黍色). RGBA is (238, 195, 98, 255).
            /// </summary>
            public static Color Toumorokoshiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(238F / 255F, 195F / 255F, 98F / 255F, 1F); } }
            /// <summary>
            /// Solid Kanariairo (金糸雀色). RGBA is (235, 216, 66, 255).
            /// </summary>
            public static Color Kanariairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(235F / 255F, 216F / 255F, 66F / 255F, 1F); } }
            /// <summary>
            /// Solid Kikuchinashiiro (黄支子色). RGBA is (255, 219, 79, 255).
            /// </summary>
            public static Color Kikuchinashiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(255F / 255F, 219F / 255F, 79F / 255F, 1F); } }
            /// <summary>
            /// Solid Kuchinashiiro (支子色). RGBA is (251, 202, 77, 255).
            /// </summary>
            public static Color Kuchinashiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(251F / 255F, 202F / 255F, 77F / 255F, 1F); } }
            /// <summary>
            /// Solid Himawariiro (向日葵色). RGBA is (252, 200, 0, 255).
            /// </summary>
            public static Color Himawariiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(252F / 255F, 200F / 255F, 0F / 255F, 1F); } }
            /// <summary>
            /// Solid Yamabukiiro (山吹色). RGBA is (248, 181, 0, 255).
            /// </summary>
            public static Color Yamabukiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(248F / 255F, 181F / 255F, 0F / 255F, 1F); } }
            /// <summary>
            /// Solid Ukoniro (鬱金色). RGBA is (250, 191, 20, 255).
            /// </summary>
            public static Color Ukoniro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(250F / 255F, 191F / 255F, 20F / 255F, 1F); } }
            /// <summary>
            /// Solid Touou (藤黄). RGBA is (247, 193, 20, 255).
            /// </summary>
            public static Color Touou { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(247F / 255F, 193F / 255F, 20F / 255F, 1F); } }
            /// <summary>
            /// Solid Konjiki (金色). RGBA is (230, 180, 34, 255).
            /// </summary>
            public static Color Konjiki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(230F / 255F, 180F / 255F, 34F / 255F, 1F); } }
            /// <summary>
            /// Solid Kogane (黄金). RGBA is (230, 180, 34, 255).
            /// </summary>
            public static Color Kogane { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(230F / 255F, 180F / 255F, 34F / 255F, 1F); } }
            /// <summary>
            /// Solid Hajizome (櫨染). RGBA is (217, 166, 46, 255).
            /// </summary>
            public static Color Hajizome { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(217F / 255F, 166F / 255F, 46F / 255F, 1F); } }
            /// <summary>
            /// Solid Kikuchibairo (黄朽葉色). RGBA is (211, 162, 67, 255).
            /// </summary>
            public static Color Kikuchibairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(211F / 255F, 162F / 255F, 67F / 255F, 1F); } }
            /// <summary>
            /// Solid Yamabukicha (山吹茶). RGBA is (200, 153, 50, 255).
            /// </summary>
            public static Color Yamabukicha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(200F / 255F, 153F / 255F, 50F / 255F, 1F); } }
            /// <summary>
            /// Solid Karashiiro (芥子色). RGBA is (208, 175, 76, 255).
            /// </summary>
            public static Color Karashiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(208F / 255F, 175F / 255F, 76F / 255F, 1F); } }
        }

        /// <summary>
        /// Shades of orange.
        /// </summary>
        public static class OrangeFamily
        {
            /// <summary>
            /// Solid Nikuiro (肉色). RGBA is (241, 191, 153, 255).
            /// </summary>
            public static Color Nikuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(241F / 255F, 191F / 255F, 153F / 255F, 1F); } }
            /// <summary>
            /// Solid Hitoiro (人色). RGBA is (241, 191, 153, 255).
            /// </summary>
            public static Color Hitoiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(241F / 255F, 191F / 255F, 153F / 255F, 1F); } }
            /// <summary>
            /// Solid Usukou (淡香). RGBA is (243, 191, 136, 255).
            /// </summary>
            public static Color Usukou { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(243F / 255F, 191F / 255F, 136F / 255F, 1F); } }
            /// <summary>
            /// Solid Anzuiro (杏色). RGBA is (247, 185, 119, 255).
            /// </summary>
            public static Color Anzuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(247F / 255F, 185F / 255F, 119F / 255F, 1F); } }
            /// <summary>
            /// Solid Kanzouiro (萱草色). RGBA is (248, 184, 98, 255).
            /// </summary>
            public static Color Kanzouiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(248F / 255F, 184F / 255F, 98F / 255F, 1F); } }
            /// <summary>
            /// Solid Koujiiro (柑子色). RGBA is (246, 173, 73, 255).
            /// </summary>
            public static Color Koujiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(246F / 255F, 173F / 255F, 73F / 255F, 1F); } }
            /// <summary>
            /// Solid Kincha (金茶). RGBA is (243, 152, 0, 255).
            /// </summary>
            public static Color Kincha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(243F / 255F, 152F / 255F, 0F / 255F, 1F); } }
            /// <summary>
            /// Solid Mikaniro (蜜柑色). RGBA is (240, 131, 0, 255).
            /// </summary>
            public static Color Mikaniro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(240F / 255F, 131F / 255F, 0F / 255F, 1F); } }
            /// <summary>
            /// Solid Entaniro (鉛丹色). RGBA is (236, 109, 81, 255).
            /// </summary>
            public static Color Entaniro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(236F / 255F, 109F / 255F, 81F / 255F, 1F); } }
            /// <summary>
            /// Solid Ouni (黄丹). RGBA is (238, 121, 72, 255).
            /// </summary>
            public static Color Ouni { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(238F / 255F, 121F / 255F, 72F / 255F, 1F); } }
            /// <summary>
            /// Solid Kakiiro (柿色). RGBA is (237, 109, 61, 255).
            /// </summary>
            public static Color Kakiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(237F / 255F, 109F / 255F, 61F / 255F, 1F); } }
            /// <summary>
            /// Solid Kiaka (黄赤). RGBA is (236, 104, 0, 255).
            /// </summary>
            public static Color Kiaka { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(236F / 255F, 104F / 255F, 0F / 255F, 1F); } }
            /// <summary>
            /// Solid Ninjiniro (人参色). RGBA is (236, 104, 0, 255).
            /// </summary>
            public static Color Ninjiniro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(236F / 255F, 104F / 255F, 0F / 255F, 1F); } }
            /// <summary>
            /// Solid Daidaiiro (橙色). RGBA is (238, 120, 0, 255).
            /// </summary>
            public static Color Daidaiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(238F / 255F, 120F / 255F, 0F / 255F, 1F); } }
            /// <summary>
            /// Solid Terigaki (照柿). RGBA is (235, 98, 56, 255).
            /// </summary>
            public static Color Terigaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(235F / 255F, 98F / 255F, 56F / 255F, 1F); } }
            /// <summary>
            /// Solid Akadaidai (赤橙). RGBA is (234, 85, 6, 255).
            /// </summary>
            public static Color Akadaidai { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(234F / 255F, 85F / 255F, 6F / 255F, 1F); } }
            /// <summary>
            /// Solid Kinaka (金赤). RGBA is (234, 85, 6, 255).
            /// </summary>
            public static Color Kinaka { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(234F / 255F, 85F / 255F, 6F / 255F, 1F); } }
            /// <summary>
            /// Solid Shuiro (朱色). RGBA is (235, 97, 1, 255).
            /// </summary>
            public static Color Shuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(235F / 255F, 97F / 255F, 1F / 255F, 1F); } }
            /// <summary>
            /// Solid Komugiiro (小麦色). RGBA is (228, 158, 97, 255).
            /// </summary>
            public static Color Komugiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(228F / 255F, 158F / 255F, 97F / 255F, 1F); } }
            /// <summary>
            /// Solid Niiro (丹色). RGBA is (228, 94, 50, 255).
            /// </summary>
            public static Color Niiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(228F / 255F, 94F / 255F, 50F / 255F, 1F); } }
            /// <summary>
            /// Solid Kicha (黄茶). RGBA is (225, 123, 52, 255).
            /// </summary>
            public static Color Kicha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(225F / 255F, 123F / 255F, 52F / 255F, 1F); } }
            /// <summary>
            /// Solid Nikkeiiro (肉桂色). RGBA is (221, 122, 86, 255).
            /// </summary>
            public static Color Nikkeiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(221F / 255F, 122F / 255F, 86F / 255F, 1F); } }
            /// <summary>
            /// Solid Akakuchibairo (赤朽葉色). RGBA is (219, 132, 73, 255).
            /// </summary>
            public static Color Akakuchibairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(219F / 255F, 132F / 255F, 73F / 255F, 1F); } }
            /// <summary>
            /// Solid Kourozen (黄櫨染). RGBA is (214, 106, 53, 255).
            /// </summary>
            public static Color Kourozen { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(214F / 255F, 106F / 255F, 53F / 255F, 1F); } }
        }

        /// <summary>
        /// Shades of green.
        /// </summary>
        public static class GreenFamily
        {
            /// <summary>
            /// Solid Mamegaracha (豆がら茶). RGBA is (139, 150, 141, 255).
            /// </summary>
            public static Color Mamegaracha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(139F / 255F, 150F / 255F, 141F / 255F, 1F); } }
            /// <summary>
            /// Solid Kikujin (麹塵). RGBA is (110, 121, 85, 255).
            /// </summary>
            public static Color Kikujin { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(110F / 255F, 121F / 255F, 85F / 255F, 1F); } }
            /// <summary>
            /// Solid Yamabatoiro (山鳩色). RGBA is (118, 124, 107, 255).
            /// </summary>
            public static Color Yamabatoiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(118F / 255F, 124F / 255F, 107F / 255F, 1F); } }
            /// <summary>
            /// Solid Rikyuunezumi (利休鼠). RGBA is (136, 142, 126, 255).
            /// </summary>
            public static Color Rikyuunezumi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(136F / 255F, 142F / 255F, 126F / 255F, 1F); } }
            /// <summary>
            /// Solid Mirucha (海松茶). RGBA is (90, 84, 75, 255).
            /// </summary>
            public static Color Mirucha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(90F / 255F, 84F / 255F, 75F / 255F, 1F); } }
            /// <summary>
            /// Solid Aimirucha (藍海松茶). RGBA is (86, 86, 75, 255).
            /// </summary>
            public static Color Aimirucha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(86F / 255F, 86F / 255F, 75F / 255F, 1F); } }
            /// <summary>
            /// Solid Aikobicha (藍媚茶). RGBA is (85, 86, 71, 255).
            /// </summary>
            public static Color Aikobicha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(85F / 255F, 86F / 255F, 71F / 255F, 1F); } }
            /// <summary>
            /// Solid Sensaicha (千歳茶). RGBA is (73, 74, 65, 255).
            /// </summary>
            public static Color Sensaicha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(73F / 255F, 74F / 255F, 65F / 255F, 1F); } }
            /// <summary>
            /// Solid Iwaicha (岩井茶). RGBA is (107, 111, 89, 255).
            /// </summary>
            public static Color Iwaicha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(107F / 255F, 111F / 255F, 89F / 255F, 1F); } }
            /// <summary>
            /// Solid Sensaicha (仙斎茶). RGBA is (71, 75, 66, 255).
            /// </summary>
            public static Color SensaichaDeepGreen { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(71F / 255F, 75F / 255F, 66F / 255F, 1F); } }
            /// <summary>
            /// Solid Kuromidori (黒緑). RGBA is (51, 54, 49, 255).
            /// </summary>
            public static Color Kuromidori { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(51F / 255F, 54F / 255F, 49F / 255F, 1F); } }
            /// <summary>
            /// Solid Yanagisusutake (柳煤竹). RGBA is (91, 99, 86, 255).
            /// </summary>
            public static Color Yanagisusutake { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(91F / 255F, 99F / 255F, 86F / 255F, 1F); } }
            /// <summary>
            /// Solid Rikyuucha (利休茶). RGBA is (165, 149, 100, 255).
            /// </summary>
            public static Color Rikyuucha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(165F / 255F, 149F / 255F, 100F / 255F, 1F); } }
            /// <summary>
            /// Solid Uguisucha (鶯茶). RGBA is (113, 92, 31, 255).
            /// </summary>
            public static Color Uguisucha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(113F / 255F, 92F / 255F, 31F / 255F, 1F); } }
            /// <summary>
            /// Solid Mokuranjiki (木蘭色). RGBA is (199, 179, 112, 255).
            /// </summary>
            public static Color Mokuranjiki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(199F / 255F, 179F / 255F, 112F / 255F, 1F); } }
            /// <summary>
            /// Solid Aburairo (油色). RGBA is (161, 147, 97, 255).
            /// </summary>
            public static Color Aburairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(161F / 255F, 147F / 255F, 97F / 255F, 1F); } }
            /// <summary>
            /// Solid Rikyuuiro (利休色). RGBA is (143, 134, 103, 255).
            /// </summary>
            public static Color Rikyuuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(143F / 255F, 134F / 255F, 103F / 255F, 1F); } }
            /// <summary>
            /// Solid Baikoucha (梅幸茶). RGBA is (136, 121, 56, 255).
            /// </summary>
            public static Color Baikoucha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(136F / 255F, 121F / 255F, 56F / 255F, 1F); } }
            /// <summary>
            /// Solid Rikancha (璃寛茶). RGBA is (106, 93, 33, 255).
            /// </summary>
            public static Color Rikancha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(106F / 255F, 93F / 255F, 33F / 255F, 1F); } }
            /// <summary>
            /// Solid Kimirucha (黄海松茶). RGBA is (145, 135, 84, 255).
            /// </summary>
            public static Color Kimirucha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(145F / 255F, 135F / 255F, 84F / 255F, 1F); } }
            /// <summary>
            /// Solid Nataneyuiro (菜種油色). RGBA is (166, 148, 37, 255).
            /// </summary>
            public static Color Nataneyuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(166F / 255F, 148F / 255F, 37F / 255F, 1F); } }
            /// <summary>
            /// Solid Aokuchiba (青朽葉). RGBA is (173, 162, 80, 255).
            /// </summary>
            public static Color Aokuchiba { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(173F / 255F, 162F / 255F, 80F / 255F, 1F); } }
            /// <summary>
            /// Solid Negishiiro (根岸色). RGBA is (147, 139, 75, 255).
            /// </summary>
            public static Color Negishiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(147F / 255F, 139F / 255F, 75F / 255F, 1F); } }
            /// <summary>
            /// Solid Hiwacha (鶸茶). RGBA is (140, 136, 97, 255).
            /// </summary>
            public static Color Hiwacha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(140F / 255F, 136F / 255F, 97F / 255F, 1F); } }
            /// <summary>
            /// Solid Yanagicha (柳茶). RGBA is (161, 164, 109, 255).
            /// </summary>
            public static Color Yanagicha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(161F / 255F, 164F / 255F, 109F / 255F, 1F); } }
            /// <summary>
            /// Solid Miruiro (海松色). RGBA is (114, 109, 64, 255).
            /// </summary>
            public static Color Miruiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(114F / 255F, 109F / 255F, 64F / 255F, 1F); } }
            /// <summary>
            /// Solid Uguisuiro (鶯色). RGBA is (146, 140, 54, 255).
            /// </summary>
            public static Color Uguisuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(146F / 255F, 140F / 255F, 54F / 255F, 1F); } }
            /// <summary>
            /// Solid Ryokuoushoku (緑黄色). RGBA is (220, 203, 24, 255).
            /// </summary>
            public static Color Ryokuoushoku { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(220F / 255F, 203F / 255F, 24F / 255F, 1F); } }
            /// <summary>
            /// Solid Hiwairo (鶸色). RGBA is (215, 207, 58, 255).
            /// </summary>
            public static Color Hiwairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(215F / 255F, 207F / 255F, 58F / 255F, 1F); } }
            /// <summary>
            /// Solid Matchairo (抹茶色). RGBA is (197, 197, 106, 255).
            /// </summary>
            public static Color Matchairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(197F / 255F, 197F / 255F, 106F / 255F, 1F); } }
            /// <summary>
            /// Solid Wakakusairo (若草色). RGBA is (195, 216, 37, 255).
            /// </summary>
            public static Color Wakakusairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(195F / 255F, 216F / 255F, 37F / 255F, 1F); } }
            /// <summary>
            /// Solid Kimidori (黄緑). RGBA is (184, 210, 0, 255).
            /// </summary>
            public static Color Kimidori { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(184F / 255F, 210F / 255F, 0F / 255F, 1F); } }
            /// <summary>
            /// Solid Wakameiro (若芽色). RGBA is (224, 235, 175, 255).
            /// </summary>
            public static Color Wakameiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(224F / 255F, 235F / 255F, 175F / 255F, 1F); } }
            /// <summary>
            /// Solid Wakanairo (若菜色). RGBA is (216, 230, 152, 255).
            /// </summary>
            public static Color Wakanairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(216F / 255F, 230F / 255F, 152F / 255F, 1F); } }
            /// <summary>
            /// Solid Wakanaeiro (若苗色). RGBA is (199, 220, 104, 255).
            /// </summary>
            public static Color Wakanaeiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(199F / 255F, 220F / 255F, 104F / 255F, 1F); } }
            /// <summary>
            /// Solid Aoni (青丹). RGBA is (153, 171, 78, 255).
            /// </summary>
            public static Color Aoni { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(153F / 255F, 171F / 255F, 78F / 255F, 1F); } }
            /// <summary>
            /// Solid Kusairo (草色). RGBA is (123, 141, 66, 255).
            /// </summary>
            public static Color Kusairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(123F / 255F, 141F / 255F, 66F / 255F, 1F); } }
            /// <summary>
            /// Solid Kokeiro (苔色). RGBA is (105, 130, 27, 255).
            /// </summary>
            public static Color Kokeiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(105F / 255F, 130F / 255F, 27F / 255F, 1F); } }
            /// <summary>
            /// Solid Moegi (萌黄). RGBA is (170, 207, 83, 255).
            /// </summary>
            public static Color Moegi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(170F / 255F, 207F / 255F, 83F / 255F, 1F); } }
            /// <summary>
            /// Solid Naeiro (苗色). RGBA is (176, 202, 113, 255).
            /// </summary>
            public static Color Naeiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(176F / 255F, 202F / 255F, 113F / 255F, 1F); } }
            /// <summary>
            /// Solid Wakabairo (若葉色). RGBA is (185, 208, 139, 255).
            /// </summary>
            public static Color Wakabairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(185F / 255F, 208F / 255F, 139F / 255F, 1F); } }
            /// <summary>
            /// Solid Matsubairo (松葉色). RGBA is (131, 155, 92, 255).
            /// </summary>
            public static Color Matsubairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(131F / 255F, 155F / 255F, 92F / 255F, 1F); } }
            /// <summary>
            /// Solid Natsumushiiro (夏虫色). RGBA is (206, 228, 174, 255).
            /// </summary>
            public static Color Natsumushiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(206F / 255F, 228F / 255F, 174F / 255F, 1F); } }
            /// <summary>
            /// Solid Hiwamoegi (鶸萌黄). RGBA is (130, 174, 70, 255).
            /// </summary>
            public static Color Hiwamoegi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(130F / 255F, 174F / 255F, 70F / 255F, 1F); } }
            /// <summary>
            /// Solid Yanagiiro (柳色). RGBA is (168, 201, 127, 255).
            /// </summary>
            public static Color Yanagiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(168F / 255F, 201F / 255F, 127F / 255F, 1F); } }
            /// <summary>
            /// Solid Aoshirotsurubami (青白橡). RGBA is (155, 168, 141, 255).
            /// </summary>
            public static Color Aoshirotsurubami { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(155F / 255F, 168F / 255F, 141F / 255F, 1F); } }
            /// <summary>
            /// Solid Yanaginezu (柳鼠). RGBA is (200, 213, 187, 255).
            /// </summary>
            public static Color Yanaginezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(200F / 255F, 213F / 255F, 187F / 255F, 1F); } }
            /// <summary>
            /// Solid Urahayanagi (裏葉柳). RGBA is (193, 216, 172, 255).
            /// </summary>
            public static Color Urahayanagi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(193F / 255F, 216F / 255F, 172F / 255F, 1F); } }
            /// <summary>
            /// Solid Wasabiiro (山葵色). RGBA is (168, 191, 147, 255).
            /// </summary>
            public static Color Wasabiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(168F / 255F, 191F / 255F, 147F / 255F, 1F); } }
            /// <summary>
            /// Solid Oitakeiro (老竹色). RGBA is (118, 145, 100, 255).
            /// </summary>
            public static Color Oitakeiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(118F / 255F, 145F / 255F, 100F / 255F, 1F); } }
            /// <summary>
            /// Solid Byakuroku (白緑). RGBA is (214, 233, 202, 255).
            /// </summary>
            public static Color Byakuroku { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(214F / 255F, 233F / 255F, 202F / 255F, 1F); } }
            /// <summary>
            /// Solid Usumoegi (淡萌黄). RGBA is (147, 202, 118, 255).
            /// </summary>
            public static Color UsumoegiDeepGreen { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(147F / 255F, 202F / 255F, 118F / 255F, 1F); } }
            /// <summary>
            /// Solid Yanagizome (柳染). RGBA is (147, 184, 129, 255).
            /// </summary>
            public static Color Yanagizome { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(147F / 255F, 184F / 255F, 129F / 255F, 1F); } }
            /// <summary>
            /// Solid Usumoegi (薄萌葱). RGBA is (186, 220, 173, 255).
            /// </summary>
            public static Color Usumoegi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(186F / 255F, 220F / 255F, 173F / 255F, 1F); } }
            /// <summary>
            /// Solid Fukagawanezumi (深川鼠). RGBA is (151, 167, 145, 255).
            /// </summary>
            public static Color Fukagawanezumi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(151F / 255F, 167F / 255F, 145F / 255F, 1F); } }
            /// <summary>
            /// Solid Wakamidori (若緑). RGBA is (152, 217, 142, 255).
            /// </summary>
            public static Color Wakamidori { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(152F / 255F, 217F / 255F, 142F / 255F, 1F); } }
            /// <summary>
            /// Solid Asamidori (浅緑). RGBA is (136, 203, 127, 255).
            /// </summary>
            public static Color Asamidori { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(136F / 255F, 203F / 255F, 127F / 255F, 1F); } }
            /// <summary>
            /// Solid Usumidori (薄緑). RGBA is (105, 176, 118, 255).
            /// </summary>
            public static Color Usumidori { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(105F / 255F, 176F / 255F, 118F / 255F, 1F); } }
            /// <summary>
            /// Solid Aonibi (青鈍). RGBA is (107, 123, 110, 255).
            /// </summary>
            public static Color Aonibi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(107F / 255F, 123F / 255F, 110F / 255F, 1F); } }
            /// <summary>
            /// Solid Seijinezu (青磁鼠). RGBA is (190, 210, 195, 255).
            /// </summary>
            public static Color Seijinezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(190F / 255F, 210F / 255F, 195F / 255F, 1F); } }
            /// <summary>
            /// Solid Usuao (薄青). RGBA is (147, 182, 156, 255).
            /// </summary>
            public static Color Usuao { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(147F / 255F, 182F / 255F, 156F / 255F, 1F); } }
            /// <summary>
            /// Solid Sabiseiji (錆青磁). RGBA is (166, 200, 178, 255).
            /// </summary>
            public static Color Sabiseiji { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(166F / 255F, 200F / 255F, 178F / 255F, 1F); } }
            /// <summary>
            /// Solid Rokushouiro (緑青色). RGBA is (71, 136, 94, 255).
            /// </summary>
            public static Color Rokushouiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(71F / 255F, 136F / 255F, 94F / 255F, 1F); } }
            /// <summary>
            /// Solid Chitosemidori (千歳緑). RGBA is (49, 103, 69, 255).
            /// </summary>
            public static Color Chitosemidori { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(49F / 255F, 103F / 255F, 69F / 255F, 1F); } }
            /// <summary>
            /// Solid Wakatakeiro (若竹色). RGBA is (104, 190, 141, 255).
            /// </summary>
            public static Color Wakatakeiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(104F / 255F, 190F / 255F, 141F / 255F, 1F); } }
            /// <summary>
            /// Solid Midori (緑). RGBA is (62, 179, 112, 255).
            /// </summary>
            public static Color Midori { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(62F / 255F, 179F / 255F, 112F / 255F, 1F); } }
            /// <summary>
            /// Solid Tokiwairo (常磐色). RGBA is (0, 123, 67, 255).
            /// </summary>
            public static Color Tokiwairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(0F / 255F, 123F / 255F, 67F / 255F, 1F); } }
            /// <summary>
            /// Solid Chigusanezu (千草鼠). RGBA is (190, 211, 202, 255).
            /// </summary>
            public static Color Chigusanezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(190F / 255F, 211F / 255F, 202F / 255F, 1F); } }
            /// <summary>
            /// Solid Chigusairo (千草色). RGBA is (146, 181, 169, 255).
            /// </summary>
            public static Color Chigusairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(146F / 255F, 181F / 255F, 169F / 255F, 1F); } }
            /// <summary>
            /// Solid Seijiiro (青磁色). RGBA is (126, 190, 165, 255).
            /// </summary>
            public static Color Seijiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(126F / 255F, 190F / 255F, 165F / 255F, 1F); } }
            /// <summary>
            /// Solid Aotakeiro (青竹色). RGBA is (126, 190, 171, 255).
            /// </summary>
            public static Color Aotakeiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(126F / 255F, 190F / 255F, 171F / 255F, 1F); } }
            /// <summary>
            /// Solid Tokiwamidori (常磐緑). RGBA is (2, 135, 96, 255).
            /// </summary>
            public static Color Tokiwamidori { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(2F / 255F, 135F / 255F, 96F / 255F, 1F); } }
            /// <summary>
            /// Solid Tokusairo (木賊色). RGBA is (59, 121, 96, 255).
            /// </summary>
            public static Color Tokusairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(59F / 255F, 121F / 255F, 96F / 255F, 1F); } }
            /// <summary>
            /// Solid Biroudo (天鵞絨). RGBA is (47, 93, 80, 255).
            /// </summary>
            public static Color Biroudo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(47F / 255F, 93F / 255F, 80F / 255F, 1F); } }
            /// <summary>
            /// Solid Mushiao (虫襖). RGBA is (58, 91, 82, 255).
            /// </summary>
            public static Color Mushiao { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(58F / 255F, 91F / 255F, 82F / 255F, 1F); } }
            /// <summary>
            /// Solid Kawairo (革色). RGBA is (71, 89, 80, 255).
            /// </summary>
            public static Color Kawairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(71F / 255F, 89F / 255F, 80F / 255F, 1F); } }
            /// <summary>
            /// Solid Fukamidori (深緑). RGBA is (0, 85, 46, 255).
            /// </summary>
            public static Color Fukamidori { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(0F / 255F, 85F / 255F, 46F / 255F, 1F); } }
            /// <summary>
            /// Solid Tetsuiro (鉄色). RGBA is (0, 82, 67, 255).
            /// </summary>
            public static Color Tetsuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(0F / 255F, 82F / 255F, 67F / 255F, 1F); } }
            /// <summary>
            /// Solid Moegiiro (萌葱色). RGBA is (0, 110, 84, 255).
            /// </summary>
            public static Color Moegiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(0F / 255F, 110F / 255F, 84F / 255F, 1F); } }
            /// <summary>
            /// Solid Hanarokushou (花緑青). RGBA is (0, 163, 129, 255).
            /// </summary>
            public static Color Hanarokushou { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(0F / 255F, 163F / 255F, 129F / 255F, 1F); } }
            /// <summary>
            /// Solid Hisuiiro (翡翠色). RGBA is (56, 180, 139, 255).
            /// </summary>
            public static Color Hisuiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(56F / 255F, 180F / 255F, 139F / 255F, 1F); } }
            /// <summary>
            /// Solid Aomidori (青緑). RGBA is (0, 164, 151, 255).
            /// </summary>
            public static Color Aomidori { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(0F / 255F, 164F / 255F, 151F / 255F, 1F); } }
            /// <summary>
            /// Solid Mizuasagi (水浅葱). RGBA is (128, 171, 169, 255).
            /// </summary>
            public static Color Mizuasagi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(128F / 255F, 171F / 255F, 169F / 255F, 1F); } }
            /// <summary>
            /// Solid Sabiasagi (錆浅葱). RGBA is (92, 146, 145, 255).
            /// </summary>
            public static Color Sabiasagi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(92F / 255F, 146F / 255F, 145F / 255F, 1F); } }
            /// <summary>
            /// Solid Seiheki (青碧). RGBA is (71, 131, 132, 255).
            /// </summary>
            public static Color Seiheki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(71F / 255F, 131F / 255F, 132F / 255F, 1F); } }
            /// <summary>
            /// Solid Omeshicha (御召茶). RGBA is (67, 103, 107, 255).
            /// </summary>
            public static Color Omeshicha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(67F / 255F, 103F / 255F, 107F / 255F, 1F); } }
            /// <summary>
            /// Solid Minatonezumi (湊鼠). RGBA is (128, 152, 155, 255).
            /// </summary>
            public static Color Minatonezumi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(128F / 255F, 152F / 255F, 155F / 255F, 1F); } }
            /// <summary>
            /// Solid Kourainando (高麗納戸). RGBA is (44, 79, 84, 255).
            /// </summary>
            public static Color Kourainando { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(44F / 255F, 79F / 255F, 84F / 255F, 1F); } }
            /// <summary>
            /// Solid Momoshiocha (百入茶). RGBA is (31, 49, 52, 255).
            /// </summary>
            public static Color Momoshiocha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(31F / 255F, 49F / 255F, 52F / 255F, 1F); } }
            /// <summary>
            /// Solid Sabinezu (錆鼠). RGBA is (71, 88, 92, 255).
            /// </summary>
            public static Color Sabinezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(71F / 255F, 88F / 255F, 92F / 255F, 1F); } }
            /// <summary>
            /// Solid Sabitetsuonando (錆鉄御納戸). RGBA is (72, 88, 89, 255).
            /// </summary>
            public static Color Sabitetsuonando { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(72F / 255F, 88F / 255F, 89F / 255F, 1F); } }
            /// <summary>
            /// Solid Haikimidori (灰黄緑). RGBA is (230, 234, 227, 255).
            /// </summary>
            public static Color Haikimidori { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(230F / 255F, 234F / 255F, 227F / 255F, 1F); } }
            /// <summary>
            /// Solid Sobakiriiro (蕎麦切色). RGBA is (212, 220, 214, 255).
            /// </summary>
            public static Color Sobakiriiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(212F / 255F, 220F / 255F, 214F / 255F, 1F); } }
            /// <summary>
            /// Solid Usukumonezu (薄雲鼠). RGBA is (212, 220, 218, 255).
            /// </summary>
            public static Color Usukumonezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(212F / 255F, 220F / 255F, 218F / 255F, 1F); } }
        }

        /// <summary>
        /// Shades of blue.
        /// </summary>
        public static class BlueFamily
        {
            /// <summary>
            /// Solid Ainezu (藍鼠). RGBA is (108, 132, 141, 255).
            /// </summary>
            public static Color Ainezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(108F / 255F, 132F / 255F, 141F / 255F, 1F); } }
            /// <summary>
            /// Solid Sabionando (錆御納戸). RGBA is (83, 114, 125, 255).
            /// </summary>
            public static Color Sabionando { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(83F / 255F, 114F / 255F, 125F / 255F, 1F); } }
            /// <summary>
            /// Solid Masuhanairo (舛花色). RGBA is (91, 126, 145, 255).
            /// </summary>
            public static Color Masuhanairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(91F / 255F, 126F / 255F, 145F / 255F, 1F); } }
            /// <summary>
            /// Solid Noshimehanairo (熨斗目花色). RGBA is (66, 101, 121, 255).
            /// </summary>
            public static Color Noshimehanairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(66F / 255F, 101F / 255F, 121F / 255F, 1F); } }
            /// <summary>
            /// Solid Omeshionando (御召御納戸). RGBA is (76, 100, 115, 255).
            /// </summary>
            public static Color Omeshionando { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(76F / 255F, 100F / 255F, 115F / 255F, 1F); } }
            /// <summary>
            /// Solid Tetsuonando (鉄御納戸). RGBA is (69, 87, 101, 255).
            /// </summary>
            public static Color Tetsuonando { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(69F / 255F, 87F / 255F, 101F / 255F, 1F); } }
            /// <summary>
            /// Solid Konnezu (紺鼠). RGBA is (68, 97, 123, 255).
            /// </summary>
            public static Color Konnezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(68F / 255F, 97F / 255F, 123F / 255F, 1F); } }
            /// <summary>
            /// Solid Aitetsu (藍鉄). RGBA is (57, 63, 76, 255).
            /// </summary>
            public static Color Aitetsu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(57F / 255F, 63F / 255F, 76F / 255F, 1F); } }
            /// <summary>
            /// Solid Aokachi (青褐). RGBA is (57, 62, 79, 255).
            /// </summary>
            public static Color Aokachi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(57F / 255F, 62F / 255F, 79F / 255F, 1F); } }
            /// <summary>
            /// Solid Kachikaeshi (褐返). RGBA is (32, 55, 68, 255).
            /// </summary>
            public static Color Kachikaeshi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(32F / 255F, 55F / 255F, 68F / 255F, 1F); } }
            /// <summary>
            /// Solid Shiraai (白藍). RGBA is (193, 228, 233, 255).
            /// </summary>
            public static Color Shiraai { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(193F / 255F, 228F / 255F, 233F / 255F, 1F); } }
            /// <summary>
            /// Solid Mizuiro (水色). RGBA is (188, 226, 232, 255).
            /// </summary>
            public static Color Mizuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(188F / 255F, 226F / 255F, 232F / 255F, 1F); } }
            /// <summary>
            /// Solid Kamenozoki (瓶覗). RGBA is (162, 215, 221, 255).
            /// </summary>
            public static Color Kamenozoki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(162F / 255F, 215F / 255F, 221F / 255F, 1F); } }
            /// <summary>
            /// Solid Hisokuiro (秘色色). RGBA is (171, 206, 216, 255).
            /// </summary>
            public static Color Hisokuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(171F / 255F, 206F / 255F, 216F / 255F, 1F); } }
            /// <summary>
            /// Solid Sorairo (空色). RGBA is (160, 216, 239, 255).
            /// </summary>
            public static Color Sorairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(160F / 255F, 216F / 255F, 239F / 255F, 1F); } }
            /// <summary>
            /// Solid Wasurenagusairo (勿忘草色). RGBA is (137, 195, 235, 255).
            /// </summary>
            public static Color Wasurenagusairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(137F / 255F, 195F / 255F, 235F / 255F, 1F); } }
            /// <summary>
            /// Solid Aofujiiro (青藤色). RGBA is (132, 162, 212, 255).
            /// </summary>
            public static Color Aofujiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(132F / 255F, 162F / 255F, 212F / 255F, 1F); } }
            /// <summary>
            /// Solid Byakugun (白群). RGBA is (131, 204, 210, 255).
            /// </summary>
            public static Color Byakugun { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(131F / 255F, 204F / 255F, 210F / 255F, 1F); } }
            /// <summary>
            /// Solid Asahanada (浅縹). RGBA is (132, 185, 203, 255).
            /// </summary>
            public static Color Asahanada { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(132F / 255F, 185F / 255F, 203F / 255F, 1F); } }
            /// <summary>
            /// Solid Usuhanairo (薄花色). RGBA is (105, 138, 171, 255).
            /// </summary>
            public static Color Usuhanairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(105F / 255F, 138F / 255F, 171F / 255F, 1F); } }
            /// <summary>
            /// Solid Nandoiro (納戸色). RGBA is (0, 136, 153, 255).
            /// </summary>
            public static Color Nandoiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(0F / 255F, 136F / 255F, 153F / 255F, 1F); } }
            /// <summary>
            /// Solid Asagiiro (浅葱色). RGBA is (0, 163, 175, 255).
            /// </summary>
            public static Color Asagiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(0F / 255F, 163F / 255F, 175F / 255F, 1F); } }
            /// <summary>
            /// Solid Hanaasagi (花浅葱). RGBA is (42, 131, 162, 255).
            /// </summary>
            public static Color Hanaasagi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(42F / 255F, 131F / 255F, 162F / 255F, 1F); } }
            /// <summary>
            /// Solid Shinbashiiro (新橋色). RGBA is (89, 185, 198, 255).
            /// </summary>
            public static Color Shinbashiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(89F / 255F, 185F / 255F, 198F / 255F, 1F); } }
            /// <summary>
            /// Solid Amairo (天色). RGBA is (44, 169, 225, 255).
            /// </summary>
            public static Color Amairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(44F / 255F, 169F / 255F, 225F / 255F, 1F); } }
            /// <summary>
            /// Solid Tsuyukusairo (露草色). RGBA is (56, 161, 219, 255).
            /// </summary>
            public static Color Tsuyukusairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(56F / 255F, 161F / 255F, 219F / 255F, 1F); } }
            /// <summary>
            /// Solid Ao (青). RGBA is (0, 149, 217, 255).
            /// </summary>
            public static Color Ao { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(0F / 255F, 149F / 255F, 217F / 255F, 1F); } }
            /// <summary>
            /// Solid Usuai (薄藍). RGBA is (0, 148, 200, 255).
            /// </summary>
            public static Color Usuai { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(0F / 255F, 148F / 255F, 200F / 255F, 1F); } }
            /// <summary>
            /// Solid Hanadairo (縹色). RGBA is (39, 146, 195, 255).
            /// </summary>
            public static Color Hanadairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(39F / 255F, 146F / 255F, 195F / 255F, 1F); } }
            /// <summary>
            /// Solid Konpeki (紺碧). RGBA is (0, 123, 187, 255).
            /// </summary>
            public static Color Konpeki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(0F / 255F, 123F / 255F, 187F / 255F, 1F); } }
            /// <summary>
            /// Solid Usugunjou (薄群青). RGBA is (83, 131, 195, 255).
            /// </summary>
            public static Color Usugunjou { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(83F / 255F, 131F / 255F, 195F / 255F, 1F); } }
            /// <summary>
            /// Solid Usuhanazakura (薄花桜). RGBA is (90, 121, 186, 255).
            /// </summary>
            public static Color Usuhanazakura { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(90F / 255F, 121F / 255F, 186F / 255F, 1F); } }
            /// <summary>
            /// Solid Gunjouiro (群青色). RGBA is (76, 108, 179, 255).
            /// </summary>
            public static Color Gunjouiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(76F / 255F, 108F / 255F, 179F / 255F, 1F); } }
            /// <summary>
            /// Solid Kakitsubatairo (杜若色). RGBA is (62, 98, 173, 255).
            /// </summary>
            public static Color Kakitsubatairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(62F / 255F, 98F / 255F, 173F / 255F, 1F); } }
            /// <summary>
            /// Solid Ruriiro (瑠璃色). RGBA is (30, 80, 162, 255).
            /// </summary>
            public static Color Ruriiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(30F / 255F, 80F / 255F, 162F / 255F, 1F); } }
            /// <summary>
            /// Solid Usuhanada (薄縹). RGBA is (80, 126, 164, 255).
            /// </summary>
            public static Color Usuhanada { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(80F / 255F, 126F / 255F, 164F / 255F, 1F); } }
            /// <summary>
            /// Solid Rurikon (瑠璃紺). RGBA is (25, 68, 142, 255).
            /// </summary>
            public static Color Rurikon { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(25F / 255F, 68F / 255F, 142F / 255F, 1F); } }
            /// <summary>
            /// Solid Konruri (紺瑠璃). RGBA is (22, 74, 132, 255).
            /// </summary>
            public static Color Konruri { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(22F / 255F, 74F / 255F, 132F / 255F, 1F); } }
            /// <summary>
            /// Solid Aiiro (藍色). RGBA is (22, 94, 131, 255).
            /// </summary>
            public static Color Aiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(22F / 255F, 94F / 255F, 131F / 255F, 1F); } }
            /// <summary>
            /// Solid Seiran (青藍). RGBA is (39, 74, 120, 255).
            /// </summary>
            public static Color Seiran { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(39F / 255F, 74F / 255F, 120F / 255F, 1F); } }
            /// <summary>
            /// Solid Kokihanada (深縹). RGBA is (42, 64, 115, 255).
            /// </summary>
            public static Color Kokihanada { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(42F / 255F, 64F / 255F, 115F / 255F, 1F); } }
            /// <summary>
            /// Solid Koniro (紺色). RGBA is (34, 58, 112, 255).
            /// </summary>
            public static Color Koniro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(34F / 255F, 58F / 255F, 112F / 255F, 1F); } }
            /// <summary>
            /// Solid Konjou (紺青). RGBA is (25, 47, 96, 255).
            /// </summary>
            public static Color Konjou { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(25F / 255F, 47F / 255F, 96F / 255F, 1F); } }
            /// <summary>
            /// Solid Tomekon (留紺). RGBA is (28, 48, 92, 255).
            /// </summary>
            public static Color Tomekon { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(28F / 255F, 48F / 255F, 92F / 255F, 1F); } }
            /// <summary>
            /// Solid Koiai (濃藍). RGBA is (15, 35, 80, 255).
            /// </summary>
            public static Color Koiai { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(15F / 255F, 35F / 255F, 80F / 255F, 1F); } }
            /// <summary>
            /// Solid Konai (紺藍). RGBA is (74, 72, 142, 255).
            /// </summary>
            public static Color Konai { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(74F / 255F, 72F / 255F, 142F / 255F, 1F); } }
            /// <summary>
            /// Solid Tetsukon (鉄紺). RGBA is (23, 24, 75, 255).
            /// </summary>
            public static Color Tetsukon { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(23F / 255F, 24F / 255F, 75F / 255F, 1F); } }
            /// <summary>
            /// Solid Awafujiiro (淡藤色). RGBA is (187, 200, 230, 255).
            /// </summary>
            public static Color Awafujiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(187F / 255F, 200F / 255F, 230F / 255F, 1F); } }
            /// <summary>
            /// Solid Benikakesorairo (紅掛空色). RGBA is (132, 145, 195, 255).
            /// </summary>
            public static Color Benikakesorairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(132F / 255F, 145F / 255F, 195F / 255F, 1F); } }
            /// <summary>
            /// Solid Benimidori (紅碧). RGBA is (132, 145, 195, 255).
            /// </summary>
            public static Color Benimidori { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(132F / 255F, 145F / 255F, 195F / 255F, 1F); } }
        }

        /// <summary>
        /// Shades of purple.
        /// </summary>
        public static class PurpleFamily
        {
            /// <summary>
            /// Solid Kachiiro (褐色). RGBA is (77, 76, 97, 255).
            /// </summary>
            public static Color Kachiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(77F / 255F, 76F / 255F, 97F / 255F, 1F); } }
            /// <summary>
            /// Solid Fujiiro (藤色). RGBA is (187, 188, 222, 255).
            /// </summary>
            public static Color Fujiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(187F / 255F, 188F / 255F, 222F / 255F, 1F); } }
            /// <summary>
            /// Solid Konkikyou (紺桔梗). RGBA is (77, 90, 175, 255).
            /// </summary>
            public static Color Konkikyou { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(77F / 255F, 90F / 255F, 175F / 255F, 1F); } }
            /// <summary>
            /// Solid Hanairo (花色). RGBA is (77, 90, 175, 255).
            /// </summary>
            public static Color Hanairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(77F / 255F, 90F / 255F, 175F / 255F, 1F); } }
            /// <summary>
            /// Solid Benikikyou (紅桔梗). RGBA is (77, 67, 152, 255).
            /// </summary>
            public static Color Benikikyou { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(77F / 255F, 67F / 255F, 152F / 255F, 1F); } }
            /// <summary>
            /// Solid Kikyouiro (桔梗色). RGBA is (86, 84, 162, 255).
            /// </summary>
            public static Color Kikyouiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(86F / 255F, 84F / 255F, 162F / 255F, 1F); } }
            /// <summary>
            /// Solid Fujinando (藤納戸). RGBA is (112, 108, 170, 255).
            /// </summary>
            public static Color Fujinando { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(112F / 255F, 108F / 255F, 170F / 255F, 1F); } }
            /// <summary>
            /// Solid Benikakehanairo (紅掛花色). RGBA is (104, 105, 155, 255).
            /// </summary>
            public static Color Benikakehanairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(104F / 255F, 105F / 255F, 155F / 255F, 1F); } }
            /// <summary>
            /// Solid Shioniro (紫苑色). RGBA is (134, 123, 169, 255).
            /// </summary>
            public static Color Shioniro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(134F / 255F, 123F / 255F, 169F / 255F, 1F); } }
            /// <summary>
            /// Solid Shirafujiiro (白藤色). RGBA is (219, 208, 230, 255).
            /// </summary>
            public static Color Shirafujiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(219F / 255F, 208F / 255F, 230F / 255F, 1F); } }
            /// <summary>
            /// Solid Fujimurasaki (藤紫). RGBA is (165, 154, 202, 255).
            /// </summary>
            public static Color Fujimurasaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(165F / 255F, 154F / 255F, 202F / 255F, 1F); } }
            /// <summary>
            /// Solid Sumireiro (菫色). RGBA is (112, 88, 163, 255).
            /// </summary>
            public static Color Sumireiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(112F / 255F, 88F / 255F, 163F / 255F, 1F); } }
            /// <summary>
            /// Solid Aomurasaki (青紫). RGBA is (103, 69, 152, 255).
            /// </summary>
            public static Color Aomurasaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(103F / 255F, 69F / 255F, 152F / 255F, 1F); } }
            /// <summary>
            /// Solid Shoubuiro (菖蒲色). RGBA is (103, 65, 150, 255).
            /// </summary>
            public static Color Shoubuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(103F / 255F, 65F / 255F, 150F / 255F, 1F); } }
            /// <summary>
            /// Solid Rindouiro (竜胆色). RGBA is (144, 121, 173, 255).
            /// </summary>
            public static Color Rindouiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(144F / 255F, 121F / 255F, 173F / 255F, 1F); } }
            /// <summary>
            /// Solid Edomurasaki (江戸紫). RGBA is (116, 83, 153, 255).
            /// </summary>
            public static Color Edomurasaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(116F / 255F, 83F / 255F, 153F / 255F, 1F); } }
            /// <summary>
            /// Solid Honmurasaki (本紫). RGBA is (101, 49, 142, 255).
            /// </summary>
            public static Color Honmurasaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(101F / 255F, 49F / 255F, 142F / 255F, 1F); } }
            /// <summary>
            /// Solid Budouiro (葡萄色). RGBA is (82, 47, 96, 255).
            /// </summary>
            public static Color Budouiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(82F / 255F, 47F / 255F, 96F / 255F, 1F); } }
            /// <summary>
            /// Solid Fukamurasaki (深紫). RGBA is (73, 55, 89, 255).
            /// </summary>
            public static Color Fukamurasaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(73F / 255F, 55F / 255F, 89F / 255F, 1F); } }
            /// <summary>
            /// Solid Murasaki (紫). RGBA is (136, 72, 152, 255).
            /// </summary>
            public static Color Murasaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(136F / 255F, 72F / 255F, 152F / 255F, 1F); } }
            /// <summary>
            /// Solid Usubudou (薄葡萄). RGBA is (192, 162, 199, 255).
            /// </summary>
            public static Color Usubudou { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(192F / 255F, 162F / 255F, 199F / 255F, 1F); } }
            /// <summary>
            /// Solid Shikon (紫紺). RGBA is (70, 14, 68, 255).
            /// </summary>
            public static Color Shikon { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(70F / 255F, 14F / 255F, 68F / 255F, 1F); } }
            /// <summary>
            /// Solid Ankoushoku (暗紅色). RGBA is (116, 50, 92, 255).
            /// </summary>
            public static Color Ankoushoku { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(116F / 255F, 50F / 255F, 92F / 255F, 1F); } }
            /// <summary>
            /// Solid Kuwanomiiro (桑の実色). RGBA is (85, 41, 91, 255).
            /// </summary>
            public static Color Kuwanomiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(85F / 255F, 41F / 255F, 91F / 255F, 1F); } }
            /// <summary>
            /// Solid Kodaimurasaki (古代紫). RGBA is (137, 91, 138, 255).
            /// </summary>
            public static Color Kodaimurasaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(137F / 255F, 91F / 255F, 138F / 255F, 1F); } }
            /// <summary>
            /// Solid Nasukon (茄子紺). RGBA is (130, 72, 128, 255).
            /// </summary>
            public static Color Nasukon { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(130F / 255F, 72F / 255F, 128F / 255F, 1F); } }
            /// <summary>
            /// Solid Futaai (二藍). RGBA is (145, 92, 139, 255).
            /// </summary>
            public static Color Futaai { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(145F / 255F, 92F / 255F, 139F / 255F, 1F); } }
            /// <summary>
            /// Solid Kyoumurasaki (京紫). RGBA is (157, 91, 139, 255).
            /// </summary>
            public static Color Kyoumurasaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(157F / 255F, 91F / 255F, 139F / 255F, 1F); } }
            /// <summary>
            /// Solid Ebizome (蒲葡). RGBA is (122, 65, 113, 255).
            /// </summary>
            public static Color Ebizome { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(122F / 255F, 65F / 255F, 113F / 255F, 1F); } }
            /// <summary>
            /// Solid Wakamurasaki (若紫). RGBA is (188, 100, 164, 255).
            /// </summary>
            public static Color Wakamurasaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(188F / 255F, 100F / 255F, 164F / 255F, 1F); } }
            /// <summary>
            /// Solid Benimurasaki (紅紫). RGBA is (180, 76, 151, 255).
            /// </summary>
            public static Color Benimurasaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(180F / 255F, 76F / 255F, 151F / 255F, 1F); } }
            /// <summary>
            /// Solid Umemurasaki (梅紫). RGBA is (170, 76, 143, 255).
            /// </summary>
            public static Color Umemurasaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(170F / 255F, 76F / 255F, 143F / 255F, 1F); } }
            /// <summary>
            /// Solid Ayameiro (菖蒲色). RGBA is (204, 126, 177, 255).
            /// </summary>
            public static Color Ayameiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(204F / 255F, 126F / 255F, 177F / 255F, 1F); } }
            /// <summary>
            /// Solid Benifujiiro (紅藤色). RGBA is (204, 166, 191, 255).
            /// </summary>
            public static Color Benifujiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(204F / 255F, 166F / 255F, 191F / 255F, 1F); } }
            /// <summary>
            /// Solid Asamurasaki (浅紫). RGBA is (196, 163, 191, 255).
            /// </summary>
            public static Color Asamurasaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(196F / 255F, 163F / 255F, 191F / 255F, 1F); } }
            /// <summary>
            /// Solid Murasakisuishou (紫水晶). RGBA is (231, 231, 235, 255).
            /// </summary>
            public static Color Murasakisuishou { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(231F / 255F, 231F / 255F, 235F / 255F, 1F); } }
            /// <summary>
            /// Solid Usuumenezu (薄梅鼠). RGBA is (220, 214, 217, 255).
            /// </summary>
            public static Color Usuumenezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(220F / 255F, 214F / 255F, 217F / 255F, 1F); } }
            /// <summary>
            /// Solid Akatsukinezu (暁鼠). RGBA is (211, 207, 217, 255).
            /// </summary>
            public static Color Akatsukinezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(211F / 255F, 207F / 255F, 217F / 255F, 1F); } }
            /// <summary>
            /// Solid Botannezu (牡丹鼠). RGBA is (211, 204, 214, 255).
            /// </summary>
            public static Color Botannezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(211F / 255F, 204F / 255F, 214F / 255F, 1F); } }
            /// <summary>
            /// Solid Kasumiiro (霞色). RGBA is (200, 194, 198, 255).
            /// </summary>
            public static Color Kasumiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(200F / 255F, 194F / 255F, 198F / 255F, 1F); } }
            /// <summary>
            /// Solid Fujinezu (藤鼠). RGBA is (166, 165, 196, 255).
            /// </summary>
            public static Color Fujinezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(166F / 255F, 165F / 255F, 196F / 255F, 1F); } }
            /// <summary>
            /// Solid Hashitairo (半色). RGBA is (166, 154, 189, 255).
            /// </summary>
            public static Color Hashitairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(166F / 255F, 154F / 255F, 189F / 255F, 1F); } }
            /// <summary>
            /// Solid Usuiro (薄色). RGBA is (168, 157, 172, 255).
            /// </summary>
            public static Color Usuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(168F / 255F, 157F / 255F, 172F / 255F, 1F); } }
            /// <summary>
            /// Solid Usunezu (薄鼠). RGBA is (151, 144, 164, 255).
            /// </summary>
            public static Color Usunezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(151F / 255F, 144F / 255F, 164F / 255F, 1F); } }
            /// <summary>
            /// Solid Hatobanezumi (鳩羽鼠). RGBA is (158, 139, 142, 255).
            /// </summary>
            public static Color Hatobanezumi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(158F / 255F, 139F / 255F, 142F / 255F, 1F); } }
            /// <summary>
            /// Solid Hatobairo (鳩羽色). RGBA is (149, 133, 156, 255).
            /// </summary>
            public static Color Hatobairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(149F / 255F, 133F / 255F, 156F / 255F, 1F); } }
            /// <summary>
            /// Solid Kikyounezu (桔梗鼠). RGBA is (149, 148, 154, 255).
            /// </summary>
            public static Color Kikyounezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(149F / 255F, 148F / 255F, 154F / 255F, 1F); } }
            /// <summary>
            /// Solid Murasakinezu (紫鼠). RGBA is (113, 104, 108, 255).
            /// </summary>
            public static Color Murasakinezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(113F / 255F, 104F / 255F, 108F / 255F, 1F); } }
            /// <summary>
            /// Solid Budounezumi (葡萄鼠). RGBA is (112, 91, 103, 255).
            /// </summary>
            public static Color Budounezumi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(112F / 255F, 91F / 255F, 103F / 255F, 1F); } }
            /// <summary>
            /// Solid Kokiiro (濃色). RGBA is (99, 73, 80, 255).
            /// </summary>
            public static Color Kokiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(99F / 255F, 73F / 255F, 80F / 255F, 1F); } }
            /// <summary>
            /// Solid Murasakitobi (紫鳶). RGBA is (95, 65, 75, 255).
            /// </summary>
            public static Color Murasakitobi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(95F / 255F, 65F / 255F, 75F / 255F, 1F); } }
            /// <summary>
            /// Solid Koinezu (濃鼠). RGBA is (79, 69, 92, 255).
            /// </summary>
            public static Color Koinezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(79F / 255F, 69F / 255F, 92F / 255F, 1F); } }
            /// <summary>
            /// Solid Fujisusutake (藤煤竹). RGBA is (90, 83, 89, 255).
            /// </summary>
            public static Color Fujisusutake { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(90F / 255F, 83F / 255F, 89F / 255F, 1F); } }
            /// <summary>
            /// Solid Keshimurasaki (滅紫). RGBA is (89, 66, 85, 255).
            /// </summary>
            public static Color Keshimurasaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(89F / 255F, 66F / 255F, 85F / 255F, 1F); } }
            /// <summary>
            /// Solid Benikeshinezumi (紅消鼠). RGBA is (82, 71, 72, 255).
            /// </summary>
            public static Color Benikeshinezumi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(82F / 255F, 71F / 255F, 72F / 255F, 1F); } }
            /// <summary>
            /// Solid Nisemurasaki (似せ紫). RGBA is (81, 55, 67, 255).
            /// </summary>
            public static Color Nisemurasaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(81F / 255F, 55F / 255F, 67F / 255F, 1F); } }
        }

        /// <summary>
        /// Shades of brown.
        /// </summary>
        public static class BrownFamily
        {
            /// <summary>
            /// Solid Shiracha (白茶). RGBA is (221, 187, 153, 255).
            /// </summary>
            public static Color Shiracha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(221F / 255F, 187F / 255F, 153F / 255F, 1F); } }
            /// <summary>
            /// Solid Akashirotsurubami (赤白橡). RGBA is (215, 169, 140, 255).
            /// </summary>
            public static Color Akashirotsurubami { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(215F / 255F, 169F / 255F, 140F / 255F, 1F); } }
            /// <summary>
            /// Solid Araigaki (洗柿). RGBA is (242, 201, 172, 255).
            /// </summary>
            public static Color Araigaki { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(242F / 255F, 201F / 255F, 172F / 255F, 1F); } }
            /// <summary>
            /// Solid Enshuucha (遠州茶). RGBA is (202, 130, 105, 255).
            /// </summary>
            public static Color Enshuucha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(202F / 255F, 130F / 255F, 105F / 255F, 1F); } }
            /// <summary>
            /// Solid Soho (赭). RGBA is (171, 105, 83, 255).
            /// </summary>
            public static Color Soho { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(171F / 255F, 105F / 255F, 83F / 255F, 1F); } }
            /// <summary>
            /// Solid Azukiiro (小豆色). RGBA is (152, 81, 75, 255).
            /// </summary>
            public static Color Azukiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(152F / 255F, 81F / 255F, 75F / 255F, 1F); } }
            /// <summary>
            /// Solid Karacha (枯茶). RGBA is (141, 100, 73, 255).
            /// </summary>
            public static Color Karacha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(141F / 255F, 100F / 255F, 73F / 255F, 1F); } }
            /// <summary>
            /// Solid Ameiro (飴色). RGBA is (222, 176, 104, 255).
            /// </summary>
            public static Color Ameiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(222F / 255F, 176F / 255F, 104F / 255F, 1F); } }
            /// <summary>
            /// Solid Rakudairo (駱駝色). RGBA is (191, 121, 78, 255).
            /// </summary>
            public static Color Rakudairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(191F / 255F, 121F / 255F, 78F / 255F, 1F); } }
            /// <summary>
            /// Solid Tsuchiiro (土色). RGBA is (188, 118, 60, 255).
            /// </summary>
            public static Color Tsuchiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(188F / 255F, 118F / 255F, 60F / 255F, 1F); } }
            /// <summary>
            /// Solid Kigaracha (黄唐茶). RGBA is (185, 140, 70, 255).
            /// </summary>
            public static Color Kigaracha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(185F / 255F, 140F / 255F, 70F / 255F, 1F); } }
            /// <summary>
            /// Solid Kuwazome (桑染). RGBA is (183, 155, 91, 255).
            /// </summary>
            public static Color Kuwazome { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(183F / 255F, 155F / 255F, 91F / 255F, 1F); } }
            /// <summary>
            /// Solid Hajiiro (櫨色). RGBA is (183, 123, 87, 255).
            /// </summary>
            public static Color Hajiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(183F / 255F, 123F / 255F, 87F / 255F, 1F); } }
            /// <summary>
            /// Solid Kitsurubami (黄橡). RGBA is (182, 141, 76, 255).
            /// </summary>
            public static Color Kitsurubami { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(182F / 255F, 141F / 255F, 76F / 255F, 1F); } }
            /// <summary>
            /// Solid Choujizome (丁字染). RGBA is (173, 125, 76, 255).
            /// </summary>
            public static Color Choujizome { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(173F / 255F, 125F / 255F, 76F / 255F, 1F); } }
            /// <summary>
            /// Solid Kouzome (香染). RGBA is (173, 125, 76, 255).
            /// </summary>
            public static Color Kouzome { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(173F / 255F, 125F / 255F, 76F / 255F, 1F); } }
            /// <summary>
            /// Solid Biwacha (枇杷茶). RGBA is (174, 124, 79, 255).
            /// </summary>
            public static Color Biwacha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(174F / 255F, 124F / 255F, 79F / 255F, 1F); } }
            /// <summary>
            /// Solid Shikancha (芝翫茶). RGBA is (173, 126, 78, 255).
            /// </summary>
            public static Color Shikancha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(173F / 255F, 126F / 255F, 78F / 255F, 1F); } }
            /// <summary>
            /// Solid Kogarekou (焦香). RGBA is (174, 124, 88, 255).
            /// </summary>
            public static Color Kogarekou { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(174F / 255F, 124F / 255F, 88F / 255F, 1F); } }
            /// <summary>
            /// Solid Kurumiiro (胡桃色). RGBA is (168, 111, 76, 255).
            /// </summary>
            public static Color Kurumiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(168F / 255F, 111F / 255F, 76F / 255F, 1F); } }
            /// <summary>
            /// Solid Shibukamiiro (渋紙色). RGBA is (148, 98, 67, 255).
            /// </summary>
            public static Color Shibukamiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(148F / 255F, 98F / 255F, 67F / 255F, 1F); } }
            /// <summary>
            /// Solid Kuchibairo (朽葉色). RGBA is (145, 115, 71, 255).
            /// </summary>
            public static Color Kuchibairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(145F / 255F, 115F / 255F, 71F / 255F, 1F); } }
            /// <summary>
            /// Solid Kuwacha (桑茶). RGBA is (149, 111, 41, 255).
            /// </summary>
            public static Color Kuwacha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(149F / 255F, 111F / 255F, 41F / 255F, 1F); } }
            /// <summary>
            /// Solid Rokoucha (路考茶). RGBA is (140, 112, 66, 255).
            /// </summary>
            public static Color Rokoucha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(140F / 255F, 112F / 255F, 66F / 255F, 1F); } }
            /// <summary>
            /// Solid Kokuboushoku (国防色). RGBA is (123, 108, 62, 255).
            /// </summary>
            public static Color Kokuboushoku { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(123F / 255F, 108F / 255F, 62F / 255F, 1F); } }
            /// <summary>
            /// Solid Kyarairo (伽羅色). RGBA is (216, 163, 115, 255).
            /// </summary>
            public static Color Kyarairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(216F / 255F, 163F / 255F, 115F / 255F, 1F); } }
            /// <summary>
            /// Solid Edocha (江戸茶). RGBA is (205, 140, 92, 255).
            /// </summary>
            public static Color Edocha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(205F / 255F, 140F / 255F, 92F / 255F, 1F); } }
            /// <summary>
            /// Solid Kabairo (樺色). RGBA is (205, 94, 60, 255).
            /// </summary>
            public static Color Kabairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(205F / 255F, 94F / 255F, 60F / 255F, 1F); } }
            /// <summary>
            /// Solid Beniukon (紅鬱金). RGBA is (203, 131, 71, 255).
            /// </summary>
            public static Color Beniukon { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(203F / 255F, 131F / 255F, 71F / 255F, 1F); } }
            /// <summary>
            /// Solid Kawarakeiro (土器色). RGBA is (195, 120, 84, 255).
            /// </summary>
            public static Color Kawarakeiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(195F / 255F, 120F / 255F, 84F / 255F, 1F); } }
            /// <summary>
            /// Solid Kitsuneiro (狐色). RGBA is (195, 135, 67, 255).
            /// </summary>
            public static Color Kitsuneiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(195F / 255F, 135F / 255F, 67F / 255F, 1F); } }
            /// <summary>
            /// Solid Oudoiro (黄土色). RGBA is (195, 145, 67, 255).
            /// </summary>
            public static Color Oudoiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(195F / 255F, 145F / 255F, 67F / 255F, 1F); } }
            /// <summary>
            /// Solid Kohakuiro (琥珀色). RGBA is (191, 120, 58, 255).
            /// </summary>
            public static Color Kohakuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(191F / 255F, 120F / 255F, 58F / 255F, 1F); } }
            /// <summary>
            /// Solid Akacha (赤茶). RGBA is (187, 85, 53, 255).
            /// </summary>
            public static Color Akacha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(187F / 255F, 85F / 255F, 53F / 255F, 1F); } }
            /// <summary>
            /// Solid Taisha (代赭). RGBA is (187, 85, 32, 255).
            /// </summary>
            public static Color Taisha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(187F / 255F, 85F / 255F, 32F / 255F, 1F); } }
            /// <summary>
            /// Solid Rengairo (煉瓦色). RGBA is (181, 82, 51, 255).
            /// </summary>
            public static Color Rengairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(181F / 255F, 82F / 255F, 51F / 255F, 1F); } }
            /// <summary>
            /// Solid Suzumecha (雀茶). RGBA is (170, 79, 55, 255).
            /// </summary>
            public static Color Suzumecha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(170F / 255F, 79F / 255F, 55F / 255F, 1F); } }
            /// <summary>
            /// Solid Danjuuroucha (団十郎茶). RGBA is (159, 86, 58, 255).
            /// </summary>
            public static Color Danjuuroucha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(159F / 255F, 86F / 255F, 58F / 255F, 1F); } }
            /// <summary>
            /// Solid Kakishibuiro (柿渋色). RGBA is (159, 86, 58, 255).
            /// </summary>
            public static Color Kakishibuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(159F / 255F, 86F / 255F, 58F / 255F, 1F); } }
            /// <summary>
            /// Solid Benitobi (紅鳶). RGBA is (154, 73, 63, 255).
            /// </summary>
            public static Color Benitobi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(154F / 255F, 73F / 255F, 63F / 255F, 1F); } }
            /// <summary>
            /// Solid Haicha (灰茶). RGBA is (152, 98, 60, 255).
            /// </summary>
            public static Color Haicha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(152F / 255F, 98F / 255F, 60F / 255F, 1F); } }
            /// <summary>
            /// Solid Chairo (茶色). RGBA is (150, 80, 66, 255).
            /// </summary>
            public static Color Chairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(150F / 255F, 80F / 255F, 66F / 255F, 1F); } }
            /// <summary>
            /// Solid Hiwadairo (檜皮色). RGBA is (150, 80, 54, 255).
            /// </summary>
            public static Color Hiwadairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(150F / 255F, 80F / 255F, 54F / 255F, 1F); } }
            /// <summary>
            /// Solid Tobiiro (鳶色). RGBA is (149, 72, 63, 255).
            /// </summary>
            public static Color Tobiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(149F / 255F, 72F / 255F, 63F / 255F, 1F); } }
            /// <summary>
            /// Solid Kakicha (柿茶). RGBA is (149, 78, 42, 255).
            /// </summary>
            public static Color Kakicha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(149F / 255F, 78F / 255F, 42F / 255F, 1F); } }
            /// <summary>
            /// Solid Bengarairo (弁柄色). RGBA is (143, 46, 20, 255).
            /// </summary>
            public static Color Bengarairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(143F / 255F, 46F / 255F, 20F / 255F, 1F); } }
            /// <summary>
            /// Solid Akasabiiro (赤錆色). RGBA is (138, 51, 25, 255).
            /// </summary>
            public static Color Akasabiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(138F / 255F, 51F / 255F, 25F / 255F, 1F); } }
            /// <summary>
            /// Solid Kasshoku (褐色). RGBA is (138, 59, 0, 255).
            /// </summary>
            public static Color Kasshoku { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(138F / 255F, 59F / 255F, 0F / 255F, 1F); } }
            /// <summary>
            /// Solid Kuriume (栗梅). RGBA is (133, 46, 25, 255).
            /// </summary>
            public static Color Kuriume { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(133F / 255F, 46F / 255F, 25F / 255F, 1F); } }
            /// <summary>
            /// Solid Benihihada (紅檜皮). RGBA is (123, 71, 65, 255).
            /// </summary>
            public static Color Benihihada { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(123F / 255F, 71F / 255F, 65F / 255F, 1F); } }
            /// <summary>
            /// Solid Ebicha (海老茶). RGBA is (119, 60, 48, 255).
            /// </summary>
            public static Color Ebicha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(119F / 255F, 60F / 255F, 48F / 255F, 1F); } }
            /// <summary>
            /// Solid Karacha (唐茶). RGBA is (120, 60, 29, 255).
            /// </summary>
            public static Color KarachaDeeoBrown { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(120F / 255F, 60F / 255F, 29F / 255F, 1F); } }
            /// <summary>
            /// Solid Kuriiro (栗色). RGBA is (118, 47, 7, 255).
            /// </summary>
            public static Color Kuriiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(118F / 255F, 47F / 255F, 7F / 255F, 1F); } }
            /// <summary>
            /// Solid Shakudouiro (赤銅色). RGBA is (117, 33, 0, 255).
            /// </summary>
            public static Color Shakudouiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(117F / 255F, 33F / 255F, 0F / 255F, 1F); } }
            /// <summary>
            /// Solid Sabiiro (錆色). RGBA is (108, 53, 36, 255).
            /// </summary>
            public static Color Sabiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(108F / 255F, 53F / 255F, 36F / 255F, 1F); } }
            /// <summary>
            /// Solid Sekkasshoku (赤褐色). RGBA is (104, 63, 54, 255).
            /// </summary>
            public static Color Sekkasshoku { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(104F / 255F, 63F / 255F, 54F / 255F, 1F); } }
            /// <summary>
            /// Solid Chakasshoku (茶褐色). RGBA is (102, 64, 50, 255).
            /// </summary>
            public static Color Chakasshoku { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(102F / 255F, 64F / 255F, 50F / 255F, 1F); } }
            /// <summary>
            /// Solid Kurikawacha (栗皮茶). RGBA is (109, 60, 50, 255).
            /// </summary>
            public static Color Kurikawacha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(109F / 255F, 60F / 255F, 50F / 255F, 1F); } }
            /// <summary>
            /// Solid Kurocha (黒茶). RGBA is (88, 56, 34, 255).
            /// </summary>
            public static Color Kurocha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(88F / 255F, 56F / 255F, 34F / 255F, 1F); } }
            /// <summary>
            /// Solid Ebicha (葡萄茶). RGBA is (108, 44, 47, 255).
            /// </summary>
            public static Color EbichaDeepBrown { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(108F / 255F, 44F / 255F, 47F / 255F, 1F); } }
            /// <summary>
            /// Solid Ebiiro (葡萄色). RGBA is (100, 1, 37, 255).
            /// </summary>
            public static Color Ebiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(100F / 255F, 1F / 255F, 37F / 255F, 1F); } }
            /// <summary>
            /// Solid Kabachairo (樺茶色). RGBA is (114, 98, 80, 255).
            /// </summary>
            public static Color Kabachairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(114F / 255F, 98F / 255F, 80F / 255F, 1F); } }
            /// <summary>
            /// Solid Utsubushiiro (空五倍子色). RGBA is (157, 137, 108, 255).
            /// </summary>
            public static Color Utsubushiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(157F / 255F, 137F / 255F, 108F / 255F, 1F); } }
            /// <summary>
            /// Solid Namakabeiro (生壁色). RGBA is (148, 132, 106, 255).
            /// </summary>
            public static Color Namakabeiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(148F / 255F, 132F / 255F, 106F / 255F, 1F); } }
            /// <summary>
            /// Solid Higosusutake (肥後煤竹). RGBA is (137, 120, 88, 255).
            /// </summary>
            public static Color Higosusutake { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(137F / 255F, 120F / 255F, 88F / 255F, 1F); } }
            /// <summary>
            /// Solid Kobicha (媚茶). RGBA is (113, 98, 70, 255).
            /// </summary>
            public static Color Kobicha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(113F / 255F, 98F / 255F, 70F / 255F, 1F); } }
            /// <summary>
            /// Solid Shirotsurubami (白橡). RGBA is (203, 185, 148, 255).
            /// </summary>
            public static Color Shirotsurubami { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(203F / 255F, 185F / 255F, 148F / 255F, 1F); } }
            /// <summary>
            /// Solid Amairo (亜麻色). RGBA is (214, 198, 175, 255).
            /// </summary>
            public static Color Amairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(214F / 255F, 198F / 255F, 175F / 255F, 1F); } }
            /// <summary>
            /// Solid Hashibamiiro (榛色). RGBA is (191, 164, 111, 255).
            /// </summary>
            public static Color Hashibamiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(191F / 255F, 164F / 255F, 111F / 255F, 1F); } }
            /// <summary>
            /// Solid Karenoiro (枯野色). RGBA is (211, 203, 198, 255).
            /// </summary>
            public static Color Karenoiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(211F / 255F, 203F / 255F, 198F / 255F, 1F); } }
            /// <summary>
            /// Solid Urumiiro (潤色). RGBA is (200, 194, 190, 255).
            /// </summary>
            public static Color Urumiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(200F / 255F, 194F / 255F, 190F / 255F, 1F); } }
            /// <summary>
            /// Solid Rikyuushirocha (利休白茶). RGBA is (179, 173, 160, 255).
            /// </summary>
            public static Color Rikyuushirocha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(179F / 255F, 173F / 255F, 160F / 255F, 1F); } }
            /// <summary>
            /// Solid Chanezumi (茶鼠). RGBA is (169, 158, 147, 255).
            /// </summary>
            public static Color Chanezumi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(169F / 255F, 158F / 255F, 147F / 255F, 1F); } }
            /// <summary>
            /// Solid Kurumizome (胡桃染). RGBA is (165, 143, 134, 255).
            /// </summary>
            public static Color Kurumizome { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(165F / 255F, 143F / 255F, 134F / 255F, 1F); } }
            /// <summary>
            /// Solid Edonezu (江戸鼠). RGBA is (146, 129, 120, 255).
            /// </summary>
            public static Color Edonezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(146F / 255F, 129F / 255F, 120F / 255F, 1F); } }
            /// <summary>
            /// Solid Choujicha (丁子茶). RGBA is (180, 134, 107, 255).
            /// </summary>
            public static Color Choujicha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(180F / 255F, 134F / 255F, 107F / 255F, 1F); } }
            /// <summary>
            /// Solid Fushizome (柴染). RGBA is (178, 140, 110, 255).
            /// </summary>
            public static Color Fushizome { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(178F / 255F, 140F / 255F, 110F / 255F, 1F); } }
            /// <summary>
            /// Solid Soudenkaracha (宗伝唐茶). RGBA is (161, 109, 93, 255).
            /// </summary>
            public static Color Soudenkaracha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(161F / 255F, 109F / 255F, 93F / 255F, 1F); } }
            /// <summary>
            /// Solid Tonocha (砺茶). RGBA is (159, 111, 85, 255).
            /// </summary>
            public static Color Tonocha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(159F / 255F, 111F / 255F, 85F / 255F, 1F); } }
            /// <summary>
            /// Solid Senchairo (煎茶色). RGBA is (140, 100, 80, 255).
            /// </summary>
            public static Color Senchairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(140F / 255F, 100F / 255F, 80F / 255F, 1F); } }
            /// <summary>
            /// Solid Ginsusudake (銀煤竹). RGBA is (133, 104, 89, 255).
            /// </summary>
            public static Color Ginsusudake { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(133F / 255F, 104F / 255F, 89F / 255F, 1F); } }
            /// <summary>
            /// Solid Kigaracha (黄枯茶). RGBA is (118, 92, 71, 255).
            /// </summary>
            public static Color KigarachaDeepBrown { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(118F / 255F, 92F / 255F, 71F / 255F, 1F); } }
            /// <summary>
            /// Solid Susutakeiro (煤竹色). RGBA is (111, 81, 76, 255).
            /// </summary>
            public static Color Susutakeiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(111F / 255F, 81F / 255F, 76F / 255F, 1F); } }
            /// <summary>
            /// Solid Kogecha (焦茶). RGBA is (111, 75, 62, 255).
            /// </summary>
            public static Color Kogecha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(111F / 255F, 75F / 255F, 62F / 255F, 1F); } }
            /// <summary>
            /// Solid Kenpouiro (憲法色). RGBA is (84, 63, 50, 255).
            /// </summary>
            public static Color Kenpouiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(84F / 255F, 63F / 255F, 50F / 255F, 1F); } }
            /// <summary>
            /// Solid Kuriiro (涅色). RGBA is (85, 71, 56, 255).
            /// </summary>
            public static Color KuriiroDeepBrown { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(85F / 255F, 71F / 255F, 56F / 255F, 1F); } }
            /// <summary>
            /// Solid Kurotobi (黒鳶). RGBA is (67, 47, 47, 255).
            /// </summary>
            public static Color Kurotobi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(67F / 255F, 47F / 255F, 47F / 255F, 1F); } }
            /// <summary>
            /// Solid Akasumi (赤墨). RGBA is (63, 49, 43, 255).
            /// </summary>
            public static Color Akasumi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(63F / 255F, 49F / 255F, 43F / 255F, 1F); } }
        }

        /// <summary>
        /// Shades of white. Includes some gray.
        /// </summary>
        public static class WhiteFamily
        {
            /// <summary>
            /// Solid Sunairo (砂色). RGBA is (220, 211, 178, 255).
            /// </summary>
            public static Color Sunairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(220F / 255F, 211F / 255F, 178F / 255F, 1F); } }
            /// <summary>
            /// Solid Geppaku (月白). RGBA is (234, 244, 252, 255).
            /// </summary>
            public static Color Geppaku { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(234F / 255F, 244F / 255F, 252F / 255F, 1F); } }
            /// <summary>
            /// Solid Shirosumireiro (白菫色). RGBA is (234, 237, 247, 255).
            /// </summary>
            public static Color Shirosumireiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(234F / 255F, 237F / 255F, 247F / 255F, 1F); } }
            /// <summary>
            /// Solid Shirahanairo (白花色). RGBA is (232, 236, 239, 255).
            /// </summary>
            public static Color Shirahanairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(232F / 255F, 236F / 255F, 239F / 255F, 1F); } }
            /// <summary>
            /// Solid Aijiro (藍白). RGBA is (235, 246, 247, 255).
            /// </summary>
            public static Color Aijiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(235F / 255F, 246F / 255F, 247F / 255F, 1F); } }
            /// <summary>
            /// Solid Shiro (白). RGBA is (255, 255, 255, 255).
            /// </summary>
            public static Color Shiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(255F / 255F, 255F / 255F, 255F / 255F, 1F); } }
            /// <summary>
            /// Solid Gofuniro (胡粉色). RGBA is (255, 255, 252, 255).
            /// </summary>
            public static Color Gofuniro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(255F / 255F, 255F / 255F, 252F / 255F, 1F); } }
            /// <summary>
            /// Solid Unohanairo (卯の花色). RGBA is (247, 252, 254, 255).
            /// </summary>
            public static Color Unohanairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(247F / 255F, 252F / 255F, 254F / 255F, 1F); } }
            /// <summary>
            /// Solid Hakuji (白磁). RGBA is (248, 251, 248, 255).
            /// </summary>
            public static Color Hakuji { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(248F / 255F, 251F / 255F, 248F / 255F, 1F); } }
            /// <summary>
            /// Solid Kinariiro (生成り色). RGBA is (251, 250, 245, 255).
            /// </summary>
            public static Color Kinariiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(251F / 255F, 250F / 255F, 245F / 255F, 1F); } }
            /// <summary>
            /// Solid Nyuuhakushoku (乳白色). RGBA is (243, 243, 243, 255).
            /// </summary>
            public static Color Nyuuhakushoku { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(243F / 255F, 243F / 255F, 243F / 255F, 1F); } }
            /// <summary>
            /// Solid Shironeri (白練). RGBA is (243, 243, 242, 255).
            /// </summary>
            public static Color Shironeri { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(243F / 255F, 243F / 255F, 242F / 255F, 1F); } }
            /// <summary>
            /// Solid Soshoku (素色). RGBA is (234, 229, 227, 255).
            /// </summary>
            public static Color Soshoku { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(234F / 255F, 229F / 255F, 227F / 255F, 1F); } }
            /// <summary>
            /// Solid Shiraumenezu (白梅鼠). RGBA is (229, 228, 230, 255).
            /// </summary>
            public static Color Shiraumenezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(229F / 255F, 228F / 255F, 230F / 255F, 1F); } }
            /// <summary>
            /// Solid Shironezu (白鼠). RGBA is (220, 221, 221, 255).
            /// </summary>
            public static Color Shironezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(220F / 255F, 221F / 255F, 221F / 255F, 1F); } }
            /// <summary>
            /// Solid Kinunezu (絹鼠). RGBA is (221, 220, 214, 255).
            /// </summary>
            public static Color Kinunezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(221F / 255F, 220F / 255F, 214F / 255F, 1F); } }
            /// <summary>
            /// Solid Haiao (灰青). RGBA is (192, 198, 201, 255).
            /// </summary>
            public static Color Haiao { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(192F / 255F, 198F / 255F, 201F / 255F, 1F); } }
            /// <summary>
            /// Solid Ginnezu (銀鼠). RGBA is (175, 175, 176, 255).
            /// </summary>
            public static Color Ginnezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(175F / 255F, 175F / 255F, 176F / 255F, 1F); } }
            /// <summary>
            /// Solid Usunibi (薄鈍). RGBA is (173, 173, 173, 255).
            /// </summary>
            public static Color Usunibi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(173F / 255F, 173F / 255F, 173F / 255F, 1F); } }
        }

        /// <summary>
        /// Shades of black. Includes some gray.
        /// </summary>
        public static class BlackFamily
        {
            /// <summary>
            /// Solid Akuiro (灰汁色). RGBA is (158, 148, 120, 255).
            /// </summary>
            public static Color Akuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(158F / 255F, 148F / 255F, 120F / 255F, 1F); } }
            /// <summary>
            /// Solid Shikkoku (漆黒). RGBA is (13, 0, 21, 255).
            /// </summary>
            public static Color Shikkoku { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(13F / 255F, 0F / 255F, 21F / 255F, 1F); } }
            /// <summary>
            /// Solid Shikoku (紫黒). RGBA is (46, 41, 48, 255).
            /// </summary>
            public static Color Shikoku { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(46F / 255F, 41F / 255F, 48F / 255F, 1F); } }
            /// <summary>
            /// Solid Susuiro (煤色). RGBA is (136, 127, 122, 255).
            /// </summary>
            public static Color Susuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(136F / 255F, 127F / 255F, 122F / 255F, 1F); } }
            /// <summary>
            /// Solid Kurotsurubami (黒橡). RGBA is (84, 74, 71, 255).
            /// </summary>
            public static Color Kurotsurubami { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(84F / 255F, 74F / 255F, 71F / 255F, 1F); } }
            /// <summary>
            /// Solid Binroujizome (檳榔子染). RGBA is (67, 61, 60, 255).
            /// </summary>
            public static Color Binroujizome { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(67F / 255F, 61F / 255F, 60F / 255F, 1F); } }
            /// <summary>
            /// Solid Kurobeni (黒紅). RGBA is (48, 40, 51, 255).
            /// </summary>
            public static Color Kurobeni { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(48F / 255F, 40F / 255F, 51F / 255F, 1F); } }
            /// <summary>
            /// Solid Usuzumiiro (薄墨色). RGBA is (163, 163, 162, 255).
            /// </summary>
            public static Color Usuzumiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(163F / 255F, 163F / 255F, 162F / 255F, 1F); } }
            /// <summary>
            /// Solid Suzuiro (錫色). RGBA is (158, 161, 163, 255).
            /// </summary>
            public static Color Suzuiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(158F / 255F, 161F / 255F, 163F / 255F, 1F); } }
            /// <summary>
            /// Solid Sunezumi (素鼠). RGBA is (159, 160, 160, 255).
            /// </summary>
            public static Color Sunezumi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(159F / 255F, 160F / 255F, 160F / 255F, 1F); } }
            /// <summary>
            /// Solid Nezumiiro (鼠色). RGBA is (148, 148, 149, 255).
            /// </summary>
            public static Color Nezumiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(148F / 255F, 148F / 255F, 149F / 255F, 1F); } }
            /// <summary>
            /// Solid Genjinezu (源氏鼠). RGBA is (136, 128, 132, 255).
            /// </summary>
            public static Color Genjinezu { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(136F / 255F, 128F / 255F, 132F / 255F, 1F); } }
            /// <summary>
            /// Solid Haiiro (灰色). RGBA is (125, 125, 125, 255).
            /// </summary>
            public static Color Haiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(125F / 255F, 125F / 255F, 125F / 255F, 1F); } }
            /// <summary>
            /// Solid Namariiro (鉛色). RGBA is (123, 124, 125, 255).
            /// </summary>
            public static Color Namariiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(123F / 255F, 124F / 255F, 125F / 255F, 1F); } }
            /// <summary>
            /// Solid Nibiiro (鈍色). RGBA is (114, 113, 113, 255).
            /// </summary>
            public static Color Nibiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(114F / 255F, 113F / 255F, 113F / 255F, 1F); } }
            /// <summary>
            /// Solid Sumi (墨). RGBA is (89, 88, 87, 255).
            /// </summary>
            public static Color Sumi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(89F / 255F, 88F / 255F, 87F / 255F, 1F); } }
            /// <summary>
            /// Solid Dobunezumi (丼鼠). RGBA is (89, 84, 85, 255).
            /// </summary>
            public static Color Dobunezumi { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(89F / 255F, 84F / 255F, 85F / 255F, 1F); } }
            /// <summary>
            /// Solid Keshizumiiro (消炭色). RGBA is (82, 78, 77, 255).
            /// </summary>
            public static Color Keshizumiiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(82F / 255F, 78F / 255F, 77F / 255F, 1F); } }
            /// <summary>
            /// Solid Aisumicha (藍墨茶). RGBA is (71, 74, 77, 255).
            /// </summary>
            public static Color Aisumicha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(71F / 255F, 74F / 255F, 77F / 255F, 1F); } }
            /// <summary>
            /// Solid Youkaniro (羊羹色). RGBA is (56, 60, 60, 255).
            /// </summary>
            public static Color Youkaniro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(56F / 255F, 60F / 255F, 60F / 255F, 1F); } }
            /// <summary>
            /// Solid Rouiro (蝋色). RGBA is (43, 43, 43, 255).
            /// </summary>
            public static Color Rouiro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(43F / 255F, 43F / 255F, 43F / 255F, 1F); } }
            /// <summary>
            /// Solid Kuro (黒). RGBA is (43, 43, 43, 255).
            /// </summary>
            public static Color Kuro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(43F / 255F, 43F / 255F, 43F / 255F, 1F); } }
            /// <summary>
            /// Solid Karasubairo (烏羽色). RGBA is (24, 6, 20, 255).
            /// </summary>
            public static Color Karasubairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(24F / 255F, 6F / 255F, 20F / 255F, 1F); } }
            /// <summary>
            /// Solid Tetsuguro (鉄黒). RGBA is (40, 26, 20, 255).
            /// </summary>
            public static Color Tetsuguro { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(40F / 255F, 26F / 255F, 20F / 255F, 1F); } }
            /// <summary>
            /// Solid Nurebairo (濡羽色). RGBA is (0, 11, 0, 255).
            /// </summary>
            public static Color Nurebairo { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(0F / 255F, 11F / 255F, 0F / 255F, 1F); } }
            /// <summary>
            /// Solid Kokutan (黒檀). RGBA is (37, 13, 0, 255).
            /// </summary>
            public static Color Kokutan { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(37F / 255F, 13F / 255F, 0F / 255F, 1F); } }
            /// <summary>
            /// Solid Kenpoukurocha (憲法黒茶). RGBA is (36, 26, 8, 255).
            /// </summary>
            public static Color Kenpoukurocha { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(36F / 255F, 26F / 255F, 8F / 255F, 1F); } }
            /// <summary>
            /// Solid Ankokushoku (暗黒色). RGBA is (22, 22, 14, 255).
            /// </summary>
            public static Color Ankokushoku { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return new Color(22F / 255F, 22F / 255F, 14F / 255F, 1F); } }
        }
    }
}