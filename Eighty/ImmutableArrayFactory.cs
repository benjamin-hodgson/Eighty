using System;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Eighty
{
    internal static class ImmutableArrayFactory
    {
        private static readonly Func<Attr[], ImmutableArray<Attr>> _unsafeFreezeAttr = GetUnsafeFreeze<Attr>();
        private static readonly Func<Html[], ImmutableArray<Html>> _unsafeFreezeHtml = GetUnsafeFreeze<Html>();
        private static Func<T[], ImmutableArray<T>> GetUnsafeFreeze<T>()
        {
            var ctor = typeof(ImmutableArray<T>)
                .GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance)
                .Single(c => c.GetParameters().Count() == 1 && c.GetParameters().Single().ParameterType.Equals(typeof(T[])));
            var param = Expression.Parameter(typeof(T[]));
            var body = Expression.New(ctor, param);
            var func = Expression.Lambda<Func<T[], ImmutableArray<T>>>(body, param);
            return func.Compile();
        }

        public static ImmutableArray<Attr> Create(Attr item1)
            => ImmutableArray.Create(item1);
        public static ImmutableArray<Attr> Create(Attr item1, Attr item2)
            => ImmutableArray.Create(item1, item2);
        public static ImmutableArray<Attr> Create(Attr item1, Attr item2, Attr item3)
            => ImmutableArray.Create(item1, item2, item3);
        public static ImmutableArray<Attr> Create(Attr item1, Attr item2, Attr item3, Attr item4)
            => ImmutableArray.Create(item1, item2, item3, item4);

        public static ImmutableArray<Attr> Create(Attr item1, Attr item2, Attr item3, Attr item4, Attr item5)
            => UnsafeFreeze(new[] { item1, item2, item3, item4, item5 });
        public static ImmutableArray<Attr> Create(Attr item1, Attr item2, Attr item3, Attr item4, Attr item5, Attr item6)
            => UnsafeFreeze(new[] { item1, item2, item3, item4, item5, item6 });
        public static ImmutableArray<Attr> Create(Attr item1, Attr item2, Attr item3, Attr item4, Attr item5, Attr item6, Attr item7)
            => UnsafeFreeze(new[] { item1, item2, item3, item4, item5, item6, item7 });
        public static ImmutableArray<Attr> Create(Attr item1, Attr item2, Attr item3, Attr item4, Attr item5, Attr item6, Attr item7, Attr item8)
            => UnsafeFreeze(new[] { item1, item2, item3, item4, item5, item6, item7, item8 });

        public static ImmutableArray<Attr> UnsafeFreeze(Attr[] items)
            => _unsafeFreezeAttr(items);


        public static ImmutableArray<Html> Create(Html item1)
            => ImmutableArray.Create(item1);
        public static ImmutableArray<Html> Create(Html item1, Html item2)
            => ImmutableArray.Create(item1, item2);
        public static ImmutableArray<Html> Create(Html item1, Html item2, Html item3)
            => ImmutableArray.Create(item1, item2, item3);
        public static ImmutableArray<Html> Create(Html item1, Html item2, Html item3, Html item4)
            => ImmutableArray.Create(item1, item2, item3, item4);

        public static ImmutableArray<Html> Create(Html item1, Html item2, Html item3, Html item4, Html item5)
            => UnsafeFreeze(new[] { item1, item2, item3, item4, item5 });
        public static ImmutableArray<Html> Create(Html item1, Html item2, Html item3, Html item4, Html item5, Html item6)
            => UnsafeFreeze(new[] { item1, item2, item3, item4, item5, item6 });
        public static ImmutableArray<Html> Create(Html item1, Html item2, Html item3, Html item4, Html item5, Html item6, Html item7)
            => UnsafeFreeze(new[] { item1, item2, item3, item4, item5, item6, item7 });
        public static ImmutableArray<Html> Create(Html item1, Html item2, Html item3, Html item4, Html item5, Html item6, Html item7, Html item8)
            => UnsafeFreeze(new[] { item1, item2, item3, item4, item5, item6, item7, item8 });

        public static ImmutableArray<Html> UnsafeFreeze(Html[] items)
            => _unsafeFreezeHtml(items);
    }
}