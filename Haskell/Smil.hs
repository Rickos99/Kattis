solution :: [Char] -> Int -> [Int]
solution c i
  | isSmile2 c i = i : solution c (i + 2)
  | isSmile3 c i = i : solution c (i + 3)
  | i - 1 > length c = []
  | otherwise = solution c (i + 1)

isSmile2 :: [Char] -> Int -> Bool
isSmile2 c i
  | i + 1 < length c && (smile1 || smile2) = True
  | otherwise = False
  where
    smile1 = c !! i == ':' && c !! (i + 1) == ')'
    smile2 = c !! i == ';' && c !! (i + 1) == ')'

isSmile3 :: [Char] -> Int -> Bool
isSmile3 c i
  | i + 2 < length c && (smile1 || smile2) = True
  | otherwise = False
  where
    smile1 = c !! i == ':' && c !! (i + 1) == '-' && c !! (i + 2) == ')'
    smile2 = c !! i == ';' && c !! (i + 1) == '-' && c !! (i + 2) == ')'

main = do
  c <- getLine
  let sol = solution c 0
  mapM_ print sol