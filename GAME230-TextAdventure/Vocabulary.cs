﻿namespace GAME230_TextAdventure;

public static class Vocabulary
{
    // These verbs are commands that can be triggered and need to specify a noun as the recipient for the action
    private static List<string> nonStandaloneVerbs = new List<string>()
    {
        "eat",
        "go",
        "take",
        "drop"
    };
    
    // These verbs are commands that can be triggered alone, without specifying a recipient of the action
    private static List<string> standaloneVerbs = new List<string>()
    {
        "toggle-debugger",
        "look",
        "inventory",
        "exit",
    };
    
    // These verbs are commands that can be triggered and need to specify a noun as the recipient for the action
    private static List<string> nouns = new List<string>()
    {
        "north", "east", "south", "west", "up", "down"
    };

    public static bool IsVerb(string word)
    {
        return nonStandaloneVerbs.Contains(word) || standaloneVerbs.Contains(word);
    }

    public static bool IsStandaloneVerb(string word)
    {
        return standaloneVerbs.Contains(word);
    }

    public static bool IsNoun(string word)
    {
        return nouns.Contains(word);
    }

    public static void AddNoun(String noun)
    {
        if (!nouns.Contains(noun))
        {
            nouns.Add(noun.ToLower());
        }
    }
}