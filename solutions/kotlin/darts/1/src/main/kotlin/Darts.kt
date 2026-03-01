import kotlin.math.sqrt

object Darts {
    fun score(x: Int, y: Int): Int {
        val d = distance(x.toDouble(), y.toDouble());

        return when {
            d <= 1.0 -> 10
            d > 1.0 && 5.0 >= d -> 5
            d > 5.0 && 10.0 >= d -> 1 
            else -> 0
        }
    }
    fun score(x: Double, y: Double /* choose proper types! */): Int {
        val d = distance(x, y);

        return when {
            d <= 1.0 -> 10
            d > 1.0 && 5.0 >= d -> 5
            d > 5.0 && 10.0 >= d -> 1 
            else -> 0
        }
    }
    fun score(x: Double, y: Int): Int {
        val d = distance(x, y.toDouble());

        return when {
            d <= 1.0 -> 10
            d > 1.0 && 5.0 >= d -> 5
            d > 5.0 && 10.0 >= d -> 1 
            else -> 0
        }
    }
    fun score(x: Int, y: Double /* choose proper types! */): Int {
        val d = distance(x.toDouble(), y);

        return when {
            d <= 1.0 -> 10
            d > 1.0 && 5.0 >= d -> 5
            d > 5.0 && 10.0 >= d -> 1 
            else -> 0
        }
    }

    fun distance (x: Double, y: Double): Double {
        val a = x * x;
        val b = y * y;

        return sqrt((a + b).toDouble())
    }
}

    
