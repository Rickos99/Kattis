package main

import (
	"fmt"
	"math"
)

func main() {
	var p, a, b, c, d, n float64
	fmt.Scanln(&p, &a, &b, &c, &d, &n)

	var maxDecline = 0.0
	var max = price(1, p, a, b, c, d)
	var min = max
	for k := 2.0; k <= n; k++ {
		var price = price(k, p, a, b, c, d)
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

func price(k, p, a, b, c, d float64) float64 {
	return p * (math.Sin(a*k+b) + math.Cos(c*k+d) + 2)
}
