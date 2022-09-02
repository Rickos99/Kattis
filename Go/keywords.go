package main

import (
	"bufio"
	"fmt"
	"os"
	"strings"
)

func main() {
	var n int
	fmt.Scanln(&n)
	k := make(map[string]int)
	r := bufio.NewReader(os.Stdin)
	for n > 0 {
		s, _ := r.ReadString('\n')
		s = strings.ToLower(s)
		s = strings.ReplaceAll(s, " ", "-")
		k[s]++
		n--
	}
	fmt.Println(len(k))
}
