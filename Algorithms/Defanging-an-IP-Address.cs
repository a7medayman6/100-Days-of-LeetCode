/**
  Problem Name : Defanging an IP Address
  Problem URL : https://leetcode.com/problems/walking-robot-simulation/
  Description :
    Given a valid (IPv4) IP address, return a defanged version of that IP address.
    A defanged IP address replaces every period "." with "[.]".
  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/

public class Solution 
{
    public string DefangIPaddr(string address) 
    {
        return address.Replace(".", "[.]");
    }
}
