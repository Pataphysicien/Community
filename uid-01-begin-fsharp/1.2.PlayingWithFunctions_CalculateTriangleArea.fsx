let triangleV = (4.0 , 5.0 , 3.0)

let semiperimeterFn pTriangle =
    let sideA,sideB,sideC = pTriangle
    (0.5*(sideA + sideB + sideC))

let triangleAreaFn pTriangle =
    let sideA, sideB, sideC = pTriangle
    let s = semiperimeterFn pTriangle
    sqrt(s*(s-sideA)*(s-sideB)*(s-sideC))

triangleAreaFn triangleV