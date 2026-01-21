using System.Collections.Concurrent;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Studying.Day_4
{
    public static class MemorizeFunc
    {
        public static Func<T, TResult> Memoize<T, TResult>(this Func<T, TResult> func)
        {
            var cache = new ConcurrentDictionary<T, TResult>();
            return x => cache.GetOrAdd(x, func);
        }

        public static string ToSnakeCase(this string input) {
            if(string.IsNullOrWhiteSpace(input))
                return input;
            
            var sb = new StringBuilder(input.Length + 10);
            for(int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (char.IsUpper(c))
                {
                    if(i > 0 && char.IsLower(input[i-1]) || char.IsDigit(input[i - 1]))
                    {
                        sb.Append('_');
                    }

                    sb.Append(char.ToLowerInvariant(c));
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

        public static string ToCamelCase(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            var parts = input.Split(['-', '_', ' '], StringSplitOptions.RemoveEmptyEntries);
            var result = parts[0].ToLowerInvariant();
            for(int i = 0; i < parts.Length; i++)
            {
                result += CultureInfo.InvariantCulture.TextInfo.ToTitleCase(parts[i].ToLowerInvariant());
            }

            return result;
        }

        public static string SplitPascalCase(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            return Regex.Replace(
                input,
                "(?<!^)([A-Z][a-z]|(?<=[a-z])[A-Z])",
                " $1");
        }

        public static string RemoveDiacritics(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            var normalized = input.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (var c in normalized)
            {
                var category = CharUnicodeInfo.GetUnicodeCategory(c);

                if (category != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
