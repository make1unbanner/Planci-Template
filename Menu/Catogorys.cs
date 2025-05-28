using static StupidTemplate.Menu.Main;
using static StupidTemplate.Settings;

namespace StupidTemplate.Mods
{
    internal class Catogorys
    {
        public static void EnterSettings()
        {
            buttonsType = 4;
        }

        public static void Settings()
        {
            buttonsType = 1;
        }

        public static void ProjectileSettings()
        {
            buttonsType = 2;
        }

        public static void Safety()
        {
            buttonsType = 3;
        }

        public static void Movement()
        {
            buttonsType = 4;
        }

        public static void Rig()
        {
            buttonsType = 5;
        }

        public static void Network()
        {
            buttonsType = 9;
        }

        public static void MenuSettings()
        {
            buttonsType = 6;
        }

        public static void Visual()
        {
            buttonsType = 7;
        }

        public static void Owerpowerd()
        {
            buttonsType = 8;
            pageNumber = 0;
        }


        public static void RightHand()
        {
            rightHanded = true;
        }

        public static void LeftHand()
        {
            rightHanded = false;
        }

        public static void EnableFPSCounter()
        {
            fpsCounter = true;
        }

        public static void DisableFPSCounter()
        {
            fpsCounter = false;
        }

        public static void EnableNotifications()
        {
            disableNotifications = false;
        }

        public static void DisableNotifications()
        {
            disableNotifications = true;
        }

        public static void EnableDisconnectButton()
        {
            disconnectButton = true;
        }

        public static void DisableDisconnectButton()
        {
            disconnectButton = false;
        }
    }
}
