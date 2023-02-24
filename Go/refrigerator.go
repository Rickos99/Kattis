package main

import (
	"fmt"
	"math"
)

type tripData struct {
	tripsCarA int
	tripsCarB int
	cost      float64
}

func main() {
	var pa, ka, pb, kb, n float64
	fmt.Scan(&pa, &ka, &pb, &kb, &n)

	var bestTrip = tripData{0, 0, math.MaxFloat64}
	var maxTripsCarA = math.Ceil(n / ka)

	for tripsCarA := 0.0; tripsCarA <= maxTripsCarA; tripsCarA++ {
		var tripsCarB = math.Ceil((n - tripsCarA*ka) / kb)
		var cost = tripsCarA*pa + tripsCarB*pb
		if cost < bestTrip.cost {
			bestTrip = tripData{int(tripsCarA), int(tripsCarB), cost}
		}
	}
	fmt.Println(bestTrip.tripsCarA, bestTrip.tripsCarB, bestTrip.cost)
}
