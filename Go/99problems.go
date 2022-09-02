package main

import "fmt"

func main() {
	var p int
	fmt.Scanln(&p)

	r := p % 100
	if r < 50-1 {
		p := p - r - 1
		if p > 0 {
			fmt.Println(p)
			return
		}
	}
	fmt.Println(p + (99 - r))
}
