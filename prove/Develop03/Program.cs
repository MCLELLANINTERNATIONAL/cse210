using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        List<Scripture> _scriptures = new List<Scripture>
        {
         new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me."),
            new Scripture(new Reference("1 Nephi", 3, 7, 8), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them. And it came to pass that I, Nephi, was exceedingly young, yet large in stature; and the words which I spake were plain and powerful."),
            new Scripture(new Reference("Mosiah", 2, 17, 18), "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God. When ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("Helaman", 5, 12, 13), "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall. Remember, remember my sons, the words that King Benjamin spake unto his people; yea, remember that there is no other way nor means whereby man can be saved, only through the atoning blood of Jesus Christ, who shall come; yea, remember that he cometh to redeem the world."),
            new Scripture(new Reference("1 Nephi", 1, 20, 21), "But behold, I, Nephi, will show unto you that the tender mercies of the Lord are over all those whom he hath chosen, because of their faith, to make them mighty even unto the power of deliverance. And I, Nephi, have written these things unto my people, that perhaps I might persuade them that they would remember the Lord their Redeemer.")
        };

        Random random = new Random();
        Scripture selectedScripture = _scriptures[random.Next(_scriptures.Count)]; // Randomly selects a scripture

        while (!selectedScripture.AllWordsHidden())
        {
            Console.Clear();
            selectedScripture.Display();
            Console.WriteLine("Press ENTER to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            
            selectedScripture.HideRandomWords(3);
        }
    }
}