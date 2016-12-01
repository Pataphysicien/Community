//Coordinates (lat, long) + See level (meters)
let location = (77.51, 166.40, 21)

let longAlt location =
    let long, _, alt = location
    (alt, long)

printfn "%A" (fst (longAlt location))

//Exercice
    //Create a function that takes your birthday in the following form (dd,mm,yy)
    //return your birthday from the function in the form (yy,mm,dd) using decompoisation and reconstruction.

let myBirthday = (15,09,1984)

let toDate_yyyymmdd date_ddmmyyyy =
    let dd, mm, yyyy = date_ddmmyyyy
    (yyyy, mm, dd)

printfn "%A" (toDate_yyyymmdd myBirthday)