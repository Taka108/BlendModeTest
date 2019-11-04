using UnityEngine;
using UnityEngine.UI;

namespace BlendTest
{
    public class UIEquation : MonoBehaviour
    {
        [SerializeField]
        private Text _result;
        [SerializeField]
        private Text _basic;
        [SerializeField]
        private Text _blend;

        private const string valueFormat = "F2";

        public void UpdateEquation(BlendTest.Colors colors)
        {
            _result.text = colors.Result.ToString(valueFormat);
            _basic.text = colors.Basic.ToString(valueFormat);
            _blend.text = colors.Blend.ToString(valueFormat);
        }
    }
}
