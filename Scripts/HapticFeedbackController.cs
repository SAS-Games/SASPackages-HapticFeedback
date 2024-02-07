using UnityEngine;

namespace SAS.HapticFeedback
{
    public class HapticFeedbackController : MonoBehaviour
    {

        public void LightFeedback()
        {
            HapticFeedback.LightFeedback();
        }

        public void MediumFeedback()
        {
            HapticFeedback.MediumFeedback();
        }

        public void HeavyFeedback()
        {
            HapticFeedback.HeavyFeedback();
        }

    }

}
