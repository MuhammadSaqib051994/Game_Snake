using System;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace snake_Game
{
    class Inputs
    {
        // This Line of Code Loads The Available Buttons On our Keyboard
        private static Hashtable keytable = new Hashtable();
        
        //This code Checks Which Button of our Keyboard is pressed 
        public static bool KeyPressed(Keys key)
        {
            if(keytable[key]==null)
            {
                return false; 
            }   
            else   
            return(bool) keytable[key];
        }
         
        //It Detects if a Button is Pressed
        public static void ChangeState(Keys key, bool state)
        {
               keytable[key]=state; 
        }
    }
}