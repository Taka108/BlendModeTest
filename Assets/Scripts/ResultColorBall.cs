using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace BlendTest
{
    public class ResultColorBall : ColorBall
    {
        private Vector2 _posRange;
        private BasicAndBlend _basicAndBlend;
        RectTransform _rectTransform;

        protected override void Awake()
        {
            base.Awake();
            _rectTransform = GetComponent<RectTransform>();
        }

        public void Setup(Vector2 posRange)
        {
            _posRange = posRange;
        }

        public void UpdateColor(Colors colors)
        {
            UpdateColors(colors.basicAndBlend);
            SetColor(colors.Result);
            UpdatePosition();
        }

        private void UpdateColors(BasicAndBlend basicAndBlend)
        {
            _basicAndBlend = basicAndBlend;
        }

        private void UpdatePosition()
        {
            float x = _posRange.x * _basicAndBlend.blend;
            float colorY = _basicAndBlend.blend * _basicAndBlend.basic;
            float y = _posRange.y * colorY;

            _rectTransform.anchoredPosition = new Vector2(x, y);
        }

        private void SetResultColor()
        {
            float result = _basicAndBlend.blend * _basicAndBlend.blend;
            SetColor(result);
        }
    }
}