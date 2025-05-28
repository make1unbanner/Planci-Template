using PlanciTemplate.Mods;
using StupidTemplate.Classes;
using StupidTemplate.Mods;
using System;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Projectile", method =() => Catogorys.ProjectileSettings(), isTogglable = false, toolTip = ""},
                new ButtonInfo { buttonText = "Main Settings", method =() => Catogorys.MenuSettings(), isTogglable = false, toolTip = ""},
                new ButtonInfo { buttonText = "Movement", method =() => Catogorys.Movement(), isTogglable = false, toolTip = ""},
                new ButtonInfo { buttonText = "Safety", method =() => Catogorys.Safety(), isTogglable = false, toolTip = ""},
                new ButtonInfo { buttonText = "Network", method =() => Catogorys.Network(), isTogglable = false, toolTip = ""},
                new ButtonInfo { buttonText = "Rig", method =() => Catogorys.Rig(), isTogglable = false, toolTip = ""},
                new ButtonInfo { buttonText = "Visual", method =() => Catogorys.Visual(), toolTip = "", isTogglable = false},
                new ButtonInfo { buttonText = "Owerpowerd", method =() => Catogorys.Owerpowerd(), toolTip = "", isTogglable = false},
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Projectile", method =() => Catogorys.ProjectileSettings(), isTogglable = false, toolTip = ""},
                new ButtonInfo { buttonText = "Main Settings", method =() => Catogorys.MenuSettings(), isTogglable = false, toolTip = ""},
                new ButtonInfo { buttonText = "Movement", method =() => Catogorys.Movement(), isTogglable = false, toolTip = ""},
                new ButtonInfo { buttonText = "Safety", method =() => Catogorys.Safety(), isTogglable = false, toolTip = ""},
                new ButtonInfo { buttonText = "Network", method =() => Catogorys.Network(), isTogglable = false, toolTip = ""},
                new ButtonInfo { buttonText = "Rig", method =() => Catogorys.Rig(), isTogglable = false, toolTip = ""},
                new ButtonInfo { buttonText = "Visual", method =() => Catogorys.Visual(), toolTip = "", isTogglable = false},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },

            new ButtonInfo[] { // Safety
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = ""},
            },

            new ButtonInfo[] { // Movement
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = ""},
                new ButtonInfo { buttonText = "SpeedBoost", method =() => SpeedBoost.SpeedBoostMod(), toolTip = "what your mod do", isTogglable = true},
                new ButtonInfo { buttonText = "SteamLongArms", method =() => LongArms.LongArmsMod(), toolTip = "what your mod do", isTogglable = true},
                new ButtonInfo { buttonText = "TurnOffLongArms", method =() => TurnOfflongArms.TurnOffLongArmsMod(), toolTip = "what your mod do", isTogglable = true},
            },

            new ButtonInfo[] { // Rig
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = ""},
            },

            new ButtonInfo[] { // Main Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = ""},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => Catogorys.RightHand(), disableMethod =() => Catogorys.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => Catogorys.EnableNotifications(), disableMethod =() => Catogorys.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => Catogorys.EnableFPSCounter(), disableMethod =() => Catogorys.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => Catogorys.EnableDisconnectButton(), disableMethod =() => Catogorys.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Visual
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = ""},
            },

             new ButtonInfo[] { // Owerpowerd
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = ""},
            },

            new ButtonInfo[] { // NetWork
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = ""},
            },

        };
    }
}
