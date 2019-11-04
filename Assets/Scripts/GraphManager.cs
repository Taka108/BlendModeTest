using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlendTest
{
    public class GraphManager : MonoBehaviour
    {
        [SerializeField]
        private ColorSlider _basicColorSlider;
        [SerializeField]
        private ColorSlider _brendColorSlider;
        [SerializeField]
        private ResultColor _resultColor;

        public void Initialize(System.Action<float> onBasicColorChanged, System.Action<float> onBlendColorChanged)
        {
            _basicColorSlider.OnValueChangedCallback += onBasicColorChanged;
            _brendColorSlider.OnValueChangedCallback += onBlendColorChanged;
        }

        public void UpdateColors(Colors colors)
        {
            _resultColor.UpdateColors(colors);
        }
    }
}
