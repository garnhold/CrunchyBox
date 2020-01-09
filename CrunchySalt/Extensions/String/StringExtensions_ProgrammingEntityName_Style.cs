using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class StringExtensions_ProgrammingEntityName_Style
    {
        static public string StyleAsEntity(this string item)
        {
            return item
                .RegexReplace("([^A-Za-z0-9_]+)", "_")
                .RegexRemove("(^[0-9_]+|[^A-Za-z0-9_]|[_]+$)")
                .CoalesceBlank(() => ProgrammingEntityName.GenerateEntityName());
        }

        static public string StyleAsUnderscoredEntity(this string item)
        {
            return item.StyleAsEntity().RegexReplace("([^_])([A-Z])(?=[a-z])", delegate(Match match) {
                return match.Groups[1].Value + "_" + match.Groups[2].Value;
            }).ToLower();
        }

        static public string StyleAsUppercasedEntity(this string item)
        {
            return item.StyleAsEntity().RegexReplace("(^|_)(.)", delegate(Match match) {
                return match.Groups[2].Value.ToUpper();
            });
        }

        static public string StyleAsCapitalizedEntity(this string item)
        {
            return item.StyleAsEntity().RegexReplace("^.", delegate(Match match) {
                return match.Value.ToUpper();
            });
        }

        static public string StyleAsAnticapitalizedEntity(this string item)
        {
            return item.StyleAsEntity().RegexReplace("^.", delegate(Match match) {
                return match.Value.ToLower();
            });
        }

        static public string StyleAsClassName(this string item)
        {
            return item.StyleAsUppercasedEntity();
        }

        static public string StyleAsInterfaceName(this string item)
        {
            return "I" + item.StyleAsClassName().RegexRemove("^I(?=[A-Z])");
        }

        static public string StyleAsFunctionName(this string item)
        {
            return item.StyleAsUppercasedEntity();
        }

        static public string StyleAsVariableName(this string item)
        {
            string variable_name = item.StyleAsUnderscoredEntity();

            if (variable_name.IsReservedKeyword())
                return "@" + variable_name;

            return variable_name;
        }

        static public string StyleAsPropertyName(this string item)
        {
            return item.StyleAsUppercasedEntity();
        }

        static public string StyleAsConstantName(this string item)
        {
            return item.StyleAsVariableName().ToUpper();
        }

        static public string StyleAsEnumName(this string item)
        {
            return item.StyleAsUppercasedEntity();
        }
    }
}