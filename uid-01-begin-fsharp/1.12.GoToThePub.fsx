type coord2d = {
    x:int
    y:int
}

let addX pX pCoord =
    { pCoord with x = pCoord.x + pX }

let addY pY pCoord=
    { pCoord with y = pCoord.y + pY }

let startingPoint={x=5;y=20}

let arrivalPoint = 
    startingPoint |> addY 15
                  |> addX 60
                  |> addY -20
                  |> addX 30
                  |> addY 15
