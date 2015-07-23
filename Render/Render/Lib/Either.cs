﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Render.Lib
{
    public class Either<TL, TR>
    {
        private readonly TL _left;
        private readonly TR _right;

        internal Either(bool isLeft, TL left, TR right)
        {
            _left = left;
            _right = right;

            IsLeft = isLeft;
        }

        public bool IsLeft { get; }

        public bool IsRight => !IsLeft;

        public Either<TL, TR1> SelectMany<TR1>(Func<TR, Either<TL, TR1>> func)
        {
            return IsRight ? func(_right) : new Either<TL, TR1>(true, _left, default(TR1));
        }

        public Either<TL, TR> OrElse(Func<Either<TL, TR>> other)
        {
            return IsRight ? this : other();
        }
    }

    public static class Either
    {
        public static Either<TL, TR> Left<TL, TR>(TL left)
        {
            return new Either<TL, TR>(true, left, default(TR));
        }

        public static Either<TL, TR> Right<TL, TR>(TR right)
        {
            return new Either<TL, TR>(false, default(TL), right);
        }


        public static Either<TL, TR2> Select<TL, TR1, TR2>(this Either<TL, TR1> either, Func<TR1, TR2> func)
        {
            return either.SelectMany(r => Right<TL, TR2>(func(r)));
        }
    }
}
