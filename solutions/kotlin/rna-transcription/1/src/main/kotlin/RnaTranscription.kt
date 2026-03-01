fun transcribeToRna(dna: String): String = dna.map { when (it) {
    'A' -> 'U'
    'T' -> 'A'
    'C' -> 'G'
    'G' -> 'C'
    else -> ""
} }.joinToString("")
