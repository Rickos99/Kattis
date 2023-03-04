package main

import "fmt"

func main() {
	var word, guesses []byte
	fmt.Scanln(&word)
	fmt.Scanln(&guesses)

	var wrongGuesses = 0
	for i := 0; i < len(guesses); i++ {
		var before = len(word)
		word = removeAll(word, guesses[i])
		if before == len(word) {
			wrongGuesses++
			if wrongGuesses == 10 {
				fmt.Println("LOSE")
				return
			}
		}
		if len(word) == 0 {
			fmt.Println("WIN")
			return
		}
	}
}

func removeAll(arr []byte, elementToRemove byte) []byte {
	for i := len(arr) - 1; i >= 0; i-- {
		if arr[i] == elementToRemove {
			arr = remove(arr, i)
		}
	}
	return arr
}

func remove(arr []byte, index int) []byte {
	arr[index] = arr[len(arr)-1]
	return arr[:len(arr)-1]
}
