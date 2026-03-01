use unicode_segmentation::UnicodeSegmentation;

pub fn reverse(input: &str) -> String {
    let mut out: String = "".to_owned();

    for char in input.graphemes(true) {
       let temp = format!("{}{}", char, out);

        out = temp;
    }

    format!("{}", out)
}
