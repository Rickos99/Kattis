solution :: String -> Int
solution [] = 1
solution (x : xs)
  | x `elem` xs = 0
  | otherwise = solution xs

main :: IO ()
main = do
  input <- getLine
  print (solution input)
