﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PlanciTemplate.Mods
{
    internal class SpeedBoost
    {
        public static void SpeedBoostMod()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 9f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 9f;
        }
    }
}
