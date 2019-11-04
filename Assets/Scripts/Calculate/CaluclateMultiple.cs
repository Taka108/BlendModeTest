using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlendTest
{
    public class CaluclateMultiple : ICalculate
    {
        public float Calculate(BasicAndBlend basicAndBlend)
        {
            return basicAndBlend.basic * basicAndBlend.blend;
        }
    }
}