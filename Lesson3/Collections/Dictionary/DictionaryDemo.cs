namespace Collections.Dictionary
{
    /// <summary>
    /// Dictionary Demo model
    /// </summary>
    public class DictionaryDemo
    {
        /// <summary>
        /// Run Dictionary Collection demo
        /// </summary>
        public static void Run()
        {
            var students = new StudentCatalog();

            var anna = new Student(12, "Anna");
            var betty = new Student(338, "Betty");
            var carl = new Student(92, "Carl");

            anna.AddTestResult("English", 85);
            anna.AddTestResult("Math", 70);
            anna.AddTestResult("Biology", 90);
            anna.AddTestResult("French", 52);

            betty.AddTestResult("English", 77);
            betty.AddTestResult("Math", 82);
            betty.AddTestResult("Chemistry", 65);
            betty.AddTestResult("French", 41);

            students.AddStudent(anna);
            students.AddStudent(betty);
            students.AddStudent(carl);
        }
    }
}
