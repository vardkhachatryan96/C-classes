using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndStructs.Classes.Abstraction
{
    /// <summary>
    /// Mobile phone model Nokia2700
    /// </summary>
    public class Nokia2700 : MobilePhone
    {
        /// <summary>
        /// FMRadio feature
        /// </summary>
        public void FMRadio() 
        {
            Console.WriteLine("Nokia2700: I have FM Radio");
        }

        /// <summary>
        /// MP3 feature
        /// </summary>
        public void MP3()
        { 
            Console.WriteLine("Nokia2700: I have Mp3");
        }

        /// <summary>
        /// Camera feature
        /// </summary>
        public void Camera()
        { 
            Console.WriteLine("Nokia2700: I have Camera");
        }
    }
}
