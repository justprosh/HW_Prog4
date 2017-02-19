module Demo where

myMin::(Double -> Double) -> Double -> Double -> Double
myMin f a b | abs(a - b) < 0.0001 = f a
            | f ((a + b)/3) < f ((a + b)/1.5) = myMin f a ((a + b)/3)
            | f ((a + b)/3) > f ((a + b)/1.5) = myMin f  ((a + b)/3) b
            | otherwise = myMin f ((a + b)/3) ((a + b)/1.5)
