parseInts :: String -> [Int]
parseInts = (map read) . words

writeOutput :: [Int] -> String
writeOutput a = unwords (map show a)

solution :: [Int] -> Int
solution [x] = x
solution (x : xs) = x * solution xs

main :: IO ()
main = do
  input <- getLine
  let x = solution (parseInts input)
  print x