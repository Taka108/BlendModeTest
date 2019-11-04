using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlendTest
{
    [RequireComponent(typeof(Slider))]
    public class ColorSlider : MonoBehaviour
    {
        private Slider _slider;
        [SerializeField]
        ColorBall _colorBall;

        public System.Action<float> OnValueChangedCallback { get; set; }

        private void Awake()
        {
            _slider = GetComponent<Slider>();
            _slider.onValueChanged.AddListener(OnValueChanged);
        }


        public void OnValueChanged(float value)
        {
            _colorBall.SetColor(value);
            OnValueChangedCallback?.Invoke(value);
        }
    }
}
