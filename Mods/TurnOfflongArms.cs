using System;
using System.Collections.Generic;
using System.Text;

namespace PlanciTemplate.Mods
{
    internal class TurnOfflongArms
    {
        public static void TurnOffLongArmsMod()
        {
            GorillaLocomotion.GTPlayer.Instance.transform.localScale = new UnityEngine.Vector3(1.0f, 1.0f, 1.0f);
        }
    }
}
//turn off long arms is only when u make a long arms Mod
