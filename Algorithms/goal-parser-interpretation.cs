/**
  Problem Name : Goal Parser Interpretation
  Problem URL : https://leetcode.com/problems/goal-parser-interpretation/submissions/
  Description :
    You own a Goal Parser that can interpret a string command. 
    The command consists of an alphabet of "G", "()" and/or "(al)" in some order. 
    The Goal Parser will interpret "G" as the string "G", "()" as the string "o", and "(al)" as the string "al". 
    The interpreted strings are then concatenated in the original order.

  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/
public class Solution 
{
    public string Interpret(string command) 
    {
        command = command.Replace("()", "o");
        command = command.Replace("(al)", "al");
        
        return command;
    }
}
