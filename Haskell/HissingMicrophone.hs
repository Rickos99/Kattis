solution :: String -> String
solution (c0 : c1 : c) = if c0 == 's' && c1 == 's' then "hiss" else solution (c1 : c)
solution _ = "no hiss"

main = do
  word <- getLine
  let sol = solution word
  putStr sol