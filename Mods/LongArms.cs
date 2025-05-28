using System;
using System.Collections.Generic;
using System.Text;

namespace PlanciTemplate.Mods
{
    internal class LongArms
    {
        public static void LongArmsMod()
        {
            GorillaLocomotion.GTPlayer.Instance.transform.localScale = new UnityEngine.Vector3(1.3f, 1.3f, 1.3f);
        }
    }
}
//turn off long arms is only when u make a long arms Mod
