using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Regex_PartOut
    {
			
			static public int RegexPartOut(this string item, Regex pattern, out string output1)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1);
			}
		
			static public int RegexPartOut(this string item, string pattern, out string output1)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1);
			}
		
			static public int RegexPartOut(this string item, CachedRegex pattern, out string output1)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1);
			}
					
			static public int RegexPartOut(this string item, Regex pattern, out string output1, out string output2)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2);
			}
		
			static public int RegexPartOut(this string item, string pattern, out string output1, out string output2)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2);
			}
		
			static public int RegexPartOut(this string item, CachedRegex pattern, out string output1, out string output2)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2);
			}
					
			static public int RegexPartOut(this string item, Regex pattern, out string output1, out string output2, out string output3)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3);
			}
		
			static public int RegexPartOut(this string item, string pattern, out string output1, out string output2, out string output3)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3);
			}
		
			static public int RegexPartOut(this string item, CachedRegex pattern, out string output1, out string output2, out string output3)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3);
			}
					
			static public int RegexPartOut(this string item, Regex pattern, out string output1, out string output2, out string output3, out string output4)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4);
			}
		
			static public int RegexPartOut(this string item, string pattern, out string output1, out string output2, out string output3, out string output4)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4);
			}
		
			static public int RegexPartOut(this string item, CachedRegex pattern, out string output1, out string output2, out string output3, out string output4)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4);
			}
					
			static public int RegexPartOut(this string item, Regex pattern, out string output1, out string output2, out string output3, out string output4, out string output5)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4, out output5);
			}
		
			static public int RegexPartOut(this string item, string pattern, out string output1, out string output2, out string output3, out string output4, out string output5)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4, out output5);
			}
		
			static public int RegexPartOut(this string item, CachedRegex pattern, out string output1, out string output2, out string output3, out string output4, out string output5)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4, out output5);
			}
					
			static public int RegexPartOut(this string item, Regex pattern, out string output1, out string output2, out string output3, out string output4, out string output5, out string output6)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4, out output5, out output6);
			}
		
			static public int RegexPartOut(this string item, string pattern, out string output1, out string output2, out string output3, out string output4, out string output5, out string output6)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4, out output5, out output6);
			}
		
			static public int RegexPartOut(this string item, CachedRegex pattern, out string output1, out string output2, out string output3, out string output4, out string output5, out string output6)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4, out output5, out output6);
			}
					
			static public int RegexPartOut(this string item, Regex pattern, out string output1, out string output2, out string output3, out string output4, out string output5, out string output6, out string output7)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4, out output5, out output6, out output7);
			}
		
			static public int RegexPartOut(this string item, string pattern, out string output1, out string output2, out string output3, out string output4, out string output5, out string output6, out string output7)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4, out output5, out output6, out output7);
			}
		
			static public int RegexPartOut(this string item, CachedRegex pattern, out string output1, out string output2, out string output3, out string output4, out string output5, out string output6, out string output7)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4, out output5, out output6, out output7);
			}
					
			static public int RegexPartOut(this string item, Regex pattern, out string output1, out string output2, out string output3, out string output4, out string output5, out string output6, out string output7, out string output8)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4, out output5, out output6, out output7, out output8);
			}
		
			static public int RegexPartOut(this string item, string pattern, out string output1, out string output2, out string output3, out string output4, out string output5, out string output6, out string output7, out string output8)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4, out output5, out output6, out output7, out output8);
			}
		
			static public int RegexPartOut(this string item, CachedRegex pattern, out string output1, out string output2, out string output3, out string output4, out string output5, out string output6, out string output7, out string output8)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4, out output5, out output6, out output7, out output8);
			}
					
			static public int RegexPartOut(this string item, Regex pattern, out string output1, out string output2, out string output3, out string output4, out string output5, out string output6, out string output7, out string output8, out string output9)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4, out output5, out output6, out output7, out output8, out output9);
			}
		
			static public int RegexPartOut(this string item, string pattern, out string output1, out string output2, out string output3, out string output4, out string output5, out string output6, out string output7, out string output8, out string output9)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4, out output5, out output6, out output7, out output8, out output9);
			}
		
			static public int RegexPartOut(this string item, CachedRegex pattern, out string output1, out string output2, out string output3, out string output4, out string output5, out string output6, out string output7, out string output8, out string output9)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4, out output5, out output6, out output7, out output8, out output9);
			}
					
			static public int RegexPartOut(this string item, Regex pattern, out string output1, out string output2, out string output3, out string output4, out string output5, out string output6, out string output7, out string output8, out string output9, out string output10)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4, out output5, out output6, out output7, out output8, out output9, out output10);
			}
		
			static public int RegexPartOut(this string item, string pattern, out string output1, out string output2, out string output3, out string output4, out string output5, out string output6, out string output7, out string output8, out string output9, out string output10)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4, out output5, out output6, out output7, out output8, out output9, out output10);
			}
		
			static public int RegexPartOut(this string item, CachedRegex pattern, out string output1, out string output2, out string output3, out string output4, out string output5, out string output6, out string output7, out string output8, out string output9, out string output10)
			{
				return item.RegexMatch(pattern)
					.Groups.Bridge<Group>()
					.Offset(1)
					.Convert(g => g.Value)
					.PartOut(out output1, out output2, out output3, out output4, out output5, out output6, out output7, out output8, out output9, out output10);
			}
				}
}