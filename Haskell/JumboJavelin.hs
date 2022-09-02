solution :: [Int] -> Int
solution xs = sum xs - length xs + 1

readLines :: Int -> IO [Int]
readLines 0 = return []
readLines n = do
  x <- fmap read getLine
  rest <- readLines (n -1)
  return $ x : rest

readSomeNumberOfLines :: IO [Int]
readSomeNumberOfLines = do
  n <- fmap read getLine
  readLines n

main :: IO ()
main = do
  nr <- getLine
  let n = read nr :: Int
  int <- readLines n
  let sol = solution int
  print sol