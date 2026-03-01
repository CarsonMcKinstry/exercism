export class DnDCharacter {
    strength: number;
    dexterity: number;
    constitution: number;
    intelligence: number;
    wisdom: number;
    charisma: number;
    hitpoints: number;

    constructor() {
        this.strength = DnDCharacter.generateAbilityScore();
        this.dexterity = DnDCharacter.generateAbilityScore();
        this.constitution = DnDCharacter.generateAbilityScore();
        this.intelligence = DnDCharacter.generateAbilityScore();
        this.wisdom = DnDCharacter.generateAbilityScore();
        this.charisma = DnDCharacter.generateAbilityScore();
        this.hitpoints = 10 + DnDCharacter.getModifierFor(this.constitution);
    }

    private static roll(sides: number): number {
        return Math.ceil(Math.random() * sides);
    }

    public static generateAbilityScore(): number {
        const rolls = Array.from({ length: 4 }, () => this.roll(6));

        const min = Math.min(...rolls);

        for (const i of rolls) {
            const roll = rolls[i];

            if (min === roll) {
                rolls.splice(i, 1);
                break;
            }
        }

        return rolls.reduce((a, b) => a + b, 0);
    }

    public static getModifierFor(abilityValue: number): number {
        return Math.floor((abilityValue - 10) / 2);
    }
}
