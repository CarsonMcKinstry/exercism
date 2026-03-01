/// Check a Luhn checksum.

fn remove_whitespace (str: &str) -> String {
    str
        .split_whitespace()
        .collect()
}

fn to_num_vector (str: &str) -> Vec<u8> {
    str
        .split("")
        .filter_map(|n| n.parse::<u8>().ok())
        .collect()
}

pub fn is_valid(code: &str) -> bool {

    let with_stripped_whitespace = remove_whitespace(code);

    let digits = to_num_vector(
        &with_stripped_whitespace
    );

    if digits.len() <= 1 || digits.len() != with_stripped_whitespace.len() {
        return false;
    }

    let double_evens = digits.len() % 2 == 0;

    let sum: u8 = digits
        .iter()
        .enumerate()
        .map(|(i, x)| {
            let is_even_id = i % 2 == 0;

            if double_evens && is_even_id || !double_evens && !is_even_id {
                let mut doubled = x * 2;

                if doubled > 9 {
                    doubled -= 9;
                }

                doubled
            } else {
                *x
            }
        })
        .sum();

    sum % 10 == 0
}
