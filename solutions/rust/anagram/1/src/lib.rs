use std::collections::{HashSet, HashMap};

pub fn count_occurrences(word: &str) -> HashMap<char, usize> {
    let unique: HashSet<char> = word.to_lowercase().chars().collect();

    unique
        .iter()
        .map(|&c| (c, word.to_lowercase().matches(c).count()))
        .collect()
}

pub fn anagrams_for<'a>(word: &str, possible_anagrams: &[&'a str]) -> HashSet<&'a str> {
    let word_map = count_occurrences(word);

    possible_anagrams
        .iter()
        .filter_map(|&pa| {

            if &pa.to_lowercase() == &word.to_lowercase() {
                return None
            }

            let map = count_occurrences(&pa);

            if map == word_map {
                return Some(*&pa)
            } else {
                return None
            }
        })
        .collect()
}
