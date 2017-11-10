module RecFail.Core

open System

let sfxFact = 1.43
let panfFact = 1.33
let d100Fact = 1.26
let d400Fact = 1.41
let d3200Fact = 1.33
let fp4Fact = 1.26
let hp5Fact = 1.31
let xp2Fact = 1.31
let k100Fact = 1.26
let k400Fact = 1.33

type Emulsion =
| SFX 
| PanF
| D100
| D400
| D3200
| FP4
| HP5
| XP2
| K100
| K400

let calcRecFail factor time =
  let result = Math.Pow(time, factor)
  // printfn "result= %A" result
  Math.Round(result, 1)

let calculateRecFail emulsion time =
  match emulsion with
  | SFX  -> calcRecFail sfxFact time
  | PanF -> calcRecFail panfFact time
  | D100 -> calcRecFail d100Fact time
  | D400 -> calcRecFail d400Fact time
  | D3200 -> calcRecFail d3200Fact time
  | FP4 -> calcRecFail fp4Fact time
  | HP5 -> calcRecFail hp5Fact time
  | XP2 -> calcRecFail xp2Fact time
  | K100 -> calcRecFail k100Fact time
  | K400 -> calcRecFail k400Fact time