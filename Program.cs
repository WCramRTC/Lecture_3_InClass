namespace Lecture_3_InClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string Iphone Name
            // string Iphone version number
            // int Iphone capacity
            // string color

            // name
            // version number
            // capacity
            // color
            string[] phoneNames = { "Samsung Ultra", "IPhone", "Google Pixel", "IPhone" , "Google Pixel"};
            string[] versionNumbers = { "22", "15", "7", "14", "2"};
            int[] sizes = { 128, 256, 512, 2, 8};
            string[] colors = { "Blue", "Green", "Purple" , "Pink", "Pink"};

            Console.WriteLine("What color would you like to see?");
            string search = Console.ReadLine();


            // How do i only print the pink ones
            // If the color is Pink, print the phone
            for(int i = 0; i < phoneNames.Length; i++)
            {

                if (colors[i] == search)
                {
                    string phoneName = phoneNames[i];
                    string VersionNumber = versionNumbers[i];
                    int size = sizes[i];
                    string color = colors[i];

                    string formattedString = $"{phoneName} {VersionNumber} {size}Gb - {color}";

                    Console.WriteLine(formattedString);
                }
    

            }


    

        }
    }
}

// Initialized