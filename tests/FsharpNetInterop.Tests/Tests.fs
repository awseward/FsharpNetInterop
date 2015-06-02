module FsharpNetInterop.Tests

open FsharpNetInterop.Option
open NUnit.Framework
open System

[<Test>]
let ``ReferenceToOption should work for null values``() = 
    let (nullStr : string) = null
    let expected = None
    let processed = ReferenceToOption nullStr
    Assert.AreEqual(expected, processed)

[<Test>]
let ``ReferenceToOption should work for actual values``() = 
    let str = "This is a string."
    let expected = Some str
    let processed = ReferenceToOption str
    Assert.AreEqual(expected, processed)

[<Test>]
let ``NullableToOption should work for null values``() = 
    let nullInt = Nullable<int>()
    let expected = None
    let processed = NullableToOption nullInt
    Assert.AreEqual(expected, processed)

[<Test>]
let ``NullableToOption should work for Nullables with value``() = 
    let actualInt = Nullable(42)
    let expected = Some actualInt.Value
    let processed = NullableToOption actualInt
    Assert.AreEqual(expected, processed)

[<Test>]
let ``OptionToReference should work given None``() = 
    let none = None
    let expected = null
    let processed = OptionToReference none
    Assert.AreEqual(expected, processed)

[<Test>]
let ``OptionToReference should work given Some``() = 
    let expected = "This is a string."
    let some = Some expected
    let processed = OptionToReference some
    Assert.AreEqual(expected, processed)

[<Test>]
let ``OptionToNullable should work given None``() = 
    let none = None
    let expected = null
    let processed = OptionToNullable none
    Assert.AreEqual(expected, processed)

[<Test>]
let ``OptionToNullable should work given Some``() = 
    let some = Some 42
    let expected = Nullable(42)
    let processed = OptionToNullable some
    Assert.AreEqual(expected, processed)
