namespace GenericAnimalClass
{

    // define a generics class named Animal
    public class Animal<T>
    {
        // define a field of type T 
        public T data;

        // define a constructor of the Animal class 
        public Animal(T data)
        {
            this.data = data;
            //Console.WriteLine("Data passed: " + this.data);
        }
        public T getAnimal()
        {
            return data;
        }
    }

    internal class Program
    {
        private static void Main()
        {
            Animal<string> animalName = new("Tony the Tiger");

            Animal<int> averageLifeSpan = new(15);

            Animal<string> animalHabitat = new("forests, grasslands, and swamps");

            Animal<bool> endangered = new(true);

            Animal<bool> extinct = new(false);

            Console.WriteLine($"Animal Details: \nName: {animalName.getAnimal()}\nLifespan: {averageLifeSpan.getAnimal()} years\nHabitat: {animalHabitat.getAnimal()}\nEndangered: {endangered.getAnimal()}\nExtinct: {extinct.getAnimal()}");
        }
    }
}