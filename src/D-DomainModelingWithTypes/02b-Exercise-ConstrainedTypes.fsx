open System

//----------------------------------------------------------
//  Q. Create a `NonZeroInteger`  type that can only contain non-zero integers

module ConstrainedTypes =

    type NonZeroInteger = private NonZeroInteger of int

    module NonZeroInteger =
        /// Public constructor
        let create i =
            ??

        /// Return the value
        let value ??  =
            ??

open ConstrainedTypes

// test
let x = NonZeroInteger.create 0


//----------------------------------------------------------
//  Q. Create a `ZipCode`  type that can only contain digit chars

open System

module ConstrainedTypes2 =

    type ZipCode = private ZipCode of string

    module ZipCode =
        /// Public constructor
        let create (s:string) =
            let isAllDigits = s |> Seq.forall Char.IsDigit
            if (s.Length = 5) && isAllDigits then
                Some (ZipCode s)
            else
                None

        /// Return the value
        let value (ZipCode str) = str



// test
open ConstrainedTypes2

let x2 = ZipCode.create "1234a
ZipCode "aaaa"


let value = x2 |> Option.get  // dont do this except for testing!

let x3 = ZipCode.create "abc"






