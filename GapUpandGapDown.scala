//https://www.hackerrank.com/contests/moodys-analytics-2018-university-codesprint/challenges/gap-up-down/problem
object MyClass {
      def solve(low: Array[Int], high: Array[Int], close: Array[Int]) {
        var n = low.length-1
        var up = 0
        var down = 0
        for(i <- 0 until n)
        {
            if(low(i+1)>close(i))
            {
                up += 1
            }
            if(high(i+1)<close(i))
            {
                down += 1
            }
        }
        print(up+" "+down)
    }

      def main(args: Array[String]) {
         val low = Array(2,8,6,12)
         val high = Array(10,15,13,20)
         val close = Array(6,12,11,16)
         solve(low, high, close)
      }
      
   }
