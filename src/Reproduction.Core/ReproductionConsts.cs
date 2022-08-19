using Reproduction.Debugging;

namespace Reproduction
{
    public class ReproductionConsts
    {
        public const string LocalizationSourceName = "Reproduction";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "8ac9a8a534ba4517953d4a8bbbe3757f";
    }
}
