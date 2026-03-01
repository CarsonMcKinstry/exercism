import java.util.Random
import kotlin.math.floor

class DndCharacter {

    val strength: Int = ability()
    val dexterity: Int = ability()
    val constitution: Int = ability()
    val intelligence: Int = ability()
    val wisdom: Int = ability()
    val charisma: Int = ability()
    val hitpoints: Int = 10 + modifier(constitution)

    companion object {

        fun ability(): Int {
            val rolls = roll(4, 6)
            val top3Scores = topThree((rolls))
            return top3Scores.sum()
        }

        fun modifier(score: Int): Int = floor((score - 10.0) / 2.0).toInt()
    }
}

fun roll(numberOfDice: Int, numberOfSides: Int): Array<Int> {
    val roller = Random()

    return Array(numberOfDice) { _ -> roller.nextInt(numberOfSides) }
}

fun topThree(rolls: Array<Int>): Array<Int> {
    val sorted = rolls.sortedDescending()

    val (first, second, third) = sorted;

    return arrayOf(first, second, third)
}