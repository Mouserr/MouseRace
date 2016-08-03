using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class SpeedBar : MonoBehaviour
    {
        [SerializeField] private AbstractTracker tracker;
        [SerializeField] private Scrollbar bar;
        [SerializeField] private float maximum;

        private void Update()
        {
            bar.size = (tracker.CurrentValue / Screen.width);
        }

    }
}