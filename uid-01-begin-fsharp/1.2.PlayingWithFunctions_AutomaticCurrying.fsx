let ageOfBob = 2
let ageOfSam = 4

//Remember, F# function take only one argument,
//...but this one looks like having two :
let addAges bob sam =
    bob + sam

let sumOfAges1 = addAges ageOfBob ageOfSam;
printfn "%A" sumOfAges1

//  Let's take a look a the output signature of 'addAges':
//      val addAges : bob:int -> sam:int -> int
//  it's actually a function returning a function returning an int !
//  F# has rewritten the function, we could also have write it like this :
let addAgesV2 bob =
    let addAgesV2_Sub sam =
        bob + sam
    addAgesV2_Sub

let sumOfAges2 = addAgesV2 ageOfBob ageOfSam
printfn "%A" sumOfAges2
