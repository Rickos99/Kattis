solution :: String -> String
solution "OCT 31" = "yup"
solution "DEC 25" = "yup"
solution _ = "nope"

main = do
  date <- getLine
  let sol = solution date
  putStrLn sol