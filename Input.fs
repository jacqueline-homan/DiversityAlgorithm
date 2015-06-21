namespace Diversity
module Input =

    open System
    open System.IO
    open Diversity.Types

    let rec noob() =
        printfn "Are you trying to break into software development?"
        printfn "Enter 'Y' for Yes, 'N' for No" 
        let answer = Console.ReadLine()
        match answer with 
        | "Y" -> printfn "Seeking entry: %s" answer
        | "N" -> printfn "Seeking entry: %s" answer
                 exit 0
        | _ -> printfn "INVALID ENTRY: Enter Y or N:"
               noob()

    let rec education() = 
        printfn "What was your highest level of education obtained?"
        printfn "Enter the following that most fits, then hit 'Enter':"
        printfn "High School Diploma/GED or less"
        printfn "Trade Scool"
        printfn "Some College"
        printfn "Bachelors Degree"
        printfn "Masters Degree"
        printfn "Doctorate Degree"
        let response = Console.ReadLine().Trim().ToUpper()
        match response with
        | "High School Diploma/GED or less" -> HighSchoolOrLess
        | "Trade Scool" -> TradeSchool
        | "Some College" -> SomeCollege
        | "Bachelors Degree" -> Bachelors
        | "Masters Degree" -> Masters
        | "Doctorate Degree" -> Doctorate
        | _ -> printfn "INVALID ENTRY"
               education()

    and degree() =
        printfn "If you have a college degree, was it in Computer Science?"
        printfn "Enter 'Y' for Yes, 'N' for No: "
        let resp = Console.ReadLine().Trim()
        match resp with
        | _ when resp = "Y" -> ComputerScience
        | _ when resp = "N" -> printfn "Was your degree in another STEM field?"
                               printfn " Enter 'Y' for Yes, 'N' for No: "
                               let r = Console.ReadLine().Trim()
                               match r with
                               | "Y" -> OtherSTEM
                               | "N" -> Other
                               | _ -> printfn "INVALID ENTRY - Must enter Y or N"
                                      degree()
        | _ -> printfn "Oh noes! Invalid Entry. Must enter Y or N"
               degree()

