/// Create an empty vector
pub fn create_empty() -> Vec<u8> {
    vec!()
}

/// Create a buffer of `count` zeroes.
///
/// Applications often use buffers when serializing data to send over the network.
pub fn create_buffer(count: usize) -> Vec<u8> {
    let mut vec: Vec<u8> = vec!();

    for _ in 0..count {
        vec.push(0);
    }

    vec
}

/// Create a vector containing the first five elements of the Fibonacci sequence.
///
/// Fibonacci's sequence is the list of numbers where the next number is a sum of the previous two.
/// Its first five elements are `1, 1, 2, 3, 5`.
pub fn fibonacci() -> Vec<u8> {
    let mut a = 1;
    let mut b = 1;

    let mut fib_vec: Vec<u8> = vec!();

    fib_vec.push(a);
    fib_vec.push(b);

    while fib_vec.len() < 5 {
        let temp = b;
        b = a + b;
        a = temp;

        fib_vec.push(b);
    }

    fib_vec
}
