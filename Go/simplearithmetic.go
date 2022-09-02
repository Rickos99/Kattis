package main

import (
	"fmt"
	"math/big"
)

func main() {
	var a, b, c big.Float

	fmt.Scanln(&a, &b, &c)
	prod := new(big.Float).Mul(&a, &b)
	quot := prod.Quo(prod, &c)
	fmt.Println(quot)
}
