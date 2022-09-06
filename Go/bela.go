package main

import (
	"fmt"
	"strings"
)

var t = map[string][2]int{
	"A": {11, 11},
	"K": {4, 4},
	"Q": {3, 3},
	"J": {20, 2},
	"T": {10, 10},
	"9": {14, 0},
	"8": {0, 0},
	"7": {0, 0},
}

func main() {
	var n int
	var b string
	fmt.Scanln(&n, &b)
	n = 4 * n

	s := 0
	for i := 0; i < n; i++ {
		var c string
		fmt.Scanln(&c)
		cs := strings.Split(c, "")
		if cs[1] == b {
			s += t[cs[0]][0]
		} else {
			s += t[cs[0]][1]
		}
	}
	fmt.Println(s)
}
