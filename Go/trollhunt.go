package main

import (
	"fmt"
)

func main() {
	var b, k, g int
	fmt.Scanln(&b, &k, &g)

	b -= 1
	d := b / (k / g)
	if b%(k/g) != 0 {
		d++
	}
	fmt.Println(d)
}
