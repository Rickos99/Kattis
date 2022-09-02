import Data.ByteString.Char8 (intercalate)

correctSet :: [Int]
correctSet = [1, 1, 2, 2, 2, 8]

bijele :: [Int] -> [Int]
bijele xs = map ((-1) *) diff
  where
    diff = zipWith (-) xs correctSet

parseInts :: String -> [Int]
parseInts = (map read) . words

writeOutput :: [Int] -> String
writeOutput a = unwords (map show a)

main :: IO ()
main = do
  input <- getLine
  putStrLn (writeOutput (bijele (parseInts input)))
