import kotlin.math.sqrt

object Darts {
    fun score(x: Number, y: Number): Int {
        val d = distance(x.toDouble(), y.toDouble());

        return when (d) {
            in 0.0..1.0 -> 10
            in 1.0..5.0 -> 5
            in 5.0..10.0 -> 1
            else -> 0
        }
    }

    fun distance (x: Double, y: Double): Double {
        val a = x * x;
        val b = y * y;

        return sqrt((a + b).toDouble())
    }
}

    
