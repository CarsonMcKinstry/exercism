// This stub file contains items that aren't used yet; feel free to remove this module attribute
// to enable stricter warnings.
#![allow(unused)]

use std::collections::HashMap;

pub fn can_construct_note(magazine: &[&str], note: &[&str]) -> bool {
    let mut words: HashMap<&str, i32> = HashMap::new();

    for word in magazine.iter() {
        words.entry(&word).and_modify(|i| {
            *i += 1;
        }).or_insert(1);
    }

    for word in note.iter() {
        words.entry(&word).and_modify(|i| {
            *i -= 1;
        }).or_insert(-1);

        if words[*word] < 0 {
            return false;
        }
    }

    true
}
