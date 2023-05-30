using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetiorGame
{
    internal class Words
    {
        //List<string> easyWords = new List<string> {"help", "love", "life", "time", "like", "good", "home", "work", "baby", "mind", "need", "play", "song", "book", "cool", "jump",
        //    "kiss", "moon", "rain", "calm", "fire", "girl", "hope", "idea", "joke", "kind", "luck", "meet", "open", "park", "quiet", "read", "star", "talk", "walk", "year", "zone",
        //    "cake", "door", "edge", "face", "game", "hair", "idea", "join", "kite", "late", "moon", "nice", "oven", "pink", "quiz", "rule", "song", "time", "urge", "vast", "wake", "yoga",
        //    "zero", "apple", "blend", "charm", "dance", "early", "faith", "glass", "happy", "image", "juice", "kitty", "laugh", "money", "noble", "ocean", "peace", "quick", "roast", "smile",
        //    "taste", "unity", "value", "water", "xenon", "youth", "zebra", "alive", "brave", "cheer", "dream", "eager", "fancy", "gifts", "haste", "jolly", "knees", "loved", "magic", "never",
        //    "oasis", "peace", "quick", "royal", "shine", "tooth", "unity", "vivid", "witty", "xerox", "yield", "zebra", "acute", "bliss", "candy", "drift", "eager", "faith", "grace", "honor",
        //    "ideal", "jolly", "keen", "lucky", "merry", "noble", "order", "proud", "quest", "rapid", "serene", "trust", "unite", "value", "wispy", "xenon", "youth", "zebra", "agile", "bliss",
        //    "calm", "dawn", "eager", "flame", "grace", "heart", "ideal", "jolly", "keen", "lucid", "magic", "noble", "order", "peace", "quick", "roam", "serene", "thrive", "unite", "vivid",
        //    "witty", "xenon", "yield", "zebra", "amaze", "blaze", "chill", "dream", "early", "flair", "grace", "hasty", "ideal", "jolly", "keen", "lucid", "magic", "noble", "order", "peace",
        //    "quick", "roam", "serene", "thrive", "unique", "vivid", "witty", "xenon", "yield", "zebra", "acute", "bliss", "calm", "dawn", "eager", "flame", "grace", "heart", "ideal", "jolly",
        //    "keen", "lucid", "magic", "noble", "order", "peace", "quick", "roam", "serene", "thrive", "unique", "vivid", "witty", "xenon", "yield", "zebra"};

        List<string> mediumWords = new List<string> { "kindly", "chicken", "freedom", "balance", "journey", "bravery", "justice", "honesty", "ability", "believe", "deserve", "awesome", "healthy",
            "wonder", "sunset", "safely", "victory", "perfect", "smiling", "silence", "respect", "sunrise", "happiness", "purpose", "beloved", "promise", "achieve", "fortune", "breathe",
            "freely", "mystery", "healing", "fantasy", "loyalty", "success", "forgive", "gratitude", "content", "graceful", "genuine", "patient", "explore", "adventure", "control", "courage",
            "freeway", "balance", "musical", "endless", "fashion", "support", "charity", "prepare", "feeling", "belong", "feather", "morning", "warming", "comfort", "deliver", "wishing", "journey",
            "outcome", "precise", "release", "healing", "moment", "pleased", "hearing", "respond", "inspire", "display", "embrace", "scenery", "realize", "awesome", "devoted", "freedom", "honesty",
            "fulfill", "freely", "promise", "deserve", "believe", "victory", "healthy", "wonder", "silence", "purpose", "justice", "respect", "balance", "perfect", "kindly", "journey", "fortune",
            "achieve", "breathe", "content", "patient", "control", "graceful", "loyalty", "adventure", "explore", "forgive", "courage", "success", "fantasy", "genuine", "musical", "prepare",
            "charity", "support", "endless", "feeling", "feather", "morning", "freeway", "belong", "outcome", "pleased", "hearing", "wishing", "deliver", "scenery", "moment", "inspire", "realize",
            "release", "display", "embrace", "precise", "awesome", "respond", "devoted", "healing", "freedom", "promise", "believe", "healthy", "silence", "balance", "purpose", "perfect", "victory",
            "honesty", "respect", "content", "patient", "graceful", "deserve", "freely", "journey", "charity", "wonder", "achieve", "fulfill", "control", "genuine", "success", "forgive", "loyalty"
            , "courage", "adventure", "explore", "fantasy", "prepare", "support", "musical", "endless", "feeling", "morning", "belong", "feather", "freeway", "outcome", "pleased", "hearing", "deliver",
            "wishing", "scenery", "moment", "inspire", "realize", "release", "display", "embrace", "precise", "awesome", "respond", "devoted", "healing" };

        List<string> hardWords = new List<string> { "beautiful", "wonderful", "important", "happiness", "brilliant", "adventure", "grateful", "delicious", "potential", "fantastic", "favourite", "inspiring",
            "knowledge", "memorable", "colorful", "exciting", "creative", "energetic", "friendly", "music", "awesome", "laughter", "freedom", "positive", "success", "sunshine", "blessings", "courageous",
            "adore", "progress", "vibrant", "tranquil", "proud", "content", "dreaming", "beloved", "cherish", "comfort", "genuine", "graceful", "harmony", "bloom", "eternal", "miracle", "promise", "whisper",
            "balance", "loyalty", "imagine", "journey", "cuddle", "blissful", "champion", "purpose", "victory", "precious", "radiant", "sparkle", "sunrise", "wonder", "awesome", "festival", "freedom",
            "kindness", "laughter", "meaning", "vibrant", "excited", "fantasy", "charming", "fashion", "healing", "healthy", "sincere", "loyalty", "powerful", "promise", "blessing", "smiling", "strength",
            "tranquil", "fortune", "inspire", "glowing", "serenity", "treasure", "triumph", "angelic", "paradise", "positive", "awesome", "victory", "gratitude", "elegant", "radiant", "miracle", "eternal",
            "blossom", "sunbeam", "kindness", "content", "peaceful", "gentle", "sparkle", "freedom", "wonder", "graceful", "beloved", "harmony", "journey", "fantasy", "laughter", "promise", "vibrant", "passion",
            "precious", "blissful", "healing", "loyalty", "excited", "sincere", "sunrise", "purpose", "charming", "triumph", "fortune", "fashion", "whisper", "glowing", "balance", "inspire", "powerful", "success",
            "radiant", "treasure", "serenity", "awesome", "gratitude", "elegant", "positive", "miracle", "eternal", "blossom", "content", "paradise", "gentle", "harmony", "peaceful", "kindness", "journey", "laughter",
            "promise", "sparkle", "vibrant", "freedom", "wonder", "beloved", "graceful", "sincere", "passion", "precious", "healing", "purpose", "charming", "triumph", "fortune", "fashion", "glowing", "sunrise",
            "whisper", "inspire", "balance", "powerful", "radiant", "treasure", "awesome", "serenity", "gratitude", "positive", "miracle", "eternal", "blossom", "paradise", "gentle", "content", "peaceful", "kindness",
            "journey", "laughter", "promise", "sparkle" };
    }

}
