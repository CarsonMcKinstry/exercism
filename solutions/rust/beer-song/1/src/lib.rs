fn number_bottles(n: u32) -> String {
    match n {
        0 => "No more".to_string(),
        c => c.to_string()
    }
}

fn bottles(n: u32) -> String {
    match n {
        1 => "bottle".to_string(),
        _ => "bottles".to_string()
    }
}

pub fn verse(n: u32) -> String {

    let second_line = match n {
        0 => "Go to the store and buy some more, 99 bottles of beer on the wall.".to_string(),
        c => {
            let which_bottle = match c {
                1 => "it",
                _ => "one"
            };

            format!("Take {} down and pass it around, {} {} of beer on the wall.", which_bottle, number_bottles(c - 1).to_lowercase(), bottles(c - 1))
        }
    };

    format!("{} {} of beer on the wall, {} {} of beer.\n{}\n", number_bottles(n), bottles(n), number_bottles(n).to_lowercase(), bottles(n), second_line)
}

pub fn sing(start: u32, end: u32) -> String {
    (end..=start).rev()
        .map(|n| verse(n))
        .collect::<Vec<String>>()
        .join("\n")
}
