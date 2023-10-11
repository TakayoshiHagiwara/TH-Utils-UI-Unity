// -----------------------------------------------------------------------
// Author:  Takayoshi Hagiwara (Toyohashi University of Technology)
// Created: 2023/7/17
// Summary: A collection of extended string class.
// -----------------------------------------------------------------------

using System.Text;
using UnityEngine;

namespace TH.Utils.UI
{
    public static class StringExtentions
    {
        static readonly string baseText = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        static readonly StringBuilder sb = new StringBuilder();
        static readonly int baseTextLen = baseText.Length;

        /// <summary>
        /// Return the random string of any length.
        /// GC Alloc occurs.
        /// </summary>
        /// <param name="len">Length of string.</param>
        /// <returns>Random string.</returns>
        public static string RandomString(int len = 5)
        {
            sb.Clear();
            for(int i = 0; i < len; i++)
            {
                sb.Append(baseText[Random.Range(0, baseTextLen)]);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Shuffle the target string.
        /// Uses the Fisher-Yates shuffle algorithm.
        /// GC Alloc occurs.
        /// </summary>
        /// <param name="text">String to shuffle.</param>
        /// <returns>Shuffled string.</returns>
        public static string Shuffle(this string text)
        {
            char[] charArray = text.ToCharArray();
            char tmp;

            for(int i = text.Length - 1; i > 0; i--)
            {
                int j = Random.Range(0, i + 1);
                tmp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = tmp;
            }

            return new string(charArray);
        }
    }
}