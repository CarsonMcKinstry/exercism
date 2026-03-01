// This stub file contains items that aren't used yet; feel free to remove this module attribute
// to enable stricter warnings.
#![allow(unused)]

pub fn divmod(dividend: i16, divisor: i16) -> (i16, i16) {
    (
        dividend / divisor,
        dividend % divisor
    )
}

pub fn evens<T>(iter: impl Iterator<Item=T>) -> impl Iterator<Item=T> {
    iter
        .enumerate()
        .filter_map(|(i, e)| {
        match i % 2 {
            0 => Some(e),
            _ => None
        }
    })
}

pub struct Position(pub i16, pub i16);

impl Position {
    pub fn manhattan(&self) -> i16 {
        let Position(x, y) = self;

        return x.abs() + y.abs();
    }
}
