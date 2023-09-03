using System.Runtime.Serialization.Formatters.Binary;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Name = "Jon", Email = "email123@email.com" };   
            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream stream = new FileStream("user.bin", FileMode.Create))
            {
                bf.Serialize(stream, user);
            }

            User deserializedUser;
            using (FileStream stream = new FileStream("user.bin", FileMode.Open))
            {
                deserializedUser =  bf.Deserialize(stream) as User;
            }

            Console.WriteLine("Deserialized User:");
            Console.WriteLine($"Name: {deserializedUser.Name}");
            Console.WriteLine($"Email: {deserializedUser.Email}");
        }
    }
}