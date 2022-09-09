package main

import "fmt"

func main() {
	var n, k, j int
	fmt.Scanln(&n, &k)

	ns := make([]bool, n+1)
	for i := 2; i <= n; i++ {
		for j = i; j <= n; j += i {
			if ns[j] == false {
				ns[j] = true
				k--
				if k == 0 {
					fmt.Println(j)
				}
			}
		}
	}
}
