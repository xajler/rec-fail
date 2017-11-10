namespace RecFail.Models

open System

type FormModel() =
  member val emulsion: string = String.Empty with get, set
  member val time: int = 1 with get, set
  member val result: float = 0.0 with get, set
  member val message: string = String.Empty with get, set 
