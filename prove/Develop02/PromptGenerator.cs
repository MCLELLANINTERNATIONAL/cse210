using System;

public class PromptGenerator
{
   public List<string> _prompts = new List<string>  
    { 
        "Who was the most interesting person I interacted with today at work?",
        "What was the most interesting part of your day?",
        "How did I see the hand of the Lord in my Life today?",
        "Did I have an enlightening experience today?",
        "Did I help someone today?",
        "Did I visit a place on my bucket list today?",
        "What did I do on my vacation today?",
        "What was the most challenging obstacle I needed to overcome today?",
        "What new skill did I learn today?",
        "What made me laugh the hardest today?",
        "What made me cry today?",
        "Who did I speak to today that I had not spoken to in a long time?",
        "What was the most peaceful moment in my day?",
        "What did I do today for my personal self-care?",
        "What am I most grateful for today?",
        "If I could do one thing over again today, what would that be?",
   };
   public Random random = new Random();

   public string GetRandomPrompt()
   {
      string prompt = _prompts[random.Next(_prompts.Count)];
      return prompt;
   }
}