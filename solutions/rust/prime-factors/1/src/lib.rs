pub fn factors(n: u64) -> Vec<u64> {
    let mut dividend = n.clone();
    let mut factors = Vec::new();

    let mut candidates = 2..;

    while dividend > 1 {
        let x = candidates.next().unwrap();

        while dividend % x == 0 {
            dividend /= x;
            factors.push(x);
        }
    }

    factors
}
