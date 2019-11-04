using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlendTest
{
    [RequireComponent(typeof(RectTransform))]
    public class ResultColor : MonoBehaviour
    {
        [SerializeField]
        ResultColorBall _resultColorBall;

        private RectTransform _rectTransform;
        private Vector2 _posRange;


        // Start is called before the first frame update
        void Awake()
        {
            _rectTransform = GetComponent<RectTransform>();
            _posRange = _rectTransform.sizeDelta;
            _resultColorBall.Setup(_posRange);
        }

        public void UpdateColors(Colors colors)
        {
            _resultColorBall.UpdateColor(colors);
        }
    }
}