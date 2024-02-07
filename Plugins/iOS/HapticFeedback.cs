using System.Runtime.InteropServices;

namespace SAS.HapticFeedback.iOS
{

    public static class HapticFeedback
    {

        [DllImport("__Internal")]
        public static extern void PerformHapticFeedback(string style = "medium");

    }

}
