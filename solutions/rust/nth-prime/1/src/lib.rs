pub fn nth(n: usize) -> usize {
    if n == 0 {
        return 2;
    }

    let mut primes: Vec<usize> = Vec::new();

    let mut current_candidate = 3;

    while n >= primes.len() {
        if is_prime(&primes, current_candidate) {
            primes.push(current_candidate);
            if n == primes.len() {
                return current_candidate;
            }
        }
        current_candidate += 2;
    }
    return current_candidate;
}

fn is_prime(primes: &Vec<usize>, candidate: usize) -> bool {
    if candidate % 2 == 0 {
        return false;
    }

    for n in primes {
        if candidate % n == 0 {
            return false;
        }
    }

    return true;
}
