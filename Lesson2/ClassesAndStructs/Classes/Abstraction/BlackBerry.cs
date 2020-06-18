using System;

namespace ClassesAndStructs.Classes.Abstraction
{
    /// <summary>
    /// Mobile phone model BlackBerry
    /// </summary>
    public class BlackBerry : MobilePhone
    {
        /// <summary>
        /// FMRadio feature
        /// </summary>
        public void FMRadio()
        {
            Console.WriteLine("BlackBerry: I have FM Radio");
        }

        /// <summary>
        /// MP3 feature
        /// </summary>
        public void MP3()
        {
            Console.WriteLine("BlackBerry: I have Mp3");
        }

        /// <summary>
        /// Camera feature
        /// </summary>
        public void Camera()
        {
            Console.WriteLine("BlackBerry: I have Camera");
        }
        /// <summary>
        /// Recording feature
        /// </summary>
        public void Recording()
        {
            Console.WriteLine("BlackBerry: I have Recording");
        }

        /// <summary>
        /// Read and send email feature
        /// </summary>
        public void ReadAndSendEmails()
        {
            Console.WriteLine("BlackBerry: Read and send email feature");
        }
    }
}
