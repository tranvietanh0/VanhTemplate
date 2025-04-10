using UnityEngine.UIElements;

namespace UnityEditor.AddressableAssets.BuildReportVisualizer
{
    /// <summary>
    /// UI tool to toggle expansion in the Build Layout Report
    /// </summary>
    public class ToggleTextExpansionButton
    {
        internal Button ToggleButton { get; set; }

        internal ToggleTextExpansionButton(VisualElement container, Length collapsedHeight)
        {
            ToggleButton = new Button();
            ToggleButton.userData = false;
            ToggleButton.text = "EYE";

            ToggleButton.clicked += () =>
            {
                if((bool)ToggleButton.userData)
                    container.style.maxHeight = new Length(100f, LengthUnit.Percent);
                else
                    container.style.maxHeight = collapsedHeight;

                ToggleButton.userData = !((bool)ToggleButton.userData);
            };
        }
    }
}
