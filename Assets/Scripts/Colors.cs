using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BlendTest
{
    public class Colors
    {
        public float Result { get; set; }
        public float Basic { get { return basicAndBlend.basic; } }
        public float Blend { get { return basicAndBlend.blend; } }
        public BasicAndBlend basicAndBlend { get; set; }
        private ICalculate _calculate;
        private System.Action _onChange;
        public Colors(System.Action onChange)
        {
            basicAndBlend = new BasicAndBlend();
            // 他のブレンドモードが出てきたらここを変える
            _calculate = new CaluclateMultiple();
            _onChange = onChange;
        }
        public void SetBasic(float color)
        {
            basicAndBlend.basic = color;
            OnChange();
        }
        public void SetBlend(float color)
        {
            basicAndBlend.blend = color;
            OnChange();
        }
        private void OnChange()
        {
            Result = _calculate.Calculate(basicAndBlend);
            _onChange?.Invoke();
        }
    }

    public class BasicAndBlend
    {
        public float basic;
        public float blend;
    }
}
