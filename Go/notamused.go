package main

import (
	"fmt"
	"sort"
)

func main() {
	var log map[string]float32
	var action, name string
	var n int
	var time float32
	day := 1

	fmt.Scanln(&action)
	for action != "" {
		if action == "OPEN" {
			log = make(map[string]float32)
			if day > 1 {
				fmt.Println()
			}
		} else if action == "CLOSE" {
			fmt.Println("Day", day)
			ks := []string{}
			for k := range log {
				ks = append(ks, k)
			}
			sort.Strings(ks)
			for _, k := range ks {
				fmt.Printf("%s $%.2f\n", k, log[k]*0.1)
			}
			day++
		} else {
			if action == "ENTER" {
				log[name] -= time
			} else {
				log[name] += time
			}
		}

		n, _ = fmt.Scanln(&action, &name, &time)
		if n == 0 {
			return
		}
	}
}
