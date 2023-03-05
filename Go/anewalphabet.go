package main

import (
	"bufio"
	"fmt"
	"os"
	"strings"
)

func main() {
	translation := map[string]string{
		"a": "@",
		"b": "8",
		"c": "(",
		"d": "|)",
		"e": "3",
		"f": "#",
		"g": "6",
		"h": "[-]",
		"i": "|",
		"j": "_|",
		"k": "|<",
		"l": "1",
		"m": "[]\\/[]",
		"n": "[]\\[]",
		"o": "0",
		"p": "|D",
		"q": "(,)",
		"r": "|Z",
		"s": "$",
		"t": "']['",
		"u": "|_|",
		"v": "\\/",
		"w": "\\/\\/",
		"x": "}{",
		"y": "`/",
		"z": "2",
	}

	reader := bufio.NewReader(os.Stdin)
	input, _ := reader.ReadString('\n')

	var sb strings.Builder
	for _, c := range input {
		key := strings.ToLower(string(c))
		if val, ok := translation[key]; ok {
			sb.WriteString(val)
		} else {
			sb.WriteString(key)
		}
	}

	fmt.Println(sb.String())
}
