module RecFail.Helpers

open Core

let toEmulsion text =
  match text with
  | "SFX" -> SFX
  | "PanF" -> PanF
  | "D100" -> D100
  | "D400" -> D400
  | "D3200" -> D3200
  | "FP4" -> FP4
  | "HP5" -> HP5
  | "XP2" -> XP2
  | "K100" -> K100
  | "K400" -> K400
  | _ -> invalidArg "emulsion" (sprintf "Value: %s is not emulsion." text)

let toTime time =
  if time > 1 then time
  else invalidArg "time" (sprintf "Time: %i must be greater than 1." time)