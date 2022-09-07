package main

import (
	"fmt"
	"sort"
)

func main() {
	var n int
	fmt.Scanln(&n)

	L := make([]int, n)
	for i := 0; i < n; i++ {
		fmt.Scan(&L[i])
	}

	sort.Ints(L)

	for i := 0; i < n; i++ {
		if i < n-2 && L[i]-L[i+2] == -2 {
			fmt.Print(L[i])
			for i = i + 2; i+1 < n; i++ {
				if L[i]-L[i+1] != -1 {
					break
				}
			}
			fmt.Printf("-%d ", L[i])
		} else {
			fmt.Printf("%d ", L[i])
		}
	}
}
