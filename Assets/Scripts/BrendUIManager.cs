using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlendTest
{
    public class BrendUIManager : MonoBehaviour
    {
        [SerializeField]
        GraphManager _graphManager;
        [SerializeField]
        UIEquation _uIEquation;

        Colors _currentColors;

        private void Awake()
        {
            _currentColors = new Colors(OnChangeValue);
            _graphManager.Initialize(OnBasicColorChanged, OnBrendColorChanged);
        }

        public void OnBasicColorChanged(float color)
        {
            _currentColors.SetBasic(color);

        }
        public void OnBrendColorChanged(float color)
        {
            _currentColors.SetBlend(color);
        }

        private void OnChangeValue()
        {
            _graphManager.UpdateColors(_currentColors);
            _uIEquation.UpdateEquation(_currentColors);
        }
    }
}
