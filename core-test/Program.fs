open Expecto
open RecFail.Core

[<Tests>]
let tests =
  testList "Rec Fail test group" [
    test "Test HP5+ RF for 10sec exposure" {
      let emulsion = Emulsion.HP5
      let time = 10.0
      let actual = calculateRecFail emulsion time
      let expected = 20.4

      Expect.equal actual expected "For 10sec exposure HP5+ RF should be 20.4sec"
    }
    test "Test FP4+ RF for 10sec exposure" {
      let emulsion = Emulsion.FP4
      let time = 10.0
      let actual = calculateRecFail emulsion time
      let expected = 18.2

      Expect.equal actual expected "For 10sec exposure FP4+ RF should be 18.2sec"
    }
  ]

module Main =
  [<EntryPoint>]
  let main argv =
    Tests.runTestsInAssembly defaultConfig argv
