use enum_iterator::{all, Sequence};
use int_enum::IntEnum;

#[repr(u32)]
#[derive(Debug, Clone, Copy, PartialEq, Eq, Sequence, IntEnum)]
pub enum ResistorColor {
    Black = 0,
    Brown = 1,
    Red = 2,
    Orange = 3,
    Yellow = 4,
    Green = 5,
    Blue = 6,
    Violet = 7,
    Grey = 8,
    White = 9,
}

impl ResistorColor {
    pub fn to_string(&self) -> String {
        format!(
            "{}",
            match self {
                ResistorColor::Black => "Black",
                ResistorColor::Brown => "Brown",
                ResistorColor::Red => "Red",
                ResistorColor::Orange => "Orange",
                ResistorColor::Yellow => "Yellow",
                ResistorColor::Green => "Green",
                ResistorColor::Blue => "Blue",
                ResistorColor::Violet => "Violet",
                ResistorColor::Grey => "Grey",
                ResistorColor::White => "White",
            }
        )
    }
}

pub fn color_to_value(color: ResistorColor) -> u32 {
    color.int_value() as u32
}

pub fn value_to_color_string(value: u32) -> String {
   match ResistorColor::from_int(value) {
       Ok(v) => v.to_string(),
       _ => format!("value out of range")
   }
}

pub fn colors() -> Vec<ResistorColor> {
    all::<ResistorColor>().collect::<Vec<_>>()
}
