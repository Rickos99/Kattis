package main

import "fmt"

func main() {
	var input string
	fmt.Scanln(&input)

	answer := input[:len(input)-1] + input[1:]
	fmt.Println(answer)
}
