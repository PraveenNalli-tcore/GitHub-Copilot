// Create a method that generates a comment for a given skill
using System;
namespace Skills
{
    public class Comments
    {
        public static string GenerateComment(string skillName, string comment)
        {
            return $"Skill: {skillName}\nComment: {comment}";
        }
    }
}