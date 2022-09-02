package main

import (
	"fmt"
	"sort"
)

func main() {
	var n, t int
	fmt.Scanln(&n, &t)

	a := n * t

	p := make([]int, n)
	for i := 0; i < n; i++ {
		fmt.Scanln(&p[i])
	}
	sort.Sort(sort.Reverse(sort.IntSlice(p)))
	for i := n; i > 0; i-- {
		if i*t+p[i-1] <= a {
			fmt.Println("NO")
			return
		}
	}
	fmt.Println("YES")
}
