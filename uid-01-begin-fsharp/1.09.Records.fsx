open System

type Date = {
    year: int
    day: int
    month: int
}

type Person = {
    firstName: string
    lastName: string
    birthDate: Date
}

let cloneFn pPerson cloneDate =
    {pPerson with birthDate = cloneDate}

let me = {
    firstName = "John"
    lastName = "Doe"
    birthDate = { year=1990; month=06; day=20} }

let alterEgo = cloneFn me { year=2000; month= 12; day=31 }

