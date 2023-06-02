package main

import (
	"fmt"
	"math"
)

var one float64 = 1.0

type Artichoke struct {
	p, a, b, c, d float64
}

func main() {
	var p, a, b, c, d, n float64
	fmt.Scanln(&p, &a, &b, &c, &d, &n)

	var artichoke = Artichoke{p, a, b, c, d}

	var maxDecline = 0.0
	var max = artichoke.price(&one)
	var min = max
	for k := 2.0; k <= n; k++ {
		var price = artichoke.price(&k)
		if max < price {
			max = price
			min = price
		} else if price < min {
			min = price
		}
		if maxDecline < max-min {
			maxDecline = max - min
		}
	}

	fmt.Printf("%.9f", maxDecline)
}

func (r *Artichoke) price(k *float64) float64 {
	return r.p * (math.Sin(r.a*(*k)+r.b) + math.Cos(r.c*(*k)+r.d) + 2)
}
