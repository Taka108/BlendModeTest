using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlendTest
{
    [RequireComponent(typeof(Image))]
    public class ColorBall : MonoBehaviour
    {
        private float _currentColor;
        private Image _targetImage;

        protected virtual void Awake()
        {
            _targetImage = GetComponent<Image>();
        }

        public void SetColor(float color)
        {
            _currentColor = color;
            UpdateColor();
        }
        private void UpdateColor()
        {
            _targetImage.color = new Color(_currentColor, _currentColor, _currentColor);
        }
    }
}
