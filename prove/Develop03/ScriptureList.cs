namespace Develop03
{
    public class ScriptureList
    {
        private Dictionary<string, string> _scriptures = new Dictionary<string, string>();
        private Random _rand = new Random();

        public static string verse = "";
        public static string scripture = "";

        public ScriptureList()
        {
            this.DictionaryGenerator();
            int tempIndex = this._rand.Next(this._scriptures.Count());
            ScriptureList.verse = _scriptures.ElementAt(tempIndex).Key;
            ScriptureList.scripture = _scriptures.ElementAt(tempIndex).Value;
        }

        public void DictionaryGenerator()
        {
            this._scriptures.Add("Matthew 21:22", "And whatever you ask in prayer, you will receive, if you have faith.");
            this._scriptures.Add("Hebrews 11:1", "Now faith is the assurance of things hoped for, the conviction of things not seen.");
            this._scriptures.Add("1 Corinthians 13:4-7", "4 Love is patient and kind; love does not envy or boast; it is not arrogant \n\n 5 or rude. It does not insist on its own way; it is not irritable or resentful; \n\n 6 it does not rejoice at wrongdoing, but rejoices with the truth. \n\n 7 Love bears all things, believes all things, hopes all things, endures all things.");
            this._scriptures.Add("John 3:16", "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");
            this._scriptures.Add("Exodus 20:12", "Honor your father and your mother, that your days may be long in the land that the Lord your God is giving you.");
            this._scriptures.Add("Proverbs 22:6", "Train up a child in the way he should go; even when he is old he will not depart from it.");
            this._scriptures.Add("Matthew 6:14-15", "14 For if you forgive others their trespasses, your heavenly Father will also forgive you, \n\n 15 but if you do not forgive others their trespasses, neither will your Father forgive your trespasses.");
            this._scriptures.Add("Luke 17:3-4", "3 Pay attention to yourselves! If your brother sins, rebuke him, and if he repents, forgive him, \n\n 4 and if he sins against you seven times in the day, and turns to you seven times, saying, \"I repent,\" you must forgive him.");
            this._scriptures.Add("James 1:5", "If any of you lacks wisdom, let him ask God, who gives generously to all without reproach, and it will be given him.");
            this._scriptures.Add("Proverbs 3:13-18", "13 Blessed is the one who finds wisdom, \n\t and the one who gets understanding, \n14 for the gain from her is better than gain from silver \n\t and her profit better than gold. \n15 She is more precious than jewels, \n\t and nothing you desire can compare with her. \n16 Long life is in her right hand; \n\t in her left hand are riches and honor. \n17 Her ways are ways of pleasantness, \n\t and all her paths are peace. \n18 She is a tree of life to those who lay hold of her; \n\t those who hold her fast are called blessed.");
            this._scriptures.Add("Romans 12:12", "Rejoice in hope, be patient in tribulation, be constant in prayer.");
            this._scriptures.Add("Romans 5:2-5", "2 Through him we have also obtained access by faith into this grace in which we stand, and we rejoice in hope of the glory of God. \n3 Not only that, but we rejoice in our sufferings, knowing that suffering produces endurance, \n4 and endurance produces character, and character produces hope, \n5 and hope does not put us to shame, because God's love has been poured into our hearts through the Holy Spirit who has been given to us.");
            this._scriptures.Add("2 Corinthians 12:9", "But he said to me, “My grace is sufficient for you, for my power is made perfect in weakness.” Therefore I will boast all the more gladly of my weaknesses, so that the power of Christ may rest upon me.");
            this._scriptures.Add("Ephesians 2:8-9", "8 For by grace you have been saved through faith. And this is not your own doing; it is the gift of God, \n\n 9 not a result of works, so that no one may boast.");
            this._scriptures.Add("John 8:12", "Again Jesus spoke to them, saying, \"I am the light of the world. Whoever follows me will not walk in darkness, but will have the light of life.\"");
            this._scriptures.Add("Isaiah 42:16", "And I will lead the blind in a way that they do not know, in paths that they have not known I will guide them. I will turn the darkness before them into light, the rough places into level ground. These are the things I do, and I do not forsake them.");
            this._scriptures.Add("Isaiah 9:6", "For to us a child is born, to us a son is given; and the government shall be upon his shoulder, and his name shall be called Wonderful Counselor, Mighty God, Everlasting Father, Prince of Peace.");
            this._scriptures.Add("Isaiah 53:5", "But he was pierced for our transgressions; he was crushed for our iniquities; upon him was the chastisement that brought us peace, and with his wounds we are healed.");
            this._scriptures.Add("Hebrews 9:12", "He entered once for all into the holy places, not by means of the blood of goats and calves but by means of his own blood, thus securing an eternal redemption.");
            this._scriptures.Add("Colossians 3:17", "And whatever you do, in word or deed, do everything in the name of the Lord Jesus, giving thanks to God the Father through him.");
            this._scriptures.Add("Psalm 100:1-5", "1 A Psalm for giving thanks. Make a joyful noise to the Lord, all the earth! \n\t Serve the Lord with gladness! \n\t Come into his presence with singing! \n\n 3 Know that the Lord, he is God! \n\t It is he who made us, and we are his; \n\t we are his people, and the sheep of his pasture. \n\n 4 Enter his gates with thanksgiving, \n\t and his courts with praise! \n\t Give thanks to him; bless his name! \n\n 5 For the Lord is good; \n\t his steadfast love endures forever, \n\t and his faithfulness to all generations.");
            this._scriptures.Add("Matthew 9:13", "Go and learn what this means: \"I desire mercy, and not sacrifice.\" For I came not to call the righteous, but sinners.");
            }
    }
}