﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RFDown.Extensions
{
    /// <summary>
    /// Extends <see cref="Dictionary{TKey, TValue}"/> where TValue is a integer type with AddOrIncrement
    /// </summary>
    public static class AddOrIncrementExt
    {
        /// <summary>
        /// Adds the key with value 1 if it doesn't exist, otherwise increments it by 1.
        /// </summary>
        /// <typeparam name="T">Type of key.</typeparam>
        /// <param name="dict">Dictionary to operate on.</param>
        /// <param name="key">Key to be added or incremented.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddOrIncrement<T>(this Dictionary<T, sbyte> dict, T key)
        {
            if (dict.ContainsKey(key))
            {
                dict[key]++;
            }
            else
            {
                dict[key] = 1;
            }
        }

        /// <summary>
        /// Adds the key with value <paramref name="incrementValue"/> if it doesn't exist, otherwise increments it by <paramref name="incrementValue"/>.
        /// </summary>
        /// <typeparam name="T">Type of key.</typeparam>
        /// <param name="dict">Dictionary to operate on.</param>
        /// <param name="key">Key to be added or incremented.</param>
        /// <param name="incrementValue">Value to be set and incremented by.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddOrIncrement<T>(this Dictionary<T, sbyte> dict, T key, sbyte incrementValue)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] += incrementValue;
            }
            else
            {
                dict[key] = incrementValue;
            }
        }

        /// <summary>
        /// Adds the key with value 1 if it doesn't exist, otherwise increments it by 1.
        /// </summary>
        /// <typeparam name="T">Type of key.</typeparam>
        /// <param name="dict">Dictionary to operate on.</param>
        /// <param name="key">Key to be added or incremented.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddOrIncrement<T>(this Dictionary<T, byte> dict, T key)
        {
            if (dict.ContainsKey(key))
            {
                dict[key]++;
            }
            else
            {
                dict[key] = 1;
            }
        }

        /// <summary>
        /// Adds the key with value <paramref name="incrementValue"/> if it doesn't exist, otherwise increments it by <paramref name="incrementValue"/>.
        /// </summary>
        /// <typeparam name="T">Type of key.</typeparam>
        /// <param name="dict">Dictionary to operate on.</param>
        /// <param name="key">Key to be added or incremented.</param>
        /// <param name="incrementValue">Value to be set and incremented by.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddOrIncrement<T>(this Dictionary<T, byte> dict, T key, byte incrementValue)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] += incrementValue;
            }
            else
            {
                dict[key] = incrementValue;
            }
        }

        /// <summary>
        /// Adds the key with value 1 if it doesn't exist, otherwise increments it by 1.
        /// </summary>
        /// <typeparam name="T">Type of key.</typeparam>
        /// <param name="dict">Dictionary to operate on.</param>
        /// <param name="key">Key to be added or incremented.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddOrIncrement<T>(this Dictionary<T, short> dict, T key)
        {
            if (dict.ContainsKey(key))
            {
                dict[key]++;
            }
            else
            {
                dict[key] = 1;
            }
        }

        /// <summary>
        /// Adds the key with value <paramref name="incrementValue"/> if it doesn't exist, otherwise increments it by <paramref name="incrementValue"/>.
        /// </summary>
        /// <typeparam name="T">Type of key.</typeparam>
        /// <param name="dict">Dictionary to operate on.</param>
        /// <param name="key">Key to be added or incremented.</param>
        /// <param name="incrementValue">Value to be set and incremented by.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddOrIncrement<T>(this Dictionary<T, short> dict, T key, short incrementValue)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] += incrementValue;
            }
            else
            {
                dict[key] = incrementValue;
            }
        }

        /// <summary>
        /// Adds the key with value 1 if it doesn't exist, otherwise increments it by 1.
        /// </summary>
        /// <typeparam name="T">Type of key.</typeparam>
        /// <param name="dict">Dictionary to operate on.</param>
        /// <param name="key">Key to be added or incremented.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddOrIncrement<T>(this Dictionary<T, ushort> dict, T key)
        {
            if (dict.ContainsKey(key))
            {
                dict[key]++;
            }
            else
            {
                dict[key] = 1;
            }
        }

        /// <summary>
        /// Adds the key with value <paramref name="incrementValue"/> if it doesn't exist, otherwise increments it by <paramref name="incrementValue"/>.
        /// </summary>
        /// <typeparam name="T">Type of key.</typeparam>
        /// <param name="dict">Dictionary to operate on.</param>
        /// <param name="key">Key to be added or incremented.</param>
        /// <param name="incrementValue">Value to be set and incremented by.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddOrIncrement<T>(this Dictionary<T, ushort> dict, T key, ushort incrementValue)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] += incrementValue;
            }
            else
            {
                dict[key] = incrementValue;
            }
        }

        /// <summary>
        /// Adds the key with value 1 if it doesn't exist, otherwise increments it by 1.
        /// </summary>
        /// <typeparam name="T">Type of key.</typeparam>
        /// <param name="dict">Dictionary to operate on.</param>
        /// <param name="key">Key to be added or incremented.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddOrIncrement<T>(this Dictionary<T, int> dict, T key)
        {
            if (dict.ContainsKey(key))
            {
                dict[key]++;
            }
            else
            {
                dict[key] = 1;
            }
        }

        /// <summary>
        /// Adds the key with value <paramref name="incrementValue"/> if it doesn't exist, otherwise increments it by <paramref name="incrementValue"/>.
        /// </summary>
        /// <typeparam name="T">Type of key.</typeparam>
        /// <param name="dict">Dictionary to operate on.</param>
        /// <param name="key">Key to be added or incremented.</param>
        /// <param name="incrementValue">Value to be set and incremented by.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddOrIncrement<T>(this Dictionary<T, int> dict, T key, int incrementValue)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] += incrementValue;
            }
            else
            {
                dict[key] = incrementValue;
            }
        }

        /// <summary>
        /// Adds the key with value 1 if it doesn't exist, otherwise increments it by 1.
        /// </summary>
        /// <typeparam name="T">Type of key.</typeparam>
        /// <param name="dict">Dictionary to operate on.</param>
        /// <param name="key">Key to be added or incremented.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddOrIncrement<T>(this Dictionary<T, uint> dict, T key)
        {
            if (dict.ContainsKey(key))
            {
                dict[key]++;
            }
            else
            {
                dict[key] = 1;
            }
        }

        /// <summary>
        /// Adds the key with value <paramref name="incrementValue"/> if it doesn't exist, otherwise increments it by <paramref name="incrementValue"/>.
        /// </summary>
        /// <typeparam name="T">Type of key.</typeparam>
        /// <param name="dict">Dictionary to operate on.</param>
        /// <param name="key">Key to be added or incremented.</param>
        /// <param name="incrementValue">Value to be set and incremented by.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddOrIncrement<T>(this Dictionary<T, uint> dict, T key, uint incrementValue)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] += incrementValue;
            }
            else
            {
                dict[key] = incrementValue;
            }
        }

        /// <summary>
        /// Adds the key with value 1 if it doesn't exist, otherwise increments it by 1.
        /// </summary>
        /// <typeparam name="T">Type of key.</typeparam>
        /// <param name="dict">Dictionary to operate on.</param>
        /// <param name="key">Key to be added or incremented.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddOrIncrement<T>(this Dictionary<T, long> dict, T key)
        {
            if (dict.ContainsKey(key))
            {
                dict[key]++;
            }
            else
            {
                dict[key] = 1;
            }
        }

        /// <summary>
        /// Adds the key with value <paramref name="incrementValue"/> if it doesn't exist, otherwise increments it by <paramref name="incrementValue"/>.
        /// </summary>
        /// <typeparam name="T">Type of key.</typeparam>
        /// <param name="dict">Dictionary to operate on.</param>
        /// <param name="key">Key to be added or incremented.</param>
        /// <param name="incrementValue">Value to be set and incremented by.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddOrIncrement<T>(this Dictionary<T, long> dict, T key, long incrementValue)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] += incrementValue;
            }
            else
            {
                dict[key] = incrementValue;
            }
        }

        /// <summary>
        /// Adds the key with value 1 if it doesn't exist, otherwise increments it by 1.
        /// </summary>
        /// <typeparam name="T">Type of key.</typeparam>
        /// <param name="dict">Dictionary to operate on.</param>
        /// <param name="key">Key to be added or incremented.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddOrIncrement<T>(this Dictionary<T, ulong> dict, T key)
        {
            if (dict.ContainsKey(key))
            {
                dict[key]++;
            }
            else
            {
                dict[key] = 1;
            }
        }

        /// <summary>
        /// Adds the key with value <paramref name="incrementValue"/> if it doesn't exist, otherwise increments it by <paramref name="incrementValue"/>.
        /// </summary>
        /// <typeparam name="T">Type of key.</typeparam>
        /// <param name="dict">Dictionary to operate on.</param>
        /// <param name="key">Key to be added or incremented.</param>
        /// <param name="incrementValue">Value to be set and incremented by.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddOrIncrement<T>(this Dictionary<T, ulong> dict, T key, ulong incrementValue)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] += incrementValue;
            }
            else
            {
                dict[key] = incrementValue;
            }
        }
    }
}
