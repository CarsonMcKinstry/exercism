import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.ThreadLocalRandom;

class DnDCharacter {

    private final int ROLL_MIN = 1;
    private final int ROLL_MAX = 6;

    final int ability(List<Integer> scores) {

        List<Integer> copy = new ArrayList<>(scores);

        copy.sort((a, b) -> b.compareTo(a));

        List<Integer> topThree = copy
                .subList(0, 3);

        int total = 0;

        for (Integer score : topThree) {
            total += score;
        }

        return total;
    }

    final List<Integer> rollDice() {
        List<Integer> dice = new ArrayList<>();

        for (int i = 0; i < 4; i++) {
            dice.add(
                    ThreadLocalRandom.current().nextInt(
                            ROLL_MIN,
                            ROLL_MAX + 1));
        }

        return dice;
    }

    final int modifier(int input) {
        return Math.floorDiv(input - 10, 2);
    }

    public DnDCharacter() {
        this.strength = ability(rollDice());
        this.dexterity = ability(rollDice());
        this.constitution = ability(rollDice());
        this.intelligence = ability(rollDice());
        this.wisdom = ability(rollDice());
        this.charisma = ability(rollDice());
        this.hitpoints = 10 + modifier(this.constitution);
    }

    private int strength;

    int getStrength() {
        return strength;
    }

    private int dexterity;

    int getDexterity() {
        return dexterity;
    }

    private int constitution;

    int getConstitution() {
        return constitution;
    }

    private int intelligence;

    int getIntelligence() {
        return intelligence;
    }

    private int wisdom;

    int getWisdom() {
        return wisdom;
    }

    private int charisma;

    int getCharisma() {
        return charisma;
    }

    private int hitpoints;

    int getHitpoints() {
        return hitpoints;
    }
}
