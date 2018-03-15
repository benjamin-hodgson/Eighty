using System;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Eighty
{
    internal static class ImmutableArrayFactory
    {
        public static ImmutableArray<T> Create<T>(T item1)
            => ImmutableArray.Create(item1);
        public static ImmutableArray<T> Create<T>(T item1, T item2)
            => ImmutableArray.Create(item1, item2);
        public static ImmutableArray<T> Create<T>(T item1, T item2, T item3)
            => ImmutableArray.Create(item1, item2, item3);
        public static ImmutableArray<T> Create<T>(T item1, T item2, T item3, T item4)
            => ImmutableArray.Create(item1, item2, item3, item4);

        public static ImmutableArray<T> Create<T>(T item1, T item2, T item3, T item4, T item5)
            => UnsafeFreeze(new[] { item1, item2, item3, item4, item5 });
        public static ImmutableArray<T> Create<T>(T item1, T item2, T item3, T item4, T item5, T item6)
            => UnsafeFreeze(new[] { item1, item2, item3, item4, item5, item6 });
        public static ImmutableArray<T> Create<T>(T item1, T item2, T item3, T item4, T item5, T item6, T item7)
            => UnsafeFreeze(new[] { item1, item2, item3, item4, item5, item6, item7 });
        public static ImmutableArray<T> Create<T>(T item1, T item2, T item3, T item4, T item5, T item6, T item7, T item8)
            => UnsafeFreeze(new[] { item1, item2, item3, item4, item5, item6, item7, item8 });

        /// <summary>
        /// Unsafely turn a T[] into an <see cref="ImmutableArray{T}"/>.
        /// Don't mutate the input array afterwards!
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ImmutableArray<T> UnsafeFreeze<T>(T[] items)
            // wowza, what's going on here? ImmutableArray<T> is a struct with a single T[] field,
            // so it's represented at runtime in the same way as T[].
            // Unsafe.As lets us unsafely coerce between the two representations.
            // So this is basically equivalent to calling ImmutableArray<T>'s private constructor,
            // except I don't have to call the ctor by reflection and codegen.
            // This saves a virtual call (although no real difference in practice) and makes
            // it easy to implement this method generically (quite difficult with codegen).
            // See discussion here: https://github.com/dotnet/corefx/issues/28064#issuecomment-373388610
            => Unsafe.As<T[], ImmutableArray<T>>(ref items);
    }
}