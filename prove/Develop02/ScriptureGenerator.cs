using System;
using System. Collections.Generic;
using System.IO;
//DailyScripture class provides functionality to generate a random scripture for the day

public class DailyScripture
{
    private List<string> _scriptures = new List<string>
    {   
        // Scriptures from the Bible
        "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life. - John 3:16",
        "The Lord is my shepherd; I shall not want. - Psalm 23:1",
        "Trust in the Lord with all your heart, and do not lean on your own understanding. - Proverbs 3:5",
        // Scriptures from the Book of Mormon
        "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them. - 1 Nephi 3:7",
        "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God. - Mosiah 2:17",
        "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall. - Helaman 5:12",
        "And it came to pass that he cried mightily unto the Lord all that day; and behold, the voice of the Lord came unto him, saying: - Ether 2:19",
        "O then, if I have seen so great things, if the Lord in his condescension unto the children of men hath visited men in so much mercy, why should my heart weep and my soul linger in the valley of sorrow, and my flesh waste away, and my strength slacken, because of mine afflictions? - 1 Nephi 11:17",
        "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall. - Helaman 5:12",
        "But behold, I, Nephi, will show unto you that the tender mercies of the Lord are over all those whom he hath chosen, because of their faith, to make them mighty even unto the power of deliverance. - 1 Nephi 1:20"
    };

    public Random _random = new Random();

    // Method to get a random scripture from the list
    public string GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
