fn get_neighbors(minefield: &[&str], i: i32, j: i32) -> Vec<char> {
    let top_left = (i - 1, j - 1);
    let top_mid = (i, j - 1);
    let top_right = (i + 1, j - 1);
    let mid_left = (i - 1, j);
    let mid_right = (i + 1, j);
    let bottom_left = (i - 1, j + 1);
    let bottom_mid = (i, j + 1);
    let bottom_right = (i + 1, j + 1);

    vec![
        top_left,
        top_mid,
        top_right,
        mid_left,
        mid_right,
        bottom_left,
        bottom_mid,
        bottom_right,
    ]
        .iter()
        .filter_map(|(i, j)| {
            if i < &0 || j < &0 || i >= &(minefield[0].len() as i32) || j >= &(minefield.len() as i32) {
                return None;
            }

            return minefield[*j as usize].chars().nth(*i as usize);
        })
        .collect()
}

fn count_mines(maybe_mines: Vec<char>) -> usize {
    maybe_mines
        .iter()
        .filter(|mine| *mine == &'*')
        .collect::<Vec<&char>>()
        .len()
}

pub fn annotate(minefield: &[&str]) -> Vec<String> {
    minefield
        .iter()
        .enumerate()
        .map(|(row_index, row)| {
            row
                .chars()
                .enumerate()
                .map(|(col_index, col)| {
                    if col == ' ' {
                        let num_mines = count_mines(get_neighbors(
                            minefield,
                            col_index as i32,
                            row_index as i32
                        ));

                        match num_mines {
                            0 => " ".to_string(),
                            n => n.to_string()
                        }
                    } else {
                        return col.to_string();
                    }
                })
                .collect::<Vec<String>>()
                .join("")
        })
        .collect()
}
