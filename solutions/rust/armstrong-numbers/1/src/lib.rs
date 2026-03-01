pub fn is_armstrong_number(num: u32) -> bool {
    let digits: Vec<u32> = num
            .to_string()
            .split("")
            .filter_map(|d| d.parse::<u32>().ok())
            .collect();

    let num_digits = digits.len() as u32;

    let mut sum: u32 = 0;

    for digit in digits {
        sum += digit.pow(num_digits) as u32;
    }

    sum == num
}
