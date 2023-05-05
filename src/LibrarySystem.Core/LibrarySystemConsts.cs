using LibrarySystem.Debugging;

namespace LibrarySystem
{
    public class LibrarySystemConsts
    {
        public const string LocalizationSourceName = "LibrarySystem";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "dae5b45311d844c29d83bcb5e55a82f3";
    }
}
