module Demo where

root :: (Double -> Double) -> Double -> Double -> Double
root f a b | f a == 0 = a
 	   | f b == 0 = b
	   | abs (b - a)  < 0.0001 = roundTo3 a
	   | (f $ (b + a)/2) * (f a) < 0 = root f a $ (b + a)/2 
	   | otherwise = root f ((b + a)/2) b
	where
		roundTo3 :: (RealFrac a) => a -> a
		roundTo3 x = fromIntegral f / 1000
			where f = round (x * 1000)
 		
