//https://www.hackerrank.com/contests/moodys-analytics-2018-university-codesprint/challenges/meeting-profit-target
import java.io._
import java.math._
import java.security._
import java.text._
import java.util._
import java.util.concurrent._
import java.util.function._
import java.util.regex._
import java.util.stream._
import scala.collection.immutable._
import scala.collection.mutable._
import scala.collection.concurrent._
import scala.collection.parallel.immutable._
import scala.collection.parallel.mutable._
import scala.concurrent._
import scala.io._
import scala.math._
import scala.sys._
import scala.util.matching._
import scala.reflect._

object MyClass {
      def solve(profits: Array[Array[Int]]): Int = {
        var result = 0
        for(i <- profits)
        {
            for(j <- 0 until i.length-1)
            {
                if(i(j)<i(j+1))
                {
                    result += 1
                }
                else if(i(j)>i(j+1))
                {
                    result -= 1
                }
            }
        }
        result
    }

      def main(args: Array[String]) {
        val t = StdIn.readLine.trim.toInt
        for (tItr <- 1 to t) {
            val n = StdIn.readLine.trim.toInt

            val profits = Array.ofDim[Int](n, 2)

            for (i <- 0 until n) {
                profits(i) = StdIn.readLine.replaceAll("\\s+$", "").split(" ").map(_.trim.toInt)
            }

            val res = solve(profits)

            println(res)
        }
      }
      
   }
