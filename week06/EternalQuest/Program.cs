using System;

class Program
{
    static void Main(string[] args)
    {
        /*
         * EXCEEDING REQUIREMENTS:
         * I added a Ranking System (GetRankTitle in GoalManager). 
         * Based on the total points the user has accumulated, they are awarded a specific title 
         * (e.g., Novice, Motivated Beginner, Consistent Explorer, Dedicated Achiever, Master of Habits).
         * This title is displayed on the main menu next to their score, providing extra gamification 
         * and motivation to keep recording events.
         */

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}