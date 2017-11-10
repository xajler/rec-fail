namespace RecFail.Controllers

open Microsoft.AspNetCore.Mvc
open RecFail.Models
open RecFail.Core
open RecFail.Helpers

type HomeController () =
  inherit Controller()

  member this.Index () =
    this.View()

  [<HttpPost>]
  [<ValidateAntiForgeryToken>]
  member this.Index(model: FormModel) =
    try 
      let emulsion = model.emulsion |> toEmulsion
      let time = model.time |> toTime
      model.result <- calculateRecFail emulsion (float time)
    with 
    | ex ->
      printfn "%s" ex.Message
      model.message <- (sprintf "Time: %i must be greater than 1. " model.time)

    this.View(model)
     

  member this.About () =
    this.ViewData.["Message"] <- "Your application description page."
    this.View()

  member this.Contact () =
    this.ViewData.["Message"] <- "Your contact page."
    this.View()

  member this.Error () =
    this.View();
