namespace ClassesAndStructs.Classes.Abstraction
{
    /// <summary>
    /// Abstract class for Mobile Phones
    /// </summary>
    public abstract class MobilePhone
    {
        /// <summary>
        /// Call to given person
        /// </summary>
        /// <param name="name">The person name</param>
        public void Calling(string name)
        {
            System.Console.WriteLine($"Hi {name}");
        }

        /// <summary>
        /// Send sms to given person
        /// </summary>
        /// <param name="name">The person name</param>
        /// <param name="sms">The sms to send</param>
        public void SendSMS(string name, string sms)
        {
            System.Console.WriteLine($"Hi {name}: {sms}");
        }
    }
}
