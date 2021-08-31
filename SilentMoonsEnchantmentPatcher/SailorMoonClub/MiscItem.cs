// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class SailorMoonClub
    {
        public static class MiscItem
        {
            private static FormLink<IMiscItemGetter> Construct(uint id) => new FormLink<IMiscItemGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMiscItemGetter> SMC_UnlitTorch => Construct(0x36f26);
            public static FormLink<IMiscItemGetter> SMC_MoonPearlMisc => Construct(0xd62);
        }
    }
}
