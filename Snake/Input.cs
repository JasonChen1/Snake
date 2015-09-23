using System.Collections;
using System.Windows.Forms;

namespace Snake
{
    internal class Input
    {
        //loading list of keyboard buttons
        private static Hashtable keyTable = new Hashtable();

        //check to see if any button are pressed
        public static bool KeyPressed(Keys key)
        {
            if(keyTable[key]==null)
            {
                return false;
            }

            return (bool)keyTable[key];
        }

        //check if keyboard button are pressed
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }


    }
}
