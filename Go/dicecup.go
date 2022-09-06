package main

import "fmt"

func main() {
	var d1, d2 int
	fmt.Scanln(&d1, &d2)

	if d2 < d1 {
		d2, d1 = d1, d2
	}

	for i := d1 + 1; i < d2+2; i++ {
		fmt.Println(i)
	}
}
