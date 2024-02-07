namespace SAS.HapticFeedback
{
    public static class HapticFeedback
    {
        public static bool IsHapticFeedbackEnabled { get; set; } = true;
        public static void LightFeedback()
        {
            if (!IsHapticFeedbackEnabled) return;
#if UNITY_IOS && !UNITY_EDITOR
            iOS.HapticFeedback.PerformHapticFeedback("light");
#elif UNITY_ANDROID && !UNITY_EDITOR
            Android.HapticFeedback.PerformHapticFeedback(Android.HapticFeedbackConstants.CONTEXT_CLICK);
#endif

        }

        public static void MediumFeedback()
        {
            if (!IsHapticFeedbackEnabled) return;
#if UNITY_IOS && !UNITY_EDITOR
            iOS.HapticFeedback.PerformHapticFeedback("medium");
#elif UNITY_ANDROID && !UNITY_EDITOR
            Android.HapticFeedback.PerformHapticFeedback(Android.HapticFeedbackConstants.VIRTUAL_KEY);
#endif

        }

        public static void HeavyFeedback()
        {
            if (!IsHapticFeedbackEnabled) return;
#if UNITY_IOS && !UNITY_EDITOR
            iOS.HapticFeedback.PerformHapticFeedback("heavy");
#elif UNITY_ANDROID && !UNITY_EDITOR
            Android.HapticFeedback.PerformHapticFeedback(Android.HapticFeedbackConstants.LONG_PRESS);
#endif

        }

    }

}
