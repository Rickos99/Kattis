package main

import "fmt"

func main() {
	var cost float64
	var lawns int

	fmt.Scanln(&cost)
	fmt.Scanln(&lawns)

	var area float64
	for lawns > 0 {
		var w, l float64
		fmt.Scanln(&w, &l)

		area += w * l
		lawns--
	}
	fmt.Println(area * cost)
}
