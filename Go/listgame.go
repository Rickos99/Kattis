package main

import "fmt"

func main() {
	var number int
	fmt.Scanln(&number)

	var currentFactor = 2
	var factorCount = 1

	for currentFactor*currentFactor <= number {
		if number%currentFactor == 0 {
			number /= currentFactor
			factorCount++
		} else {
			currentFactor++
		}
	}

	fmt.Println(factorCount)
}
