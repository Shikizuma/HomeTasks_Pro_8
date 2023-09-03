using System.Xml.Serialization;

namespace HomeTasks_Pro_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            testClass.Name = "Test";
            testClass.Age = 10;
            testClass.Salary = 20;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(TestClass));

            using (StreamWriter streamWriter = new StreamWriter("Test.xml"))
            {
                xmlSerializer.Serialize(streamWriter, testClass);
            }

            TestClass testClass1;
            using (StreamReader streamReader = new StreamReader("Test.xml"))
            {
                testClass1 = xmlSerializer.Deserialize(streamReader) as TestClass;
            }

            Console.WriteLine(testClass1);
        }
    }
}