module FizzBuzzerTests
open NUnit.Framework

[<TestFixture>]
type myFixture() = class
    
    [<Test>]
    member self.TestOne() =
        Assert.That(FizzBuzzer.Translate 1, Is.EqualTo("1"))

end

