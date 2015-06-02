using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using FsharpNetInterop;
using Microsoft.FSharp.Core;

namespace FsharpNetInterop.CsharpTests
{
    public class Tests
    {
        [Test]
        public void ReferenceToOptionNullValue()
        {
            string nullStr = null;
            var expected = FSharpOption<string>.None;
            var result = Option.ReferenceToOption(nullStr);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ReferenceToOptionActualValue()
        {
            var str = "This is a string.";
            var expected = FSharpOption<string>.Some(str);
            var result = Option.ReferenceToOption(str);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void NullableToOptionNullValue()
        {
            int? nullInt = null;
            var expected = FSharpOption<int>.None;
            var result = Option.NullableToOption(nullInt);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void NullableToOptionActualValue()
        {
            int? actualInt = 42;
            var expected = FSharpOption<int>.Some(actualInt.Value);
            var result = Option.NullableToOption(actualInt);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void OptionToReferenceNone()
        {
            var none = FSharpOption<string>.None;
            string expected = null;
            var result = Option.OptionToReference(none);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void OptionToReferenceSome()
        {
            var expected = "This is a string.";
            var some = FSharpOption<string>.Some(expected);
            var result = Option.OptionToReference(some);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void OptionToNullableNone()
        {
            var none = FSharpOption<int>.None;
            int? expected = null;
            var result = Option.OptionToNullable(none);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void OptionToNullableSome()
        {
            int? expected = 42;
            var some = FSharpOption<int>.Some(expected.Value);
            var result = Option.OptionToNullable(some);

            Assert.AreEqual(expected, result);
        }
    }
}
