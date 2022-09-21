package main

import (
	"fmt"
	"math"
)

func main() {
	var h, v float64
	fmt.Scanln(&h, &v)
	fmt.Println(math.Ceil(h / math.Sin(v/180*math.Pi)))
}
