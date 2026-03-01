#[derive(Debug, PartialEq, Eq)]
pub enum Comparison {
    Equal,
    Sublist,
    Superlist,
    Unequal,
}

pub fn is_sublist<T: PartialEq> (a: &[T], b: &[T]) -> bool {
    let b: Vec<_> = b.iter().collect();

    a.len() == 0 || b.windows(a.len())
        .any(|window| {
            let a: Vec<_> = a.iter().collect();
            let mut win = vec![];
            win.extend_from_slice(window);
            win == a
        })
}

pub fn sublist<T: PartialEq>(a: &[T], b: &[T]) -> Comparison {

    let diff: isize = a.len() as isize - b.len() as isize;

    match diff {
        x if x.is_negative() && is_sublist(a, b) => Comparison::Sublist,
        x if x.is_positive() && is_sublist(b, a) => Comparison::Superlist,
        _ if a.len() == 0 && b.len() == 0 || a == b => Comparison::Equal,
        _ => Comparison::Unequal
    }
}
