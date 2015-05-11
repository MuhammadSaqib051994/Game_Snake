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
           private static Hashtable keytable = new Hashtable();
           public static bool keyPressed(Keys key)
           
            {
               if(keytable[key]==null)
            
                  {
                        return false; 
                  }   
            } 
    }
}