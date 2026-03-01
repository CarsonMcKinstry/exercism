object Hamming {

    fun compute(leftStrand: String, rightStrand: String): Int {
        if (leftStrand.length != rightStrand.length) {
            throw IllegalArgumentException("left and right strands must be of equal length")
        }
        var count: Int = 0;
        
        for ((index, char) in leftStrand.iterator().withIndex()) {
            if (char != rightStrand[index]) {
                count++;
            }
        }

        return count;
    }
}
