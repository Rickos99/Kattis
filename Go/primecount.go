package main

import "fmt"

func main() {
	var n uint64
	fmt.Scanln(&n)
	fmt.Println(calculatePrimes(n))
}

func calculatePrimes(n uint64) uint64 {
	prime := make([]bool, uint64(n+1))
	for i := 0; i < len(prime); i++ {
		prime[i] = true
	}

	for i := 2; i*i < len(prime); i++ {
		if prime[i] {
			for j := i * i; j < len(prime); j += i {
				prime[j] = false
			}
		}
	}

	count := uint64(0)
	for i := 2; i < len(prime); i++ {
		if prime[i] {
			count++
		}
	}
	return count
}
