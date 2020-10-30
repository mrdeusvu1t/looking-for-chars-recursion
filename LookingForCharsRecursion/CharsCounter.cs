using System;

namespace LookingForCharsRecursion
{
    public static class CharsCounter
    {
        /// <summary>
        /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <returns>The number of occurrences of all characters.</returns>
        public static int GetCharsCount(string str, char[] chars)
        {
            // TODO #1. Implement the method using recursive algorithm.
            if (chars is null)
            {
                throw new ArgumentNullException("error");
            }

            if (str is null)
            {
                throw new ArgumentNullException("error");
            }

            if (str.Length == 0)
            {
                return 0;
            }

            if (chars.Length == 0)
            {
                return 0;
            }

            return CharsCount1(str, chars);
        }

        public static int CharsCount1(string str, char[] chars, int i = 0, int j = 0)
        {
            if (str[i] == chars[j])
            {
                if (i + 1 == str.Length)
                {
                    return 1;
                }

                return 1 + CharsCount1(str, chars, i + 1, 0);
            }

            if (j + 1 < chars.Length)
            {
                return 0 + CharsCount1(str, chars, i, j + 1);
            }

            if (i + 1 < str.Length)
            {
                return 0 + CharsCount1(str, chars, i + 1, 0);
            }

            return 0;
        }

        /// <summary>
        /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <param name="startIndex">A zero-based starting index of the search.</param>
        /// <param name="endIndex">A zero-based ending index of the search.</param>
        /// <returns>The number of occurrences of all characters within the specified range of elements in the <see cref="string"/>.</returns>
        public static int GetCharsCount(string str, char[] chars, int startIndex, int endIndex)
        {
            // TODO #2. Implement the method using recursive algorithm.
            if (chars is null)
            {
                throw new ArgumentNullException("error");
            }

            if (str is null)
            {
                throw new ArgumentNullException("error");
            }

            if (endIndex > str.Length || endIndex < 0)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (startIndex > endIndex || startIndex > str.Length || startIndex < 0)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            return CharsCount2(str, chars, startIndex, endIndex);
        }

        public static int CharsCount2(string str, char[] chars, int startIndex, int endIndex, int i = 0)
        {
            if (str[startIndex] == chars[i])
            {
                if (startIndex + 1 > endIndex)
                {
                    return 1;
                }

                return 1 + CharsCount2(str, chars, startIndex + 1, endIndex, 0);
            }

            if (i + 1 < chars.Length)
            {
                return 0 + CharsCount2(str, chars, startIndex, endIndex, i + 1);
            }

            if (startIndex + 1 <= endIndex)
            {
                return 0 + CharsCount2(str, chars, startIndex + 1, endIndex, 0);
            }

            return 0;
        }

        /// <summary>
        /// Searches a string for a limited number of characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <param name="startIndex">A zero-based starting index of the search.</param>
        /// <param name="endIndex">A zero-based ending index of the search.</param>
        /// <param name="limit">A maximum number of characters to search.</param>
        /// <returns>The limited number of occurrences of characters to search for within the specified range of elements in the <see cref="string"/>.</returns>
        public static int GetCharsCount(string str, char[] chars, int startIndex, int endIndex, int limit)
        {
            // TODO #3. Implement the method using recursive algorithm.
            if (chars is null)
            {
                throw new ArgumentNullException("error");
            }

            if (str is null)
            {
                throw new ArgumentNullException("error");
            }

            if (endIndex > str.Length || endIndex < 0 || startIndex > endIndex || startIndex > str.Length || startIndex < 0)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (limit < 0)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            return CharsCount3(str, chars, startIndex, endIndex, limit);
        }

        public static int CharsCount3(string str, char[] chars, int startIndex, int endIndex, int limit, int i = 0)
        {
            if (str[startIndex] == chars[i])
            {
                if (startIndex + 1 > endIndex || limit - 1 == 0)
                {
                    return 1;
                }

                return 1 + CharsCount3(str, chars, startIndex + 1, endIndex, limit - 1, 0);
            }

            if (i + 1 < chars.Length)
            {
                return 0 + CharsCount3(str, chars, startIndex, endIndex, limit, i + 1);
            }

            if (startIndex + 1 <= endIndex)
            {
                return 0 + CharsCount3(str, chars, startIndex + 1, endIndex, limit, 0);
            }

            return 0;
        }
    }
}
