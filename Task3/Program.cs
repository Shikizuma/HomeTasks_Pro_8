using HomeTasks_Pro_8;
using System.Xml.Serialization;

namespace Task3
{

    public class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(TestClass));
            TestClass testClass1;
            using (StreamReader streamReader = new StreamReader("C:\\Users\\myros\\source\\repos\\HomeTasks_Pro_8\\HomeTasks_Pro_8\\bin\\Debug\\net6.0\\Test.xml"))
            {
                testClass1 = xmlSerializer.Deserialize(streamReader) as TestClass;
            }

            Console.WriteLine(testClass1);
        }
    }
}