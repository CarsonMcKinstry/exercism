// This stub file contains items that aren't used yet; feel free to remove this module attribute
// to enable stricter warnings.
#![allow(unused)]

pub struct Player {
    pub health: u32,
    pub mana: Option<u32>,
    pub level: u32,
}

impl Player {
    pub fn revive(&self) -> Option<Player> {
        if (self.health > 0) {
            None
        } else {
            let mana = if (self.level >= 10) {
                Some(100)
            } else {
                None
            };
            Some(
                Player {
                    health: 100,
                    mana,
                    level: self.level,
                }
            )
        }
    }

    pub fn cast_spell(&mut self, mana_cost: u32) -> u32 {
        if (self.mana.is_none()) {
            self.health = if (self.health < mana_cost) {
                0
            } else {
                self.health - mana_cost
            };
            0
        } else if (self.mana.filter(|m| m > &mana_cost).is_none()) {
            0
        } else {
            self.mana = self.mana.map(|m| m - mana_cost);
            2 * mana_cost
        }
    }
}
