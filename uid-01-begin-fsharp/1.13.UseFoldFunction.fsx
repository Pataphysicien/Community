

let francePopu = 67063000
let germanyPop = 81276000
let ukPop = 65081000

let populations = [francePopu,germanyPop,ukPop]

List.fold (fun pState nextItem -> pState + nextItem) 0 populations