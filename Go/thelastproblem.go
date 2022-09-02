package main

import (
	"bufio"
	"fmt"
	"os"
)

func main() {
	var name string
	reader := bufio.NewReader(os.Stdin)
	name, _ = reader.ReadString('\n')

	name = name[:len(name)-2]
	fmt.Print("Thank you, " + name + ", and farewell!")
}
