object Pangram {

    fun isPangram(input: String): Boolean = input
        .toLowerCase()
        .split("")
        .filter { it in "a".."z" }
        .toSet()
        .size == 26
}
